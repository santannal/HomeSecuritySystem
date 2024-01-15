using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicativoSecurity
{
    public partial class Formulario : Form
    {
        Timer timer = new Timer();
        public Formulario()
        {
            InitializeComponent();
            //Configurando entrada serial do computador
            serialPort1.PortName = "COM7";
            serialPort1.BaudRate = 9600;
            timer.Interval = 10000; // 10 segundos
            timer.Tick += new EventHandler(temporizador);
            serialPort1.DataReceived += SerialPort_DataReceived;
            //abrindo porta serial
        }
        private void Formulario_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 ms = 1 segundo
            timer.Tick += AtualizarHora;
            timer.Start();
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a porta serial: " + ex.Message);
            }
        }
        private void AtualizarHora(object sender, EventArgs e)
        {
            // Atualizar o texto do Label com a hora atual
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort1.ReadLine();
                string[] values = data.Split(','); // Suponha que os dados sejam separados por vírgula

                if (values.Length >= 2)
                {
                    // Verifique se há pelo menos 2 valores
                    string info1 = values[0];
                    string info2 = values[1];
                    string info3 = values[2];

                    // Atualize as labels na thread da interface do usuário
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblInfoIncendio.Text = "Sensor de gás: " + info1;
                        lblInfoPorta.Text = "Temperatura: " + info2 + "°C";
                        lblUmidade.Text = "Umidade: " + info3 + "g/m³";
                    });
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lamento, a leitura serial não está mais disponível! ");
            }
        }

            private void lblLedQuartoA_Click(object sender, EventArgs e)
        {

        }

        private void btnLigaLedQuartoA_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("5");
                imgLedQuartoA.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-652202.jpg?w=2000";
            }
            btnLigaLedQuartoA.BackColor = Color.Green;
            btnDeslLedA.BackColor = Color.White;
        }

        private void btnDeslLedA_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("4");
                imgLedQuartoA.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-372205.jpg";
            }
            btnLigaLedQuartoA.BackColor = Color.White;
            btnDeslLedA.BackColor = Color.Red;
        }

        private void btnLigaLed1Sala_Click(object sender, EventArgs e)
        {
            //Verifica se a porta está aberta
            if (serialPort1.IsOpen)
            {
                //envia valor à serial
                serialPort1.WriteLine("1");
                imgLed1Sala.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-652202.jpg?w=2000";
            }
            btnLigaLed1Sala.BackColor = Color.Green;
            btnDesligaLed1Sala.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("0");
                imgLed1Sala.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-372205.jpg";
            }
            btnLigaLed1Sala.BackColor = Color.White;
            btnDesligaLed1Sala.BackColor = Color.Red;
        }

        private void btnLigaLed2Sala_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("3");
                imgLed2Sala.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-652202.jpg?w=2000";
            }
            btnLigaLed2Sala.BackColor = Color.Green;
            btnDeslLed2Sala.BackColor = Color.White;
        }

        private void btnDeslLed2Sala_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("2");
                imgLed2Sala.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-372205.jpg";
            }
            btnLigaLed2Sala.BackColor = Color.White;
            btnDeslLed2Sala.BackColor = Color.Red;
        }

        private void btnLigaLed1QB_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("7");
                imgLed1QuartoB.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-652202.jpg?w=2000";
            }
            btnLigaLed1QB.BackColor = Color.Green;
            btnDesligaLed1QB.BackColor = Color.White;
        }

        private void btnDesligaLed1QB_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("6");
                imgLed1QuartoB.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-372205.jpg";
            }
            btnLigaLed1QB.BackColor = Color.White;
            btnDesligaLed1QB.BackColor = Color.Red;
        }

        private void btnLigaLed2QB_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("9");
                imgLed2QuartoB.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-652202.jpg?w=2000";
            }
            btnLigaLed2QB.BackColor = Color.Green;
            btnDesligaLed2QB.BackColor = Color.White;
        }

        private void btnDesligaLed2QB_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("8");
                imgLed2QuartoB.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-372205.jpg";
            }
            btnLigaLed2QB.BackColor = Color.White;
            btnDesligaLed2QB.BackColor = Color.Red;
        }

        private void btnLigaLed3QB_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("b");
                imgLed3QuartoB.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-652202.jpg?w=2000";
            }
            btnLigaLed3QB.BackColor = Color.Green;
            btnDesligaLed3QB.BackColor = Color.White;
        }

        private void btnDesligaLed3QB_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("a");
                imgLed3QuartoB.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-372205.jpg";
            }
            btnLigaLed3QB.BackColor = Color.White;
            btnDesligaLed3QB.BackColor = Color.Red;
        }

        private void btnLigaLedCozinha_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("d");
                imgLedCozinha.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-652202.jpg?w=2000";
            }
            btnLigaLedCozinha.BackColor = Color.Green;
            btnDesligaLedCozinha.BackColor = Color.White;
        }

        private void btnDesligaLedCozinha_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("c");
                imgLedCozinha.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-372205.jpg";
            }

            btnLigaLedCozinha.BackColor = Color.White;
            btnDesligaLedCozinha.BackColor = Color.Red;
        }

        private void btnLigaLedCorredor_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("f");
                imgLedCorredor.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-652202.jpg?w=2000";
            }

            btnLigaLedCorredor.BackColor = Color.Green;
            btnDesligaLedCorredor.BackColor = Color.White;
        }

        private void btnDesligaLedCorredor_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("e");
                imgLedCorredor.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-372205.jpg";
            }
            btnLigaLedCorredor.BackColor = Color.White;
            btnDesligaLedCorredor.BackColor = Color.Red;
        }

        private void btnLigaLed1Banheiro_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("h");
                imgLed1Banheiro.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-652202.jpg?w=2000";
            }

            btnLigaLed1Banheiro.BackColor = Color.Green;
            btnLDesligaLed1Banheiro.BackColor = Color.White;
        }

        private void btnLDesligaLed1Banheiro_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("g");
                imgLed1Banheiro.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-372205.jpg";
            }

            btnLigaLed1Banheiro.BackColor = Color.White;
            btnLDesligaLed1Banheiro.BackColor = Color.Red;
        }

        private void btnLigaLed2Banheiro_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("i");
                imgLed2Banheiro.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-652202.jpg?w=2000";
            }

            btnLigaLed2Banheiro.BackColor = Color.Green;
            btnDesligaLed2Banheiro.BackColor = Color.White;
        }

        private void btnDesligaLed2Banheiro_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("j");
                imgLed2Banheiro.ImageLocation = "https://img.freepik.com/icones-gratis/lampada_318-372205.jpg";
            }

            btnLigaLed2Banheiro.BackColor = Color.White;
            btnDesligaLed2Banheiro.BackColor = Color.Red;
        }
        private void Formulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Feche a porta serial aqui
            serialPort1.Close();
        }

        private void btnLigarTodosOsLeds_Click(object sender, EventArgs e)
        {
            /*
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("clarao");
            }

            btnLigarTodosOsLeds.BackColor = Color.Green;
            btnApagao.BackColor = Color.White;
            btnLigaLedQuartoA.BackColor = Color.Green;
            btnDeslLedA.BackColor = Color.White;
            btnLigaLed1Sala.BackColor = Color.Green;
            btnDesligaLed1Sala.BackColor = Color.White;
            btnLigaLed2Sala.BackColor = Color.Green;
            btnDeslLed2Sala.BackColor = Color.White;
            btnLigaLed1QB.BackColor = Color.Green;
            btnDesligaLed1QB.BackColor = Color.White;
            btnLigaLed2QB.BackColor = Color.Green;
            btnDesligaLed2QB.BackColor = Color.White;
            btnLigaLed3QB.BackColor = Color.Green;
            btnDesligaLed3QB.BackColor = Color.White;
            btnLigaLedCozinha.BackColor = Color.Green;
            btnDesligaLedCozinha.BackColor = Color.White;
            btnLigaLedCorredor.BackColor = Color.Green;
            btnDesligaLedCorredor.BackColor = Color.White;
            btnLigaLed1Banheiro.BackColor = Color.Green;
            btnLDesligaLed1Banheiro.BackColor = Color.White;
            btnLigaLed2Banheiro.BackColor = Color.Green;
            btnDesligaLed2Banheiro.BackColor = Color.White;*/
        }

        private void btnApagao_Click(object sender, EventArgs e)
        {
            /*
            DialogResult result = MessageBox.Show("Deseja continuar?", "Confirmação",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine("apagao");
                    
                    btnLigarTodosOsLeds.BackColor = Color.White;
                    btnApagao.BackColor = Color.Red;
                    btnLigaLedQuartoA.BackColor = Color.White;
                    btnDeslLedA.BackColor = Color.Red;
                    btnLigaLed1Sala.BackColor = Color.White;
                    btnDesligaLed1Sala.BackColor = Color.Red;
                    btnLigaLed2Sala.BackColor = Color.White;
                    btnDeslLed2Sala.BackColor = Color.Red;
                    btnLigaLed1QB.BackColor = Color.White;
                    btnDesligaLed1QB.BackColor = Color.Red;
                    btnLigaLed2QB.BackColor = Color.White;
                    btnDesligaLed2QB.BackColor = Color.Red;
                    btnLigaLed3QB.BackColor = Color.White;
                    btnDesligaLed3QB.BackColor = Color.Red;
                    btnLigaLedCozinha.BackColor = Color.White;
                    btnDesligaLedCozinha.BackColor = Color.Red;
                    btnLigaLedCorredor.BackColor = Color.White;
                    btnDesligaLedCorredor.BackColor = Color.Red;
                    btnLigaLed1Banheiro.BackColor = Color.White;
                    btnLDesligaLed1Banheiro.BackColor = Color.Red;
                    btnLigaLed2Banheiro.BackColor = Color.White;
                    btnDesligaLed2Banheiro.BackColor = Color.Red; 
                } 
            }
            else if (result == DialogResult.Cancel)
            {
                // O botão "Cancelar" foi clicado
                MessageBox.Show("Operação cancelada.");
            }
            */
        }
        private void navegacao_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void btnSituacaoPorta_Click(object sender, EventArgs e)
        {
     
        }

        private void lblInfoIncendio_Click(object sender, EventArgs e)
        {

        }

        private void lblInfoPorta_Click(object sender, EventArgs e)
        {

        }

        private void btnLigarSeguranca_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("ligarSeguranca");
            }
            btnLigarSeguranca.BackColor = Color.Green;
            btnDeslSeguranca.BackColor = Color.White;
        }
        private void btnDeslSeguranca_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("desligarSeguranca");
            }
            btnLigarSeguranca.BackColor = Color.White;
            btnDeslSeguranca.BackColor = Color.Red;
        }

        private void btnLigarAlarme_Click(object sender, EventArgs e)
        {
            btnLigarAlarme.Text = "DESLIGADO";
            btnLigarAlarme.BackColor = Color.Red;
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("ligarAlarme");
                btnLigarAlarme.Text = "LIGADO";
                btnLigarAlarme.BackColor = Color.Green;
                lblSituacaoAlarme.Text = "ALARME ACIONADO POR 10 SEGUNDOS";
            }
            //Inicia o temporizador
            timer.Interval = 10000; // 10 segundos
            timer.Start();
        }

        private void temporizador(object sender, EventArgs e)
        {
            // Quando o temporizador atinge 10 segundos
            // Reverte o botão para o estado "Desligado"
            btnLigarAlarme.Text = "DESLIGADO";
            btnLigarAlarme.BackColor = Color.Red;
            lblSituacaoAlarme.Text = "";

            // Para o temporizador
            timer.Stop();
        }
          
        private void btnDesligarAlarme_Click(object sender, EventArgs e)
        {
  
        }

        private void lblSituacaoAlarme_Click(object sender, EventArgs e)
        {

        }

        private void lblUmidade_Click(object sender, EventArgs e)
        {

        }

        private void pageRal_Click(object sender, EventArgs e)
        {

        }

        private void lblSitSeguranca_Click(object sender, EventArgs e)
        {
            
        }

        private void imgLed1QuartoB_Click(object sender, EventArgs e)
        {

        }

        private void pageQuartoB_Click(object sender, EventArgs e)
        {

        }
    }
}
