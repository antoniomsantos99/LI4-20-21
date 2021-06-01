using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace LightsOut.Data
{
    public class Utilizador
    {
        public string conString =
            "Data Source=(local);Initial Catalog=LightsOut;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private string username;

        private string password;
        
        //adicionar lista notificações

        public Utilizador()
        {
            this.username = "";
            this.password = "";
        }

        public Utilizador(string utilizador, string password)
        {
            this.username = utilizador;
            this.password = password;
        }

        public bool addUserBaseDados(string utilizador, string password)
        {
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                
                /*Vê as epocas presentes na base de dados*/
                if (connection.Query<Utilizador>(String.Format("select * from [LightsOut].[dbo].Utilizador where nome = '{0}'", utilizador)).ToList().Count == 1) return false;
                else
                {
                    Utilizador u = new Utilizador(utilizador, password);
                    connection.Query(String.Format("insert into [LightsOut].[dbo].Utilizador values ('{0}', '{1}')",
                        utilizador, password));
                }
            }

            return true;
        }
    }
}