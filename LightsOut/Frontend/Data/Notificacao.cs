using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LightsOut.Data{

    public class Notificacao
    {
        public string conString =
            "Data Source=(local);Initial Catalog=LightsOut;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int idUtilizador;

        public string idProva;


        public Notificacao()
        {
            this.idUtilizador = -1;
            this.idProva = "";
        }

        public Notificacao(int idUtilizador, string idProva)
        {
            this.idUtilizador = idUtilizador;
            this.idProva = idProva;
        }

        public Task<string> AddNotificacao(string nomeUtilizador, string idProva)
        {

            string res = "Notificacao Adicionada";

            using (var connection = new SqlConnection(conString))
            {
                connection.Open();

                string verificaUtilizador = String.Format(
                    "select id from [LightsOut].[dbo].Utilizador where nome = '{0}';", nomeUtilizador);

                var results = connection.Query(verificaUtilizador);

                if (results.Count() == 0) return Task.FromResult("Utilizador não Existe!");

                foreach (var result in results)
                {
                    //em princípio só tem um

                    string verificaNotificacao = String.Format(
                        "select idUtilizador, idProva from [LightsOut].[dbo].Notificacao where idUtilizador = {0} and idProva=\'{1}\';",
                        result.id, idProva);

                    var existeNotificacao = connection.Query(verificaNotificacao);

                    if (existeNotificacao.Count() != 0) return Task.FromResult("Notificação já Existe!");

                    int id = result.id;
                    connection.Query(String.Format("insert into [LightsOut].[dbo].Notificacao values ({0}, '{1}')", id,
                        idProva));
                }
            }

            return Task.FromResult(res);
        }

        public Task<string> sendNotification(string nomeUtilizador)
        {
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();

                string verificaUtilizador = String.Format(
                    "select id from [LightsOut].[dbo].Utilizador where nome = '{0}';", nomeUtilizador);

                var results = connection.Query(verificaUtilizador);
                
                if (results.Count() != 0)
                {
                    foreach (var result in results)
                    {
                        //em princípio só tem um
                        
                        string verificaNotificacao = String.Format(
                            "select idProva from [LightsOut].[dbo].Notificacao where idUtilizador = {0};",
                            result.id);

                        var existeNotificacao = connection.Query(verificaNotificacao);
                        
                        if (existeNotificacao.Count() != 0)
                        {
                            foreach (var noti in existeNotificacao)
                            {
                                string horaProva = String.Format(
                                    "select horaProva from [LightsOut].[dbo].Prova where id='{0}';", noti.idProva);

                                var hora = connection.Query(horaProva);

                                foreach (var h in hora)
                                {
                                    String teste = DateTime.Now.ToString("HH:mm");
                                    //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                                    
                                    string[] sp = Regex.Split(h.horaProva.ToString(),":");

                                    String hp = sp[0] + ":" + sp[1];
                                    
                                    Console.WriteLine(hp);
                                    Console.WriteLine(teste);
                                    
                                    if (teste == hp)
                                    {
                                        //Console.WriteLine(hp);
                                        
                                        string apagaNotificacao = String.Format(
                                        "DELETE from [LightsOut].[dbo].Notificacao where idUtilizador = {0} and idProva = '{1}';",
                                        result.id, noti.idProva);

                                        connection.Query(apagaNotificacao);//apagar notificacao da base de dados
                                        
                                        return Task.FromResult(noti.idProva);
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return Task.FromResult("nothing");
        }
    }
}