namespace PastelECia.Dados.EfCore
{
    public class ConnectionString
    {
        public static readonly string ConnStringServidor = "Data Source=54.173.201.49;Initial Catalog=Pastel;User ID=sa;Password=Marco@007;Connect Timeout=4;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static readonly string ConnStringNotebook = "Data Source=DESKTOP-42OQODB\\MSSQLSERVER01;Initial Catalog=Pastel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static readonly string ConnStringPC = "Data Source=MARCOSERVIO\\SQLEXPRESS;Initial Catalog=Pastel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
