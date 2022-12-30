using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelECia.Dados.EfCore.Utilitarios
{
    public class ConnectionTest
    {
        public static void Test()
        {
            SqlConnection conn = new SqlConnection(ConnectionString.ConnStringServidor);

            try
            {
                conn.Open();
            }
            catch
            {
                throw new Exception($"Não foi possivel conectar no banco de dados.");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
