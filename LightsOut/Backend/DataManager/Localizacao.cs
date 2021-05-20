using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace LightsOut.Data
{
    public class Localizacao
    {
        public string conString =
            "Data Source=(local);Initial Catalog=LightsOut;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public string id {get; set;}

        public string nome{ get; set; }

        public string nacionalidade{ get; set;}

        public float latitude{ get; set;}

        public float longitude{ get; set;} 

        public List<string> pilotos { get; set; }

        public Localizacao(string id, string nome, string nacionalidade, float latitude, float longitude){
            this.id = id;
            this.nome = nome;
            this.nacionalidade = nacionalidade;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        
        public Localizacao(){
            this.id = "";
            this.nome = "";
            this.nacionalidade = "";
            this.latitude = 0;
            this.longitude = 0;
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
    }

}