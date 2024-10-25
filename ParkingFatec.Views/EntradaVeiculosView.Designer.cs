namespace ParkingFatec.Views
{
    partial class EntradaVeiculosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaVeiculosView));
            btnRegistrar = new Util.BtnRedondo();
            txtVagasMoto = new TextBox();
            txtVagasCarro = new TextBox();
            txtHoraEntrada = new MaskedTextBox();
            txtDataEntrada = new MaskedTextBox();
            txtVeiculo = new TextBox();
            txtPlaca = new TextBox();
            iconFundo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(73, 92, 102);
            btnRegistrar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnRegistrar.BorderColor = Color.White;
            btnRegistrar.BorderRadius = 30;
            btnRegistrar.BorderSize = 3;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(208, 438);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 60);
            btnRegistrar.TabIndex = 23;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextColor = Color.White;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtVagasMoto
            // 
            txtVagasMoto.BackColor = Color.FromArgb(247, 246, 246);
            txtVagasMoto.BorderStyle = BorderStyle.None;
            txtVagasMoto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVagasMoto.Location = new Point(459, 371);
            txtVagasMoto.MaxLength = 3;
            txtVagasMoto.Name = "txtVagasMoto";
            txtVagasMoto.Size = new Size(56, 26);
            txtVagasMoto.TabIndex = 22;
            // 
            // txtVagasCarro
            // 
            txtVagasCarro.BackColor = Color.FromArgb(247, 246, 246);
            txtVagasCarro.BorderStyle = BorderStyle.None;
            txtVagasCarro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVagasCarro.Location = new Point(186, 371);
            txtVagasCarro.MaxLength = 3;
            txtVagasCarro.Name = "txtVagasCarro";
            txtVagasCarro.Size = new Size(64, 26);
            txtVagasCarro.TabIndex = 21;
            // 
            // txtHoraEntrada
            // 
            txtHoraEntrada.BackColor = Color.FromArgb(204, 203, 205);
            txtHoraEntrada.BorderStyle = BorderStyle.None;
            txtHoraEntrada.Font = new Font("Segoe UI", 18F);
            txtHoraEntrada.ForeColor = Color.FromArgb(64, 64, 64);
            txtHoraEntrada.Location = new Point(340, 323);
            txtHoraEntrada.Name = "txtHoraEntrada";
            txtHoraEntrada.Size = new Size(174, 32);
            txtHoraEntrada.TabIndex = 20;
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.BackColor = Color.FromArgb(204, 203, 205);
            txtDataEntrada.BorderStyle = BorderStyle.None;
            txtDataEntrada.Font = new Font("Segoe UI", 18F);
            txtDataEntrada.ForeColor = Color.FromArgb(64, 64, 64);
            txtDataEntrada.Location = new Point(65, 323);
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.Size = new Size(184, 32);
            txtDataEntrada.TabIndex = 19;
            // 
            // txtVeiculo
            // 
            txtVeiculo.BackColor = Color.FromArgb(204, 203, 205);
            txtVeiculo.BorderStyle = BorderStyle.None;
            txtVeiculo.Font = new Font("Segoe UI", 18F);
            txtVeiculo.ForeColor = Color.FromArgb(64, 64, 64);
            txtVeiculo.Location = new Point(68, 205);
            txtVeiculo.MaxLength = 30;
            txtVeiculo.Name = "txtVeiculo";
            txtVeiculo.Size = new Size(449, 32);
            txtVeiculo.TabIndex = 18;
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.FromArgb(204, 203, 205);
            txtPlaca.BorderStyle = BorderStyle.None;
            txtPlaca.Font = new Font("Segoe UI", 18F);
            txtPlaca.ForeColor = Color.FromArgb(64, 64, 64);
            txtPlaca.Location = new Point(65, 88);
            txtPlaca.MaxLength = 8;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(449, 32);
            txtPlaca.TabIndex = 17;
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Cadastro_EntradaSaida;
            iconFundo.Location = new Point(0, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(573, 548);
            iconFundo.TabIndex = 16;
            iconFundo.TabStop = false;
            // 
            // EntradaVeiculosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 548);
            Controls.Add(btnRegistrar);
            Controls.Add(txtVagasMoto);
            Controls.Add(txtVagasCarro);
            Controls.Add(txtHoraEntrada);
            Controls.Add(txtDataEntrada);
            Controls.Add(txtVeiculo);
            Controls.Add(txtPlaca);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EntradaVeiculosView";
            Text = "Entrada de veiculos";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Util.BtnRedondo btnRegistrar;
        private TextBox txtVagasMoto;
        private TextBox txtVagasCarro;
        private MaskedTextBox txtHoraEntrada;
        private MaskedTextBox txtDataEntrada;
        private TextBox txtVeiculo;
        private TextBox txtPlaca;
        private PictureBox iconFundo;
    }
}