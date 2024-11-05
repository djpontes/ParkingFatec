namespace ParkingFatec.Views
{
    partial class CadastroMotoristaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMotoristaView));
            iconFundo = new PictureBox();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtEmail = new TextBox();
            boxTipoMotorista = new Util.RJComboBox();
            txtCNH = new TextBox();
            btnCadastrar = new Util.BtnRedondo();
            txtCPF = new TextBox();
            txtTelefone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            SuspendLayout();
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Cadastro_Pessoa;
            iconFundo.Location = new Point(0, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(700, 590);
            iconFundo.TabIndex = 0;
            iconFundo.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(204, 203, 205);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 18F);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(73, 72);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome...";
            txtNome.Size = new Size(328, 32);
            txtNome.TabIndex = 1;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtIdade
            // 
            txtIdade.BackColor = Color.FromArgb(204, 203, 205);
            txtIdade.BorderStyle = BorderStyle.None;
            txtIdade.Font = new Font("Segoe UI", 18F);
            txtIdade.ForeColor = Color.FromArgb(64, 64, 64);
            txtIdade.Location = new Point(530, 69);
            txtIdade.MaxLength = 3;
            txtIdade.Name = "txtIdade";
            txtIdade.PlaceholderText = "Idade...";
            txtIdade.Size = new Size(100, 32);
            txtIdade.TabIndex = 2;
            txtIdade.KeyPress += txtIdade_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 203, 205);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 18F);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(72, 186);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail...";
            txtEmail.Size = new Size(328, 32);
            txtEmail.TabIndex = 3;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // boxTipoMotorista
            // 
            boxTipoMotorista.BackColor = Color.FromArgb(204, 203, 205);
            boxTipoMotorista.BorderColor = Color.FromArgb(204, 203, 205);
            boxTipoMotorista.BorderSize = 0;
            boxTipoMotorista.DropDownStyle = ComboBoxStyle.DropDown;
            boxTipoMotorista.Font = new Font("Segoe UI", 18F);
            boxTipoMotorista.ForeColor = Color.FromArgb(64, 64, 64);
            boxTipoMotorista.IconColor = Color.FromArgb(105, 99, 99);
            boxTipoMotorista.Items.AddRange(new object[] { "Professor", "Aluno", "Visitante" });
            boxTipoMotorista.ListBackColor = Color.FromArgb(204, 203, 205);
            boxTipoMotorista.ListTextColor = Color.FromArgb(64, 64, 64);
            boxTipoMotorista.Location = new Point(481, 188);
            boxTipoMotorista.MinimumSize = new Size(100, 30);
            boxTipoMotorista.Name = "boxTipoMotorista";
            boxTipoMotorista.Size = new Size(152, 30);
            boxTipoMotorista.TabIndex = 7;
            boxTipoMotorista.Texts = "Escolha...";
            // 
            // txtCNH
            // 
            txtCNH.BackColor = Color.FromArgb(204, 203, 205);
            txtCNH.BorderStyle = BorderStyle.None;
            txtCNH.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNH.ForeColor = Color.FromArgb(64, 64, 64);
            txtCNH.Location = new Point(73, 301);
            txtCNH.MaxLength = 11;
            txtCNH.Name = "txtCNH";
            txtCNH.PlaceholderText = "CNH...";
            txtCNH.Size = new Size(219, 32);
            txtCNH.TabIndex = 11;
            txtCNH.KeyPress += txtCNH_KeyPress;
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
            btnCadastrar.Location = new Point(285, 494);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 60);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txtCPF
            // 
            txtCPF.BackColor = Color.FromArgb(204, 203, 205);
            txtCPF.BorderStyle = BorderStyle.None;
            txtCPF.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCPF.Location = new Point(391, 302);
            txtCPF.MaxLength = 14;
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF...";
            txtCPF.Size = new Size(237, 32);
            txtCPF.TabIndex = 17;
            txtCPF.KeyPress += txtCPF_KeyPress;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.FromArgb(204, 203, 205);
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(78, 416);
            txtTelefone.MaxLength = 14;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone...";
            txtTelefone.Size = new Size(272, 32);
            txtTelefone.TabIndex = 18;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // CadastroMotoristaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 590);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCNH);
            Controls.Add(boxTipoMotorista);
            Controls.Add(txtEmail);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroMotoristaView";
            Text = "Cadastrar motoristas";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconFundo;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtEmail;
        private Util.RJComboBox boxTipoMotorista;
        private TextBox txtCNH;
        private Util.BtnRedondo btnCadastrar;
        private TextBox txtCPF;
        private TextBox txtTelefone;
    }
}