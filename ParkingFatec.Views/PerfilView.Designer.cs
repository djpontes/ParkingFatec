namespace ParkingFatec.Views
{
    partial class PerfilView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilView));
            iconFundo = new PictureBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnEditar = new Util.BtnRedondo();
            iconOlho = new PictureBox();
            iconOlhoOff = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconOlho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconOlhoOff).BeginInit();
            SuspendLayout();
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Perfil1;
            iconFundo.Location = new Point(1, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(600, 531);
            iconFundo.TabIndex = 1;
            iconFundo.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(204, 203, 205);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(60, 88);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite o seu nome...";
            txtNome.Size = new Size(440, 32);
            txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 203, 205);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(63, 205);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite o seu e-mail...";
            txtEmail.Size = new Size(440, 32);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(204, 203, 205);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(62, 323);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite a sua senha...";
            txtSenha.Size = new Size(440, 32);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(73, 92, 102);
            btnEditar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnEditar.BorderColor = Color.White;
            btnEditar.BorderRadius = 30;
            btnEditar.BorderSize = 3;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(209, 415);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(176, 65);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.TextColor = Color.White;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // iconOlho
            // 
            iconOlho.BackColor = Color.FromArgb(247, 246, 246);
            iconOlho.Image = Properties.Resources.OlhoPerfil;
            iconOlho.Location = new Point(529, 322);
            iconOlho.Name = "iconOlho";
            iconOlho.Size = new Size(34, 34);
            iconOlho.TabIndex = 6;
            iconOlho.TabStop = false;
            iconOlho.MouseClick += iconOlho_MouseClick;
            // 
            // iconOlhoOff
            // 
            iconOlhoOff.BackColor = Color.FromArgb(247, 246, 246);
            iconOlhoOff.Image = Properties.Resources.OlhoOffPerfil;
            iconOlhoOff.Location = new Point(529, 322);
            iconOlhoOff.Name = "iconOlhoOff";
            iconOlhoOff.Size = new Size(34, 34);
            iconOlhoOff.TabIndex = 7;
            iconOlhoOff.TabStop = false;
            iconOlhoOff.MouseClick += iconOlhoOff_MouseClick;
            // 
            // PerfilView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 531);
            Controls.Add(iconOlhoOff);
            Controls.Add(iconOlho);
            Controls.Add(btnEditar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PerfilView";
            Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconOlho).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconOlhoOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox iconFundo;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Util.BtnRedondo btnEditar;
        private PictureBox iconOlho;
        private PictureBox iconOlhoOff;
    }
}