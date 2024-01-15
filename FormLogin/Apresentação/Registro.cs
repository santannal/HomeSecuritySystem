using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormLogin.Apresentação;
using FormLogin.Modelo;

namespace FormLogin.Apresentação
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Registro register = new Registro();
            register.Close();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Controle con = new Controle();
            string mensagem = con.cadastrar(txtBoxEmail.Text, txtBoxSenha.Text, txtBoxConfSenha.Text);
            if (con.tem)
            {
                MessageBox.Show("Cadastro feito com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxConfSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
