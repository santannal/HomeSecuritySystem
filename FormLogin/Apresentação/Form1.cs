using aplicativoSecurity;
using FormLogin.Apresentação;
using FormLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class formularioLogin : Form
    {
        public formularioLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Trabalha com a classe controle
            Controle controle = new Controle();

            //Utiliza o método acessar de controle
            controle.acessar(txtBoxEmail.Text, txtBoxSenha.Text);

            //Verifica se senha e email são compatíveis
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    DialogResult result = MessageBox.Show("Deseja continuar para a página?", "Confirmação",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        Formulario formulario = new Formulario();
                        formulario.Show();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Operação cancelada.");
                    }
                }
                else
                {
                    MessageBox.Show("Login não encontrado", "Ops...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (cBoxLembrar.Checked == true)
            {
                Properties.Settings.Default.email = txtBoxEmail.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void formularioLogin_Load(object sender, EventArgs e)
        {
            txtBoxEmail.Text = Properties.Settings.Default.email;
            txtBoxSenha.Text = Properties.Settings.Default.senha;

            if (txtBoxEmail.Text != "" && txtBoxSenha.Text != "")
            {
                cBoxLembrar.Checked = true;
            }
            else
            {
                cBoxLembrar.Checked = false;
            }
        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {
            if (cBoxLembrar.Checked == true)
            {
                Properties.Settings.Default.senha = txtBoxSenha.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}