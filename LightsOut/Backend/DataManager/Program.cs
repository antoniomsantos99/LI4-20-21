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
        }
    }
}
