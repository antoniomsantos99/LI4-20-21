using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Dapper;
using LightsOut.Data;
using Newtonsoft.Json.Linq;

namespace LightsOut
{
    public class DataManager
    {

        public string conString =
            "Data Source=(local);Initial Catalog=LightsOut;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        void loadEpocas(int from, int to)
        {
            /*Conecta á base de dados*/
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                /*Adiciona cada país individualmente á base de dados TODO: Passar para um bulkinsert do dapper PLUS*/
                for (int epoca = from; epoca <= to; epoca++)
                {
                    var sql = String.Format("If Not Exists(select * from [LightsOut].[dbo].Epoca where ano=\'{0}\') begin insert into [LightsOut].[dbo].Epoca values ({0}) end", epoca);
                    connection.Query(sql);
                }
            }
            Console.WriteLine("Epocas Adicionadas!");
        }
        
        void loadCircuitos()
        {
            /*Conecta á base de dados*/
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                
                /*Vê as epocas presentes na base de dados*/
                var result = connection.Query<int>("select ano from [LightsOut].[dbo].Epoca").ToList();

                foreach (var epoca in result)
                {
                    JObject info = getJsonFromURL(String.Format("http://ergast.com/api/f1/{0}/circuits.json",epoca));
                    foreach (var circuito in info["MRData"]["CircuitTable"]["Circuits"].ToList())
                    {
                        var sql = String.Format(
                            "If Not Exists(select * from [LightsOut].[dbo].Localizacao where id=\'{0}\') Begin insert into [LightsOut].[dbo].Localizacao values (\'{0}\',\'{1}\',\'{2}\',{3},{4}) End",
                            circuito["circuitId"],circuito["circuitName"],circuito["Location"]["country"] ,circuito["Location"]["lat"],circuito["Location"]["long"]);
                        var res = connection.Query(sql);
                        
                    }
                }
                
            }
        }
        
        
        void loadEquipas()
        {
            /*Conecta á base de dados*/
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                
                /*Vê as epocas presentes na base de dados*/
                var result = connection.Query<int>("select ano from [LightsOut].[dbo].Epoca").ToList();

                foreach (var epoca in result)
                {
                    JObject info = getJsonFromURL(String.Format("http://ergast.com/api/f1/{0}/constructors.json",epoca));
                    foreach (var equipa in info["MRData"]["ConstructorTable"]["Constructors"].ToList())
                    {
                        var sql = String.Format(
                            "If Not Exists(select * from [LightsOut].[dbo].Equipa where id=\'{0}\') Begin insert into [LightsOut].[dbo].Equipa values (\'{0}\',\'{1}\', \'{2}\') End",
                            equipa["constructorId"], equipa["name"], equipa["nationality"]);
                        var res = connection.Query(sql);
                        
                    }
                }
                
            }
        }
        
        void loadPilotos()
        {
            /*Conecta á base de dados*/
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                
                /*Vê as epocas presentes na base de dados*/
                var result = connection.Query<int>("select ano from [LightsOut].[dbo].Epoca").ToList();

                foreach (var epoca in result)
                {
                    JObject info = getJsonFromURL(String.Format("http://ergast.com/api/f1/{0}/drivers.json",epoca));
                    foreach (var piloto in info["MRData"]["DriverTable"]["Drivers"].ToList())
                    {
                        var sql = String.Format(
                            "If Not Exists(select * from [LightsOut].[dbo].Piloto where id=\'{0}\') Begin insert into [LightsOut].[dbo].Piloto values (\'{0}\',\'{1}\') End",
                            piloto["driverId"], piloto["givenName"] + " " + piloto["familyName"]);
                        var res = connection.Query(sql);
                        
                        /*
                        sql = String.Format(
                            "If Not Exists(select * from [LightsOut].[dbo].PilotoEquipa where idPiloto=\'{0}\' and idEpoca=\'{2}\') Begin insert into [LightsOut].[dbo].PilotoEquipa values (\'{0}\',\'{1}\', {2}) End",
                            piloto["driverId"], , epoca);
                        res = connection.Query(sql);
                        */
                    }
                }
                
            }
        }
        

        void loadProvas()
        {
            /*Conecta á base de dados*/
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                
                /*Vê as epocas presentes na base de dados*/
                var result = connection.Query<int>("select ano from [LightsOut].[dbo].Epoca").ToList();

                foreach (var epoca in result)
                {
                    JObject info = getJsonFromURL(String.Format("http://ergast.com/api/f1/{0}.json",epoca));
                    
                    foreach (var prova in info["MRData"]["RaceTable"]["Races"].ToList())
                    {
                        string id = prova["raceName"].ToString().Replace(" ", "") + prova["season"].ToString();
                        //Console.WriteLine(id);
                        
                        var sql = String.Format(
                            "If Not Exists(select * from [LightsOut].[dbo].Prova where id=\'{0}\') Begin insert into [LightsOut].[dbo].Prova values (\'{0}\',{1},{2},\'{3}\',\'{4}\', \'{5}\', \'{6}\') End",
                            id, prova["season"], prova["round"] ,prova["raceName"],prova["date"], prova["time"], prova["Circuit"]["circuitId"]);
                        var res = connection.Query(sql);
                        //Console.WriteLine(sql);
                    }
                }
                
            }
        }
        
        
        void loadResults()
        {
            /*Conecta á base de dados*/
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                
                /*Vê as epocas presentes na base de dados*/
                var provas = connection.Query("select * from [LightsOut].[dbo].Prova").ToList();

                foreach (var prova in provas)
                {
                    JObject results = getJsonFromURL(String.Format("http://ergast.com/api/f1/{0}/{1}/results.json",prova.idEpoca, prova.ronda));

                    foreach (var result in results["MRData"]["RaceTable"]["Races"][0]["Results"].ToList())
                    {
                        var sql = String.Format("If Not Exists(select * from [LightsOut].[dbo].Resultado where idPiloto = \'{0}\' and idProva = \'{1}\') begin insert into [LightsOut].[dbo].Resultado values (\'{1}\',\'{0}\',{2}, {3}, \'{4}\',{5},\'{6}\') end",
                            result["Driver"]["driverId"], 
                            results["MRData"]["RaceTable"]["Races"][0]["raceName"].ToString().Replace(" ", "") +  results["MRData"]["RaceTable"]["Races"][0]["season"], 
                            result["position"], 
                            result["grid"], 
                            result["Time"] != null ? result["Time"]["time"] : "Retired", 
                            result["points"], 
                            result["status"]);
                        
                        Console.WriteLine(sql);
                        connection.Query(sql);   
                    }

                }
            }
        }
        
        void loadQualificacao()
        {
            /*Conecta á base de dados*/
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                
                /*Vê as epocas presentes na base de dados*/
                var provas = connection.Query("select * from [LightsOut].[dbo].Prova").ToList();

                foreach (var prova in provas)
                {
                    JObject qualificacoes = getJsonFromURL(String.Format("http://ergast.com/api/f1/{0}/{1}/qualifying.json",prova.idEpoca, prova.ronda));

                    foreach (var qualificacao in qualificacoes["MRData"]["RaceTable"]["Races"][0]["QualifyingResults"].ToList())
                    {
                        var sql = String.Format(
                            "If Not Exists(select * from [LightsOut].[dbo].Qualificacao where idPiloto = \'{0}\' and idProva = \'{1}\') begin insert into [LightsOut].[dbo].Qualificacao values (\'{1}\',\'{0}\',{2}, \'{3}\', \'{4}\',\'{5}\') end",
                            qualificacao["Driver"]["driverId"],
                            qualificacao["MRData"]["RaceTable"]["Races"][0]["raceName"].ToString().Replace(" ", "") + qualificacao["MRData"]["RaceTable"]["Races"][0]["season"],
                            qualificacao["position"],
                            qualificacao["Q1"] != null ? qualificacao["Q1"] : "Eliminated",
                            qualificacao["Q2"] != null ? qualificacao["Q2"] : "Eliminated",
                            qualificacao["Q3"] != null ? qualificacao["Q3"] : "Eliminated");
                        
                        Console.WriteLine(sql);
                        connection.Query(sql);   
                    }

                }
            }
        }
        
        

        /* Carrega lista de Países para a base de dados */
        void loadCountries()
        {   
            /* Cria uma lista de tuplos com todos os países tal como a sua respetiva nacionalidade*/
            List<Tuple<String, String>> countries = LoadJson("C:\\Users\\Carlos Preto\\Desktop\\3ºAno MIEI\\2º Semestre\\LI4\\LightsOut\\Backend\\DataManager\\Countries.json")
                .Select(x => new Tuple<String, String>(x["en_short_name"], x["nationality"]))
                    .ToList();

            /*Conecta á base de dados*/
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                /*Adiciona cada país individualmente á base de dados TODO: Passar para um bulkinsert do dapper PLUS*/
                foreach (var country in countries)
                {
                    var sql = String.Format("If Not Exists(select * from [LightsOut].[dbo].Pais where nome=\'{0}\') begin insert into [LightsOut].[dbo].Pais values (\'{0}\',\'{1}\') end",
                        country.Item1.Replace("'", "´"), country.Item2);
                    connection.Query(sql);
                }
            }
        }

        public List<Dictionary<String,String>> LoadJson(String path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Dictionary<String,String>>>(json);
            }
        }

        JObject getJsonFromURL(String url)
        {
            using (var w = new WebClient())
            {
                try
                {
                    return (JObject) JsonConvert.DeserializeObject(w.DownloadString(url));
                }
                catch (Exception)
                {
                    Console.WriteLine("Error downloading info!");
                    return null;
                }
            }
        }

        
        static void Main(string[] args)
        {
            DataManager dm = new DataManager();
            
            dm.loadCountries();
            dm.loadEpocas(2018,2020);
            dm.loadCircuitos();
            dm.loadProvas();
            dm.loadPilotos();
            dm.loadEquipas();
            //dm.loadResults();
            dm.loadQualificacao();
            Prova p = new Prova();
            p.ppppp(2019, 7);
        }
    }
}
