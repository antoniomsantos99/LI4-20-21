namespace DataAccessLibrary.Models
{
    public class NotificacaoModel
    {
        public string conString =
            "Data Source=(local);Initial Catalog=LightsOut;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int idUtilizador;

        public string idProva;


        public NotificacaoModel()
        {
            this.idUtilizador = -1;
            this.idProva = "";
        }
    }
}