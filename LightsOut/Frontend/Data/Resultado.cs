using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace LightsOut.Data
{
    public class Resultado
    {
        public string conString =
            "Data Source=(local);Initial Catalog=LightsOut;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public string id {get; set;}

        public Prova prova{ get; set; }

        public Piloto piloto{ get; set;}

        public int posicaoFinal{ get; set;}

        public int posicaoInicial{ get; set;}

        public string tempo{ get; set;} 

        public int pontos{ get; set;}

        public string estado{ get; set;}



        public Resultado(string id, Prova prova, Piloto piloto, int posicaoFinal, int posicaoInicial, string tempo, int pontos, string estado)
        {
            this.id = id;
            this.prova = prova;
            this.piloto = piloto;
            this.posicaoFinal = posicaoFinal;
            this.posicaoInicial = posicaoInicial;
            this.tempo = tempo;
            this.pontos = pontos;
            this.estado = estado;
        }

         public Resultado()
        {
            this.id = "";
            this.prova = null;
            this.piloto = null;
            this.posicaoFinal = 0;
            this.posicaoInicial = 0;
            this.tempo = "";
            this.pontos = 0;
            this.estado = "";
        }

        public List<Localizacao> GetLocalizacoes()
        {
            /*Conecta á base de dados*/
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                
                /*Vê as epocas presentes na base de dados*/
                return connection.Query<Localizacao>("select * from [LightsOut].[dbo].Localizacao").ToList();
            }
        }



        public Task<List<Tuple<string, int>>> ClassificacoesGeraisPiloto(int ano, int ronda){

            Dictionary<string, List<int>> somatorio = new Dictionary<string, List<int>>();

             using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                    
                
                string procuraResultados = String.Format(//lista com nome do piloto e pontos obtidos numa prova(várias provas)
                    "SELECT Piloto.nome, R.pontos from [LightsOut].[dbo].[Resultado] R JOIN Piloto Piloto On Piloto.id = R.idPiloto	JOIN Prova P On P.id = R.idProva where P.idEpoca = {0} and P.ronda <= {1} order by P.ronda;", ano, ronda);
                
                //Console.WriteLine(procuraResultados);
                var results = connection.Query(procuraResultados);
               

                foreach (var result in results)
                {
                    
                    if (somatorio.ContainsKey(result.nome)){//nome já existe

                        List<int> points = somatorio[result.nome];
                        points.Add(result.pontos);
                        somatorio[result.nome] = points;
            
                    }
                    else{//nome ainda não existe
                        List<int> points = new List<int>();
                        points.Add(result.pontos);
                        somatorio[result.nome] = points;
                    }
                }

                Dictionary<string, int> resultados = new Dictionary<string, int>();

                foreach(KeyValuePair<string, List<int>> entry in somatorio) 
                {
                    int totalPoints = entry.Value.Sum();
                    resultados[entry.Key] = totalPoints;
                }
                
                foreach(KeyValuePair<string, List<int>> entry in somatorio) 
                {
                    int totalPoints = entry.Value.Sum();
                    resultados[entry.Key] = totalPoints;
                }
                
                List<Tuple<string, int>> sortedDict = new List<Tuple<string, int>>();
                
                foreach (var item in resultados.OrderByDescending(key => key.Value))
                {
                    Tuple<string, int> elem = new Tuple<string, int>(item.Key, item.Value);
                    sortedDict.Add(elem);
                } 
                
                return Task.FromResult(sortedDict);
            }
        }




        public List<Prova> ppppp(int ano, int ronda)
        {

            List<Prova> result = new List<Prova>();
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();

                string procuraProvas = String.Format("SELECT * from [LightsOut].[dbo].[Prova] where idEpoca = {0} and ronda < {1};", ano, ronda);
                var resultProvas = connection.Query(procuraProvas);

                foreach (var prova in resultProvas)
                {
                    string procuraLocalizacao =
                        String.Format(
                            "SELECT * from [LightsOut].[dbo].Localizacao where id = \'{0}\';", prova.idLocalizacao);

                    var resultLocalizacoes = connection.Query<Localizacao>(procuraLocalizacao).First();

                    DateTime d = prova.data + prova.horaProva;
                    //Console.WriteLine(d);
                    Prova p = new Prova(prova.id, prova.idEpoca, prova.ronda, prova.nomeProva, d, resultLocalizacoes);
                    result.Add(p);
                }

                return result;
            }
        }


        public List<Localizacao> GetProvas(){

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                
                /*Vê as epocas presentes na base de dados*/
                return connection.Query<Localizacao>("SELECT L.* from [LightsOut].[dbo].[Prova] P JOIN Localizacao L on P.idLocalizacao = L.id where P.idEpoca = 2019;").ToList();
            }
        }

        public List<Localizacao> GetProvasIntervalo(int ano, int ronda){

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();

                string procura = String.Format("SELECT L.* from [LightsOut].[dbo].[Prova] P JOIN Localizacao L on P.idLocalizacao = L.id where P.idEpoca = {0} and P.ronda < {1};", ano, ronda);
                
                /*Vê as epocas presentes na base de dados*/
                return connection.Query<Localizacao>(procura).ToList();
            }
        }
    }

}