namespace FormLogin
{
    partial class formularioLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioLogin));
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.imgBoneco = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.cBoxLembrar = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoneco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.Location = new System.Drawing.Point(251, 156);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(304, 43);
            this.lblTituloLogin.TabIndex = 0;
            this.lblTituloLogin.Text = "SISTEMA DE LOGIN";
            // 
            // imgBoneco
            // 
            this.imgBoneco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgBoneco.Image = ((System.Drawing.Image)(resources.GetObject("imgBoneco.Image")));
            this.imgBoneco.Location = new System.Drawing.Point(73, 254);
            this.imgBoneco.Name = "imgBoneco";
            this.imgBoneco.Size = new System.Drawing.Size(215, 220);
            this.imgBoneco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoneco.TabIndex = 1;
            this.imgBoneco.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lblEmail.Location = new System.Drawing.Point(398, 269);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "USUÁRIO";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lblSenha.Location = new System.Drawing.Point(398, 338);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(62, 23);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "SENHA";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(402, 292);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(254, 26);
            this.txtBoxEmail.TabIndex = 4;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.txtBoxEmail_TextChanged);
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenha.Location = new System.Drawing.Point(402, 361);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(254, 26);
            this.txtBoxSenha.TabIndex = 5;
            this.txtBoxSenha.TextChanged += new System.EventHandler(this.txtBoxSenha_TextChanged);
            // 
            // cBoxLembrar
            // 
            this.cBoxLembrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxLembrar.AutoSize = true;
            this.cBoxLembrar.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.cBoxLembrar.Location = new System.Drawing.Point(475, 414);
            this.cBoxLembrar.Name = "cBoxLembrar";
            this.cBoxLembrar.Size = new System.Drawing.Size(109, 21);
            this.cBoxLembrar.TabIndex = 7;
            this.cBoxLembrar.Text = "Lembrar de mim";
            this.cBoxLembrar.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.BackColor = System.Drawing.Color.Lime;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.btnLogin.Location = new System.Drawing.Point(426, 441);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 33);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.button2.Location = new System.Drawing.Point(565, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "REGISTRO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkEsqueciSenha
            // 
            this.linkEsqueciSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkEsqueciSenha.AutoSize = true;
            this.linkEsqueciSenha.Location = new System.Drawing.Point(488, 476);
            this.linkEsqueciSenha.Name = "linkEsqueciSenha";
            this.linkEsqueciSenha.Size = new System.Drawing.Size(0, 13);
            this.linkEsqueciSenha.TabIndex = 11;
            // 
            // formularioLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.linkEsqueciSenha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cBoxLembrar);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.imgBoneco);
            this.Controls.Add(this.lblTituloLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formularioLogin";
            this.Text = "Login de usuário";
            this.Load += new System.EventHandler(this.formularioLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoneco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.PictureBox imgBoneco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.CheckBox cBoxLembrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkEsqueciSenha;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

