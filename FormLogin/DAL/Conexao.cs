using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao() {          
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=parteLogin;Integrated Security=True";           
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }
            return con;
        }
        
        public SqlConnection desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}
