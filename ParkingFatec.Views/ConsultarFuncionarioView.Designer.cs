namespace ParkingFatec.Views
{
    partial class ConsultarFuncionarioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarFuncionarioView));
            pictureBox1 = new PictureBox();
            btnPesquisar = new Util.BtnRedondo();
            listFuncionario = new ListView();
            btnEditar = new Util.BtnRedondo();
            btnRelatorio = new Util.BtnRedondo();
            btnExcluir = new Util.BtnRedondo();
            txtPesquisar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Consultar;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 620);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(73, 92, 102);
            btnPesquisar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnPesquisar.BorderColor = Color.White;
            btnPesquisar.BorderRadius = 25;
            btnPesquisar.BorderSize = 3;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(493, 19);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(150, 50);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextColor = Color.White;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // listFuncionario
            // 
            listFuncionario.FullRowSelect = true;
            listFuncionario.Location = new Point(62, 107);
            listFuncionario.MultiSelect = false;
            listFuncionario.Name = "listFuncionario";
            listFuncionario.Size = new Size(563, 411);
            listFuncionario.TabIndex = 2;
            listFuncionario.UseCompatibleStateImageBehavior = false;
            listFuncionario.View = View.Details;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(73, 92, 102);
            btnEditar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnEditar.BorderColor = Color.White;
            btnEditar.BorderRadius = 30;
            btnEditar.BorderSize = 3;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(465, 542);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 55);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.TextColor = Color.White;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.FromArgb(73, 92, 102);
            btnRelatorio.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnRelatorio.BorderColor = Color.White;
            btnRelatorio.BorderRadius = 30;
            btnRelatorio.BorderSize = 3;
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorio.ForeColor = Color.White;
            btnRelatorio.Location = new Point(263, 542);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(150, 55);
            btnRelatorio.TabIndex = 4;
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.TextColor = Color.White;
            btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(165, 76, 76);
            btnExcluir.BackgroundColor = Color.FromArgb(165, 76, 76);
            btnExcluir.BorderColor = Color.White;
            btnExcluir.BorderRadius = 30;
            btnExcluir.BorderSize = 3;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(63, 542);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(150, 55);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextColor = Color.White;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = Color.FromArgb(204, 203, 205);
            txtPesquisar.BorderStyle = BorderStyle.None;
            txtPesquisar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisar.ForeColor = Color.FromArgb(64, 64, 64);
            txtPesquisar.Location = new Point(64, 29);
            txtPesquisar.MaxLength = 50;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(389, 32);
            txtPesquisar.TabIndex = 6;
            txtPesquisar.KeyPress += txtPesquisar_KeyPress;
            // 
            // ConsultarFuncionarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 620);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnRelatorio);
            Controls.Add(btnEditar);
            Controls.Add(listFuncionario);
            Controls.Add(btnPesquisar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarFuncionarioView";
            Text = "Consultar Funcionários";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Util.BtnRedondo btnPesquisar;
        private ListView listFuncionario;
        private Util.BtnRedondo btnEditar;
        private Util.BtnRedondo btnRelatorio;
        private Util.BtnRedondo btnExcluir;
        private TextBox txtPesquisar;
    }
}