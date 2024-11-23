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
            txtRa_rm = new TextBox();
            txtEmail = new TextBox();
            boxTipoMotorista = new Util.RJComboBox();
            txtCNH = new TextBox();
            btnCadastrar = new Util.BtnRedondo();
            txtTelefone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            SuspendLayout();
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Cadastro_Motorista;
            iconFundo.Location = new Point(-1, -2);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(722, 496);
            iconFundo.TabIndex = 0;
            iconFundo.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(204, 203, 205);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 18F);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(72, 178);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome...";
            txtNome.Size = new Size(300, 32);
            txtNome.TabIndex = 3;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtRa_rm
            // 
            txtRa_rm.BackColor = Color.FromArgb(204, 203, 205);
            txtRa_rm.BorderStyle = BorderStyle.None;
            txtRa_rm.Font = new Font("Segoe UI", 18F);
            txtRa_rm.ForeColor = Color.FromArgb(64, 64, 64);
            txtRa_rm.Location = new Point(74, 67);
            txtRa_rm.MaxLength = 13;
            txtRa_rm.Name = "txtRa_rm";
            txtRa_rm.PlaceholderText = "RA/RM...";
            txtRa_rm.Size = new Size(290, 32);
            txtRa_rm.TabIndex = 2;
            txtRa_rm.KeyPress += txtRa_rm_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 203, 205);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 18F);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(72, 288);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail...";
            txtEmail.Size = new Size(300, 32);
            txtEmail.TabIndex = 5;
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
            boxTipoMotorista.Location = new Point(447, 70);
            boxTipoMotorista.MinimumSize = new Size(100, 30);
            boxTipoMotorista.Name = "boxTipoMotorista";
            boxTipoMotorista.Size = new Size(152, 30);
            boxTipoMotorista.TabIndex = 1;
            boxTipoMotorista.Texts = "Escolha...";
            boxTipoMotorista.OnSelectedIndexChanged += boxTipoMotorista_OnSelectedIndexChanged;
            // 
            // txtCNH
            // 
            txtCNH.BackColor = Color.FromArgb(204, 203, 205);
            txtCNH.BorderStyle = BorderStyle.None;
            txtCNH.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNH.ForeColor = Color.FromArgb(64, 64, 64);
            txtCNH.Location = new Point(456, 178);
            txtCNH.MaxLength = 11;
            txtCNH.Name = "txtCNH";
            txtCNH.PlaceholderText = "CNH...";
            txtCNH.Size = new Size(200, 32);
            txtCNH.TabIndex = 4;
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
            btnCadastrar.Location = new Point(280, 387);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 60);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.MouseClick += btnCadastrar_MouseClick;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.FromArgb(204, 203, 205);
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.ForeColor = Color.FromArgb(64, 64, 64);
            txtTelefone.Location = new Point(458, 285);
            txtTelefone.MaxLength = 14;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone...";
            txtTelefone.Size = new Size(198, 32);
            txtTelefone.TabIndex = 6;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // CadastroMotoristaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 496);
            Controls.Add(txtTelefone);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCNH);
            Controls.Add(boxTipoMotorista);
            Controls.Add(txtEmail);
            Controls.Add(txtRa_rm);
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
        private TextBox txtRa_rm;
        private TextBox txtEmail;
        private Util.RJComboBox boxTipoMotorista;
        private TextBox txtCNH;
        private Util.BtnRedondo btnCadastrar;
        private TextBox txtTelefone;
    }
}