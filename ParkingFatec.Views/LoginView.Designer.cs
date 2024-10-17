namespace ParkingFatec.Views
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            iconFundo = new PictureBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            linkEsqueceuSenha = new LinkLabel();
            btnEntrar = new Util.BtnRedondo();
            btnCadastrarAdmin = new Util.BtnRedondo();
            iconOlho = new PictureBox();
            iconOlhoOff = new PictureBox();
            lblPrimeiroAcesso = new Label();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconOlho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconOlhoOff).BeginInit();
            SuspendLayout();
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Login2;
            iconFundo.Location = new Point(0, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(1280, 720);
            iconFundo.TabIndex = 0;
            iconFundo.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 203, 205);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(671, 219);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite o seu e-mail...";
            txtEmail.Size = new Size(448, 32);
            txtEmail.TabIndex = 1;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(204, 203, 205);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(671, 346);
            txtSenha.MaxLength = 16;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite a sua senha...";
            txtSenha.Size = new Size(448, 32);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // linkEsqueceuSenha
            // 
            linkEsqueceuSenha.ActiveLinkColor = Color.Black;
            linkEsqueceuSenha.AutoSize = true;
            linkEsqueceuSenha.BackColor = Color.FromArgb(73, 92, 102);
            linkEsqueceuSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkEsqueceuSenha.LinkColor = Color.FromArgb(145, 149, 152);
            linkEsqueceuSenha.Location = new Point(836, 407);
            linkEsqueceuSenha.Name = "linkEsqueceuSenha";
            linkEsqueceuSenha.Size = new Size(141, 21);
            linkEsqueceuSenha.TabIndex = 3;
            linkEsqueceuSenha.TabStop = true;
            linkEsqueceuSenha.Text = "Esqueceu a senha?";
            linkEsqueceuSenha.LinkClicked += linkEsqueceuSenha_LinkClicked;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(73, 92, 102);
            btnEntrar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnEntrar.BorderColor = Color.White;
            btnEntrar.BorderRadius = 30;
            btnEntrar.BorderSize = 3;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(819, 452);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(176, 55);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextColor = Color.White;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.MouseClick += btnEntrar_MouseClick;
            // 
            // btnCadastrarAdmin
            // 
            btnCadastrarAdmin.BackColor = Color.FromArgb(73, 92, 102);
            btnCadastrarAdmin.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnCadastrarAdmin.BorderColor = Color.White;
            btnCadastrarAdmin.BorderRadius = 30;
            btnCadastrarAdmin.BorderSize = 3;
            btnCadastrarAdmin.Cursor = Cursors.Hand;
            btnCadastrarAdmin.FlatAppearance.BorderSize = 0;
            btnCadastrarAdmin.FlatStyle = FlatStyle.Flat;
            btnCadastrarAdmin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnCadastrarAdmin.ForeColor = Color.White;
            btnCadastrarAdmin.Location = new Point(836, 583);
            btnCadastrarAdmin.Name = "btnCadastrarAdmin";
            btnCadastrarAdmin.Size = new Size(280, 63);
            btnCadastrarAdmin.TabIndex = 5;
            btnCadastrarAdmin.Text = "Cadastrar administrador";
            btnCadastrarAdmin.TextColor = Color.White;
            btnCadastrarAdmin.UseVisualStyleBackColor = false;
            btnCadastrarAdmin.MouseClick += btnCadastrarAdmin_MouseClick;
            // 
            // iconOlho
            // 
            iconOlho.BackColor = Color.FromArgb(73, 92, 102);
            iconOlho.Cursor = Cursors.Hand;
            iconOlho.Image = Properties.Resources.Olho;
            iconOlho.Location = new Point(1146, 345);
            iconOlho.Name = "iconOlho";
            iconOlho.Size = new Size(34, 34);
            iconOlho.TabIndex = 6;
            iconOlho.TabStop = false;
            iconOlho.MouseClick += iconOlho_MouseClick;
            // 
            // iconOlhoOff
            // 
            iconOlhoOff.BackColor = Color.FromArgb(73, 92, 102);
            iconOlhoOff.Cursor = Cursors.Hand;
            iconOlhoOff.Image = Properties.Resources.OlhoOff;
            iconOlhoOff.Location = new Point(1146, 346);
            iconOlhoOff.Name = "iconOlhoOff";
            iconOlhoOff.Size = new Size(34, 34);
            iconOlhoOff.TabIndex = 7;
            iconOlhoOff.TabStop = false;
            iconOlhoOff.MouseClick += iconOlhoOff_MouseClick;
            // 
            // lblPrimeiroAcesso
            // 
            lblPrimeiroAcesso.AutoSize = true;
            lblPrimeiroAcesso.BackColor = Color.FromArgb(73, 92, 102);
            lblPrimeiroAcesso.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrimeiroAcesso.ForeColor = Color.White;
            lblPrimeiroAcesso.Location = new Point(615, 599);
            lblPrimeiroAcesso.Name = "lblPrimeiroAcesso";
            lblPrimeiroAcesso.Size = new Size(206, 32);
            lblPrimeiroAcesso.TabIndex = 8;
            lblPrimeiroAcesso.Text = "Primeiro acesso?";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(lblPrimeiroAcesso);
            Controls.Add(iconOlhoOff);
            Controls.Add(iconOlho);
            Controls.Add(btnCadastrarAdmin);
            Controls.Add(btnEntrar);
            Controls.Add(linkEsqueceuSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking Fatec";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconOlho).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconOlhoOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconFundo;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private LinkLabel linkEsqueceuSenha;
        private Util.BtnRedondo btnEntrar;
        private Util.BtnRedondo btnCadastrarAdmin;
        private PictureBox iconOlho;
        private PictureBox iconOlhoOff;
        private Label lblPrimeiroAcesso;
    }
}
