namespace ParkingFatec.Views
{
    partial class SaidaVeiculoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaidaVeiculoView));
            txtVagasMoto = new TextBox();
            txtVagasCarro = new TextBox();
            txtVeiculo = new TextBox();
            txtPlaca = new TextBox();
            iconFundo = new PictureBox();
            txtData = new TextBox();
            txtHora = new TextBox();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            SuspendLayout();
            // 
            // txtVagasMoto
            // 
            txtVagasMoto.BackColor = Color.FromArgb(247, 246, 246);
            txtVagasMoto.BorderStyle = BorderStyle.None;
            txtVagasMoto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVagasMoto.Location = new Point(459, 371);
            txtVagasMoto.Name = "txtVagasMoto";
            txtVagasMoto.Size = new Size(56, 26);
            txtVagasMoto.TabIndex = 14;
            // 
            // txtVagasCarro
            // 
            txtVagasCarro.BackColor = Color.FromArgb(247, 246, 246);
            txtVagasCarro.BorderStyle = BorderStyle.None;
            txtVagasCarro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVagasCarro.Location = new Point(186, 371);
            txtVagasCarro.Name = "txtVagasCarro";
            txtVagasCarro.Size = new Size(64, 26);
            txtVagasCarro.TabIndex = 13;
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
            txtVeiculo.TabIndex = 10;
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
            txtPlaca.TabIndex = 9;
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Cadastro_EntradaSaida2;
            iconFundo.Location = new Point(0, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(573, 548);
            iconFundo.TabIndex = 8;
            iconFundo.TabStop = false;
            // 
            // txtData
            // 
            txtData.BackColor = Color.FromArgb(204, 203, 205);
            txtData.BorderStyle = BorderStyle.None;
            txtData.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtData.Location = new Point(78, 323);
            txtData.MaxLength = 10;
            txtData.Name = "txtData";
            txtData.Size = new Size(161, 32);
            txtData.TabIndex = 16;
            txtData.KeyPress += txtData_KeyPress;
            // 
            // txtHora
            // 
            txtHora.BackColor = Color.FromArgb(204, 203, 205);
            txtHora.BorderStyle = BorderStyle.None;
            txtHora.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHora.Location = new Point(347, 322);
            txtHora.MaxLength = 5;
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(161, 32);
            txtHora.TabIndex = 17;
            txtHora.KeyPress += txtHora_KeyPress;
            // 
            // SaidaVeiculoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 548);
            Controls.Add(txtHora);
            Controls.Add(txtData);
            Controls.Add(txtVagasMoto);
            Controls.Add(txtVagasCarro);
            Controls.Add(txtVeiculo);
            Controls.Add(txtPlaca);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SaidaVeiculoView";
            Text = "Saida de veiculos";
            Load += SaidaVeiculoView_Load;
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Util.BtnRedondo btnRegistrar;
        private TextBox txtVagasMoto;
        private TextBox txtVagasCarro;
        private TextBox txtVeiculo;
        private TextBox txtPlaca;
        private PictureBox iconFundo;
        private TextBox txtData;
        private TextBox txtHora;
    }
}