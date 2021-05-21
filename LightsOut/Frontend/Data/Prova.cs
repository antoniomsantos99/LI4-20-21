using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.JSInterop;

namespace LightsOut.Data
{
    public class Prova
    {
        public string conString =
            "Data Source=(local);Initial Catalog=LightsOut;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public string id {get; set;}

        public int idEpoca{ get; set; }

        public int ronda{ get; set;}

        public string nomeProva{ get; set;}

        public DateTime data{ get; set;} 

        //public string horaProva { get; set; }

        public Localizacao localizacao {get; set; }

        public Prova(string id, int idEpoca, int ronda, string nomeProva, DateTime data, Localizacao localizacao)
        {
            this.id = id;
            this.idEpoca = idEpoca;
            this.ronda = ronda;
            this.nomeProva = nomeProva;
            this.data = data;
            //this.horaProva = horaProva;
            this.localizacao = localizacao;
        }

        public Prova(){
            this.id = "";
            this.idEpoca = 0;
            this.ronda = 0;
            this.nomeProva = "";
            this.data = DateTime.Now;
            //this.horaProva = "";
            this.localizacao = null;
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