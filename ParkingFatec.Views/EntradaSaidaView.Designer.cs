namespace ParkingFatec.Views
{
    partial class EntradaSaidaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaSaidaView));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnRegistrar = new Util.BtnRedondo();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(204, 203, 205);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(65, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(449, 32);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(204, 203, 205);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(68, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(449, 32);
            textBox2.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.FromArgb(204, 203, 205);
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Font = new Font("Segoe UI", 18F);
            maskedTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            maskedTextBox1.Location = new Point(65, 323);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(184, 32);
            maskedTextBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.FromArgb(204, 203, 205);
            maskedTextBox2.BorderStyle = BorderStyle.None;
            maskedTextBox2.Font = new Font("Segoe UI", 18F);
            maskedTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            maskedTextBox2.Location = new Point(340, 323);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(174, 32);
            maskedTextBox2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cadastro_EntradaSaida;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(573, 548);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(247, 246, 246);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(186, 371);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(64, 26);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(247, 246, 246);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(459, 371);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(56, 26);
            textBox4.TabIndex = 6;
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
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextColor = Color.White;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // EntradaSaidaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 548);
            Controls.Add(btnRegistrar);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EntradaSaidaView";
            Text = "Entrada ou Saida";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Util.BtnRedondo btnRegistrar;
    }
}