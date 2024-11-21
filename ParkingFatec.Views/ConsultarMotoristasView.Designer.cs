namespace ParkingFatec.Views
{
    partial class ConsultarMotoristasView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarMotoristasView));
            pictureBox1 = new PictureBox();
            btnPesquisar = new Util.BtnRedondo();
            btnEditar = new Util.BtnRedondo();
            btnExcluir = new Util.BtnRedondo();
            txtPesquisar = new TextBox();
            gridMotorista = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colCNH = new DataGridViewTextBoxColumn();
            colRa_rm = new DataGridViewTextBoxColumn();
            colTelefone = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridMotorista).BeginInit();
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
            btnPesquisar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
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
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(73, 92, 102);
            btnEditar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnEditar.BorderColor = Color.White;
            btnEditar.BorderRadius = 30;
            btnEditar.BorderSize = 3;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(416, 535);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 55);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.TextColor = Color.White;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.MouseClick += btnEditar_MouseClick;
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
            btnExcluir.Location = new Point(119, 535);
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
            txtPesquisar.Location = new Point(68, 30);
            txtPesquisar.MaxLength = 50;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(387, 32);
            txtPesquisar.TabIndex = 6;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            txtPesquisar.KeyPress += txtPesquisar_KeyPress;
            // 
            // gridMotorista
            // 
            gridMotorista.AllowUserToAddRows = false;
            gridMotorista.AllowUserToDeleteRows = false;
            gridMotorista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMotorista.BackgroundColor = SystemColors.ButtonHighlight;
            gridMotorista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMotorista.Columns.AddRange(new DataGridViewColumn[] { colID, colNome, colEmail, colCNH, colRa_rm, colTelefone });
            gridMotorista.Location = new Point(32, 103);
            gridMotorista.Name = "gridMotorista";
            gridMotorista.Size = new Size(634, 405);
            gridMotorista.TabIndex = 7;
            // 
            // colID
            // 
            colID.FillWeight = 50F;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.Visible = false;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "E-mail";
            colEmail.Name = "colEmail";
            // 
            // colCNH
            // 
            colCNH.HeaderText = "CNH";
            colCNH.Name = "colCNH";
            // 
            // colRa_rm
            // 
            colRa_rm.HeaderText = "RA/RM";
            colRa_rm.Name = "colRa_rm";
            // 
            // colTelefone
            // 
            colTelefone.HeaderText = "Telefone";
            colTelefone.Name = "colTelefone";
            // 
            // ConsultarMotoristasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 620);
            Controls.Add(gridMotorista);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnPesquisar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarMotoristasView";
            Text = "ConsultarMotoristas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridMotorista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Util.BtnRedondo btnPesquisar;
        private Util.BtnRedondo btnEditar;
        private Util.BtnRedondo btnExcluir;
        private TextBox txtPesquisar;
        private DataGridView gridMotorista;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colCNH;
        private DataGridViewTextBoxColumn colRa_rm;
        private DataGridViewTextBoxColumn colTelefone;
    }
}