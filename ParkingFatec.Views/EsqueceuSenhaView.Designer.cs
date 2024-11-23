namespace ParkingFatec.Views
{
    partial class EsqueceuSenhaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueceuSenhaView));
            iconFundo = new PictureBox();
            btnRecuperarSenha = new Util.BtnRedondo();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            SuspendLayout();
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Recuperar_conta;
            iconFundo.Location = new Point(0, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(400, 300);
            iconFundo.TabIndex = 0;
            iconFundo.TabStop = false;
            // 
            // btnRecuperarSenha
            // 
            btnRecuperarSenha.BackColor = Color.FromArgb(73, 92, 102);
            btnRecuperarSenha.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnRecuperarSenha.BorderColor = Color.White;
            btnRecuperarSenha.BorderRadius = 20;
            btnRecuperarSenha.BorderSize = 3;
            btnRecuperarSenha.Cursor = Cursors.Hand;
            btnRecuperarSenha.FlatAppearance.BorderSize = 0;
            btnRecuperarSenha.FlatStyle = FlatStyle.Flat;
            btnRecuperarSenha.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecuperarSenha.ForeColor = Color.White;
            btnRecuperarSenha.Location = new Point(127, 187);
            btnRecuperarSenha.Name = "btnRecuperarSenha";
            btnRecuperarSenha.Size = new Size(140, 40);
            btnRecuperarSenha.TabIndex = 1;
            btnRecuperarSenha.Text = "Recuperar";
            btnRecuperarSenha.TextColor = Color.White;
            btnRecuperarSenha.UseVisualStyleBackColor = false;
            btnRecuperarSenha.MouseClick += btnRecuperarSenha_MouseClick;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 203, 205);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(46, 122);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(308, 28);
            txtEmail.TabIndex = 2;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // EsqueceuSenhaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(txtEmail);
            Controls.Add(btnRecuperarSenha);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EsqueceuSenhaView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Esqueceu Senha";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconFundo;
        private Util.BtnRedondo btnRecuperarSenha;
        private TextBox txtEmail;
    }
}