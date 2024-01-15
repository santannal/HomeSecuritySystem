using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin.DAL
{
    internal class LoginDalComandos
    {
        public bool tem = false; 
        public string mensagem = "";
        public SqlCommand cmd = new SqlCommand();
        public Conexao con = new Conexao();
        public SqlDataReader dr;
        public bool verificarLogin(string email, string senha)
        {
            //comandos sql para verificar se a informação existe no bd
            cmd.CommandText = "SELECT * FROM entrar WHERE email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("@email", email); //a informação de @email para o parâmetro email
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
            }
            catch(SqlException)
            {
                this.mensagem = "Erro de bd.";
            }
            return tem;
        }

        public string cadastrar( string email, string senha, string confSenha)
        {
            tem = false;
            //Verifica se senha e confirma senha são iguais 
            if (senha.Equals(confSenha)) {
                //envia comando ao sql
                cmd.CommandText = "insert into entrar values (@e, @s);";

                //Passa os parametros com valor
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);
                try
                {
                    //cadastra no sql
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();            
                    con.desconectar();
                    mensagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch(SqlException)
                {
                    //caso não se conecte ao sql
                    mensagem = "Erro de bd";
                }
            }
            //caso as senhas n sejam iguais
            else
            {
                mensagem = "Senhas não correspondem";
            }
            return mensagem;
        }
    }
}
