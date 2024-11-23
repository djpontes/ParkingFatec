namespace ParkingFatec.Views
{
    partial class PrimeiroAcessoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimeiroAcessoView));
            iconFundo = new PictureBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            boxNivelAcesso = new Util.RJComboBox();
            btnCadastrar = new Util.BtnRedondo();
            btnVoltar = new Util.BtnRedondo();
            iconOlho = new PictureBox();
            iconOlhoOff = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconOlho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconOlhoOff).BeginInit();
            SuspendLayout();
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Primeiro_Acesso3;
            iconFundo.Location = new Point(0, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(1280, 720);
            iconFundo.TabIndex = 0;
            iconFundo.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(204, 203, 205);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(690, 166);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite o seu nome...";
            txtNome.Size = new Size(428, 32);
            txtNome.TabIndex = 1;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 203, 205);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(690, 293);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite o seu e-mail...";
            txtEmail.Size = new Size(428, 32);
            txtEmail.TabIndex = 2;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(204, 203, 205);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(690, 420);
            txtSenha.MaxLength = 16;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite a sua senha...";
            txtSenha.Size = new Size(428, 32);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // boxNivelAcesso
            // 
            boxNivelAcesso.BackColor = Color.FromArgb(204, 203, 205);
            boxNivelAcesso.BorderColor = Color.MediumSlateBlue;
            boxNivelAcesso.BorderSize = 0;
            boxNivelAcesso.Cursor = Cursors.Hand;
            boxNivelAcesso.DisplayMember = "1";
            boxNivelAcesso.DropDownStyle = ComboBoxStyle.DropDown;
            boxNivelAcesso.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxNivelAcesso.ForeColor = Color.FromArgb(64, 64, 64);
            boxNivelAcesso.IconColor = Color.FromArgb(105, 99, 99);
            boxNivelAcesso.Items.AddRange(new object[] { "Administrador" });
            boxNivelAcesso.ListBackColor = Color.FromArgb(204, 203, 205);
            boxNivelAcesso.ListTextColor = Color.FromArgb(64, 64, 64);
            boxNivelAcesso.Location = new Point(690, 543);
            boxNivelAcesso.MinimumSize = new Size(200, 30);
            boxNivelAcesso.Name = "boxNivelAcesso";
            boxNivelAcesso.Size = new Size(428, 37);
            boxNivelAcesso.TabIndex = 4;
            boxNivelAcesso.Texts = "Selecione...";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(73, 92, 102);
            btnCadastrar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnCadastrar.BorderColor = Color.White;
            btnCadastrar.BorderRadius = 30;
            btnCadastrar.BorderSize = 3;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(944, 627);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 55);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.MouseClick += btnCadastrar_MouseClick;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(73, 92, 102);
            btnVoltar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnVoltar.BorderColor = Color.White;
            btnVoltar.BorderRadius = 30;
            btnVoltar.BorderSize = 3;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(699, 627);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(150, 55);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.White;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.MouseClick += btnVoltar_MouseClick;
            // 
            // iconOlho
            // 
            iconOlho.BackColor = Color.FromArgb(73, 92, 102);
            iconOlho.Cursor = Cursors.Hand;
            iconOlho.Image = Properties.Resources.Olho;
            iconOlho.Location = new Point(1145, 418);
            iconOlho.Name = "iconOlho";
            iconOlho.Size = new Size(34, 34);
            iconOlho.TabIndex = 7;
            iconOlho.TabStop = false;
            iconOlho.MouseClick += iconOlho_MouseClick;
            // 
            // iconOlhoOff
            // 
            iconOlhoOff.BackColor = Color.FromArgb(73, 92, 102);
            iconOlhoOff.Cursor = Cursors.Hand;
            iconOlhoOff.Image = Properties.Resources.OlhoOff;
            iconOlhoOff.Location = new Point(1145, 418);
            iconOlhoOff.Name = "iconOlhoOff";
            iconOlhoOff.Size = new Size(34, 34);
            iconOlhoOff.TabIndex = 8;
            iconOlhoOff.TabStop = false;
            iconOlhoOff.MouseClick += iconOlhoOff_MouseClick;
            // 
            // PrimeiroAcessoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(iconOlhoOff);
            Controls.Add(iconOlho);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrar);
            Controls.Add(boxNivelAcesso);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PrimeiroAcessoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconOlho).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconOlhoOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconFundo;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Util.RJComboBox boxNivelAcesso;
        private Util.BtnRedondo btnCadastrar;
        private Util.BtnRedondo btnVoltar;
        private PictureBox iconOlho;
        private PictureBox iconOlhoOff;
    }
}