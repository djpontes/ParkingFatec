namespace ParkingFatec.Views
{
    partial class EstacionamentoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstacionamentoView));
            iconFundo = new PictureBox();
            txtMoto = new TextBox();
            txtCarro = new TextBox();
            btnRegistrar = new Util.BtnRedondo();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            SuspendLayout();
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Parking_Fatec;
            iconFundo.Location = new Point(0, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(573, 426);
            iconFundo.TabIndex = 0;
            iconFundo.TabStop = false;
            // 
            // txtMoto
            // 
            txtMoto.BackColor = Color.FromArgb(204, 203, 205);
            txtMoto.BorderStyle = BorderStyle.None;
            txtMoto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMoto.ForeColor = Color.FromArgb(64, 64, 64);
            txtMoto.Location = new Point(68, 89);
            txtMoto.Name = "txtMoto";
            txtMoto.PlaceholderText = "Quantidade...";
            txtMoto.Size = new Size(443, 32);
            txtMoto.TabIndex = 1;
            // 
            // txtCarro
            // 
            txtCarro.BackColor = Color.FromArgb(204, 203, 205);
            txtCarro.BorderStyle = BorderStyle.None;
            txtCarro.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarro.ForeColor = Color.FromArgb(64, 64, 64);
            txtCarro.Location = new Point(68, 216);
            txtCarro.Name = "txtCarro";
            txtCarro.PlaceholderText = "Quantidade...";
            txtCarro.Size = new Size(443, 32);
            txtCarro.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(73, 92, 102);
            btnRegistrar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnRegistrar.BorderColor = Color.White;
            btnRegistrar.BorderRadius = 30;
            btnRegistrar.BorderSize = 3;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(195, 310);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(176, 65);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextColor = Color.White;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // EstacionamentoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 246, 246);
            ClientSize = new Size(573, 426);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCarro);
            Controls.Add(txtMoto);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EstacionamentoView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Estacionamento";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconFundo;
        private TextBox txtMoto;
        private TextBox txtCarro;
        private Util.BtnRedondo btnRegistrar;
    }
}