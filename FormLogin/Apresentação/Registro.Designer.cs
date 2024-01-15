namespace FormLogin.Apresentação
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtBoxConfSenha = new System.Windows.Forms.TextBox();
            this.imgSecurity = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecurity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRegistro.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(268, 151);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(251, 40);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "REGISTRE-SE";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(414, 234);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 22);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "USUÁRIO";
            this.lblEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(417, 297);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 22);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "SENHA";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "CONFIRMAR SENHA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxEmail.Location = new System.Drawing.Point(418, 259);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(245, 20);
            this.txtBoxEmail.TabIndex = 6;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.txtBoxEmail_TextChanged);
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxSenha.Location = new System.Drawing.Point(421, 322);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(242, 20);
            this.txtBoxSenha.TabIndex = 7;
            this.txtBoxSenha.TextChanged += new System.EventHandler(this.txtBoxSenha_TextChanged);
            // 
            // txtBoxConfSenha
            // 
            this.txtBoxConfSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxConfSenha.Location = new System.Drawing.Point(421, 389);
            this.txtBoxConfSenha.Name = "txtBoxConfSenha";
            this.txtBoxConfSenha.PasswordChar = '*';
            this.txtBoxConfSenha.Size = new System.Drawing.Size(242, 20);
            this.txtBoxConfSenha.TabIndex = 8;
            this.txtBoxConfSenha.TextChanged += new System.EventHandler(this.txtBoxConfSenha_TextChanged);
            // 
            // imgSecurity
            // 
            this.imgSecurity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgSecurity.Image = ((System.Drawing.Image)(resources.GetObject("imgSecurity.Image")));
            this.imgSecurity.Location = new System.Drawing.Point(79, 236);
            this.imgSecurity.Name = "imgSecurity";
            this.imgSecurity.Size = new System.Drawing.Size(230, 229);
            this.imgSecurity.TabIndex = 9;
            this.imgSecurity.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrar.Location = new System.Drawing.Point(421, 442);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(104, 31);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVoltar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnVoltar.Location = new System.Drawing.Point(559, 442);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 31);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.imgSecurity);
            this.Controls.Add(this.txtBoxConfSenha);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSecurity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.TextBox txtBoxConfSenha;
        private System.Windows.Forms.PictureBox imgSecurity;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVoltar;
    }
}