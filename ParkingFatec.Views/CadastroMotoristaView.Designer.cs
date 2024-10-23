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
            boxTipo = new Util.RJComboBox();
            txtCPF = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            txtCNH = new TextBox();
            btnCadastrar = new Util.BtnRedondo();
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
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome...";
            txtNome.Size = new Size(328, 32);
            txtNome.TabIndex = 1;
            // 
            // txtIdade
            // 
            txtIdade.BackColor = Color.FromArgb(204, 203, 205);
            txtIdade.BorderStyle = BorderStyle.None;
            txtIdade.Font = new Font("Segoe UI", 18F);
            txtIdade.ForeColor = Color.FromArgb(64, 64, 64);
            txtIdade.Location = new Point(530, 69);
            txtIdade.Name = "txtIdade";
            txtIdade.PlaceholderText = "Idade...";
            txtIdade.Size = new Size(100, 32);
            txtIdade.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 203, 205);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 18F);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(72, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "@fatec.sp.gov.br";
            txtEmail.Size = new Size(328, 32);
            txtEmail.TabIndex = 3;
            // 
            // boxTipo
            // 
            boxTipo.BackColor = Color.FromArgb(204, 203, 205);
            boxTipo.BorderColor = Color.FromArgb(204, 203, 205);
            boxTipo.BorderSize = 0;
            boxTipo.DropDownStyle = ComboBoxStyle.DropDown;
            boxTipo.Font = new Font("Segoe UI", 18F);
            boxTipo.ForeColor = Color.FromArgb(64, 64, 64);
            boxTipo.IconColor = Color.FromArgb(105, 99, 99);
            boxTipo.Items.AddRange(new object[] { "Professor", "Aluno", "Visitante" });
            boxTipo.ListBackColor = Color.FromArgb(204, 203, 205);
            boxTipo.ListTextColor = Color.FromArgb(64, 64, 64);
            boxTipo.Location = new Point(481, 188);
            boxTipo.MinimumSize = new Size(100, 30);
            boxTipo.Name = "boxTipo";
            boxTipo.Size = new Size(152, 30);
            boxTipo.TabIndex = 7;
            boxTipo.Texts = "Escolha...";
            // 
            // txtCPF
            // 
            txtCPF.BackColor = Color.FromArgb(204, 203, 205);
            txtCPF.BorderStyle = BorderStyle.None;
            txtCPF.Font = new Font("Segoe UI", 18F);
            txtCPF.ForeColor = Color.FromArgb(64, 64, 64);
            txtCPF.Location = new Point(396, 302);
            txtCPF.Mask = "000.000.999-99";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(161, 32);
            txtCPF.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.FromArgb(204, 203, 205);
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Font = new Font("Segoe UI", 18F);
            txtTelefone.ForeColor = Color.FromArgb(64, 64, 64);
            txtTelefone.Location = new Point(77, 416);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(270, 32);
            txtTelefone.TabIndex = 10;
            // 
            // txtCNH
            // 
            txtCNH.BackColor = Color.FromArgb(204, 203, 205);
            txtCNH.BorderStyle = BorderStyle.None;
            txtCNH.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNH.ForeColor = Color.FromArgb(64, 64, 64);
            txtCNH.Location = new Point(73, 301);
            txtCNH.Name = "txtCNH";
            txtCNH.PlaceholderText = "CNH...";
            txtCNH.Size = new Size(219, 32);
            txtCNH.TabIndex = 11;
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
            // CadastroPessoaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 590);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCNH);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(boxTipo);
            Controls.Add(txtEmail);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroPessoaView";
            Text = "Cadastrar Pessoas";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconFundo;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtEmail;
        private Util.RJComboBox boxTipo;
        private MaskedTextBox txtCPF;
        private MaskedTextBox txtTelefone;
        private TextBox txtCNH;
        private Util.BtnRedondo btnCadastrar;
    }
}