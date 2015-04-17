using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Model
{
    public class Conexao
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;

        protected void AbrirConexao()
        {
            con = new SqlConnection(Properties.Settings.Default.CS2);
            con.Open();
        }
        protected void FecharConexao()
        {
            con.Close();
        }
    }
}
