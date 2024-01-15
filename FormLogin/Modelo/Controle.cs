using FormLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin.Modelo
{
    public class Controle 
    {

        public bool tem;
        public string mensagem = "";
        public bool acessar(string email, string senha)
        {
            LoginDalComandos ldc = new LoginDalComandos();
            tem = ldc.verificarLogin(email, senha);
            if (!ldc.mensagem.Equals(""))
            {
                this.mensagem = ldc.mensagem;
            }
            return tem;  
        }

        public string cadastrar(string email, string  senha, string confSenha)
        {
            LoginDalComandos ldc = new LoginDalComandos();
            ldc.cadastrar(email, senha, confSenha);
            if (ldc.tem == true) {

                this.tem = true;
            }

            return mensagem;
        }
    }
}
