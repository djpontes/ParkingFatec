namespace ParkingFatec.Views
{
    partial class CadastroFuncionarioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionarioView));
            iconFundo = new PictureBox();
            iconOlho = new PictureBox();
            iconOlhoOff = new PictureBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnCadastrar = new Util.BtnRedondo();
            boxNivelAcesso = new Util.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconOlho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconOlhoOff).BeginInit();
            SuspendLayout();
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Cadastro_Funcionario1;
            iconFundo.Location = new Point(0, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(572, 600);
            iconFundo.TabIndex = 0;
            iconFundo.TabStop = false;
            // 
            // iconOlho
            // 
            iconOlho.BackColor = Color.FromArgb(247, 246, 246);
            iconOlho.Image = Properties.Resources.OlhoPerfil;
            iconOlho.Location = new Point(522, 317);
            iconOlho.Name = "iconOlho";
            iconOlho.Size = new Size(34, 34);
            iconOlho.TabIndex = 1;
            iconOlho.TabStop = false;
            iconOlho.MouseClick += iconOlho_MouseClick;
            // 
            // iconOlhoOff
            // 
            iconOlhoOff.BackColor = Color.FromArgb(247, 246, 246);
            iconOlhoOff.Image = Properties.Resources.OlhoOffPerfil;
            iconOlhoOff.Location = new Point(522, 317);
            iconOlhoOff.Name = "iconOlhoOff";
            iconOlhoOff.Size = new Size(34, 34);
            iconOlhoOff.TabIndex = 2;
            iconOlhoOff.TabStop = false;
            iconOlhoOff.MouseClick += iconOlhoOff_MouseClick;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(204, 203, 205);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 18F);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(61, 84);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(436, 32);
            txtNome.TabIndex = 3;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 203, 205);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 18F);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(61, 202);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(436, 32);
            txtEmail.TabIndex = 4;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(204, 203, 205);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 18F);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(61, 320);
            txtSenha.MaxLength = 16;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(436, 32);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(73, 92, 102);
            btnCadastrar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnCadastrar.BorderColor = Color.White;
            btnCadastrar.BorderRadius = 30;
            btnCadastrar.BorderSize = 3;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(208, 508);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 60);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // boxNivelAcesso
            // 
            boxNivelAcesso.BackColor = Color.FromArgb(204, 203, 205);
            boxNivelAcesso.BorderColor = Color.MediumSlateBlue;
            boxNivelAcesso.BorderSize = 0;
            boxNivelAcesso.DropDownStyle = ComboBoxStyle.DropDown;
            boxNivelAcesso.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxNivelAcesso.ForeColor = Color.FromArgb(64, 64, 64);
            boxNivelAcesso.IconColor = Color.FromArgb(105, 99, 99);
            boxNivelAcesso.ListBackColor = Color.FromArgb(204, 203, 205);
            boxNivelAcesso.ListTextColor = Color.FromArgb(64, 64, 64);
            boxNivelAcesso.Location = new Point(61, 438);
            boxNivelAcesso.MinimumSize = new Size(200, 30);
            boxNivelAcesso.Name = "boxNivelAcesso";
            boxNivelAcesso.Size = new Size(436, 30);
            boxNivelAcesso.TabIndex = 8;
            boxNivelAcesso.Texts = "Selecione...";
            // 
            // CadastroFuncionarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 600);
            Controls.Add(boxNivelAcesso);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(iconOlhoOff);
            Controls.Add(iconOlho);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroFuncionarioView";
            Text = "Cadastrar Funcionários";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconOlho).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconOlhoOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconFundo;
        private PictureBox iconOlho;
        private PictureBox iconOlhoOff;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox textBox4;
        private Util.BtnRedondo btnCadastrar;
        private Util.RJComboBox boxNivelAcesso;
    }
}