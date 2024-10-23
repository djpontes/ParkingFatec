namespace ParkingFatec.Views
{
    partial class CadastroVeiculoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVeiculoView));
            iconFundo = new PictureBox();
            txtPlaca = new TextBox();
            txtModelo = new TextBox();
            txtMotorista = new TextBox();
            txtCor = new TextBox();
            boxTipo = new Util.RJComboBox();
            btnCadastrar = new Util.BtnRedondo();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            SuspendLayout();
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Cadastro_Veiculo;
            iconFundo.Location = new Point(0, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(700, 484);
            iconFundo.TabIndex = 0;
            iconFundo.TabStop = false;
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.FromArgb(204, 203, 205);
            txtPlaca.BorderStyle = BorderStyle.None;
            txtPlaca.Font = new Font("Segoe UI", 18F);
            txtPlaca.ForeColor = Color.FromArgb(64, 64, 64);
            txtPlaca.Location = new Point(73, 75);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(220, 32);
            txtPlaca.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(204, 203, 205);
            txtModelo.BorderStyle = BorderStyle.None;
            txtModelo.Font = new Font("Segoe UI", 18F);
            txtModelo.ForeColor = Color.FromArgb(64, 64, 64);
            txtModelo.Location = new Point(74, 188);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(257, 32);
            txtModelo.TabIndex = 2;
            // 
            // txtMotorista
            // 
            txtMotorista.BackColor = Color.FromArgb(204, 203, 205);
            txtMotorista.BorderStyle = BorderStyle.None;
            txtMotorista.Font = new Font("Segoe UI", 18F);
            txtMotorista.ForeColor = Color.FromArgb(64, 64, 64);
            txtMotorista.Location = new Point(75, 303);
            txtMotorista.Name = "txtMotorista";
            txtMotorista.Size = new Size(275, 32);
            txtMotorista.TabIndex = 3;
            // 
            // txtCor
            // 
            txtCor.BackColor = Color.FromArgb(204, 203, 205);
            txtCor.BorderStyle = BorderStyle.None;
            txtCor.Font = new Font("Segoe UI", 18F);
            txtCor.ForeColor = Color.FromArgb(64, 64, 64);
            txtCor.Location = new Point(439, 187);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(187, 32);
            txtCor.TabIndex = 4;
            // 
            // boxTipo
            // 
            boxTipo.BackColor = Color.FromArgb(204, 203, 205);
            boxTipo.BorderColor = Color.MediumSlateBlue;
            boxTipo.BorderSize = 0;
            boxTipo.DropDownStyle = ComboBoxStyle.DropDown;
            boxTipo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxTipo.ForeColor = Color.FromArgb(64, 64, 64);
            boxTipo.IconColor = Color.FromArgb(105, 99, 99);
            boxTipo.ListBackColor = Color.FromArgb(230, 228, 245);
            boxTipo.ListTextColor = Color.FromArgb(64, 64, 64);
            boxTipo.Location = new Point(436, 70);
            boxTipo.MinimumSize = new Size(200, 30);
            boxTipo.Name = "boxTipo";
            boxTipo.Size = new Size(200, 30);
            boxTipo.TabIndex = 5;
            boxTipo.Texts = "Selecione...";
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
            btnCadastrar.Location = new Point(284, 382);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 60);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // CadastroVeiculoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 484);
            Controls.Add(btnCadastrar);
            Controls.Add(boxTipo);
            Controls.Add(txtCor);
            Controls.Add(txtMotorista);
            Controls.Add(txtModelo);
            Controls.Add(txtPlaca);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroVeiculoView";
            Text = "Cadastrar Veiculo";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconFundo;
        private TextBox txtPlaca;
        private TextBox txtModelo;
        private TextBox txtMotorista;
        private TextBox txtCor;
        private Util.RJComboBox boxTipo;
        private Util.BtnRedondo btnCadastrar;
    }
}