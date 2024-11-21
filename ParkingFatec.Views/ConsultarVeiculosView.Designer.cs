namespace ParkingFatec.Views
{
    partial class ConsultarVeiculosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVeiculosView));
            pictureBox1 = new PictureBox();
            btnPesquisar = new Util.BtnRedondo();
            btnEditar = new Util.BtnRedondo();
            btnExcluir = new Util.BtnRedondo();
            txtPesquisar = new TextBox();
            gridVeiculos = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colPlaca = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colCor = new DataGridViewTextBoxColumn();
            colMotorista = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridVeiculos).BeginInit();
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
            btnEditar.Location = new Point(431, 529);
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
            btnExcluir.Location = new Point(106, 530);
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
            txtPesquisar.Location = new Point(69, 30);
            txtPesquisar.MaxLength = 50;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(386, 32);
            txtPesquisar.TabIndex = 6;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            txtPesquisar.KeyPress += txtPesquisar_KeyPress;
            // 
            // gridVeiculos
            // 
            gridVeiculos.AllowUserToAddRows = false;
            gridVeiculos.AllowUserToDeleteRows = false;
            gridVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridVeiculos.BackgroundColor = SystemColors.ButtonHighlight;
            gridVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVeiculos.Columns.AddRange(new DataGridViewColumn[] { colID, colPlaca, colTipo, colModelo, colCor, colMotorista });
            gridVeiculos.Location = new Point(53, 106);
            gridVeiculos.Name = "gridVeiculos";
            gridVeiculos.Size = new Size(595, 394);
            gridVeiculos.TabIndex = 7;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.Visible = false;
            // 
            // colPlaca
            // 
            colPlaca.HeaderText = "Placa";
            colPlaca.Name = "colPlaca";
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colModelo
            // 
            colModelo.HeaderText = "Modelo";
            colModelo.Name = "colModelo";
            // 
            // colCor
            // 
            colCor.HeaderText = "Cor";
            colCor.Name = "colCor";
            // 
            // colMotorista
            // 
            colMotorista.HeaderText = "Motorista";
            colMotorista.Name = "colMotorista";
            colMotorista.ReadOnly = true;
            // 
            // ConsultarVeiculosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 620);
            Controls.Add(gridVeiculos);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnPesquisar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarVeiculosView";
            Text = "Consultar Veiculos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridVeiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Util.BtnRedondo btnPesquisar;
        private Util.BtnRedondo btnEditar;
        private Util.BtnRedondo btnExcluir;
        private TextBox txtPesquisar;
        private DataGridView gridVeiculos;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colPlaca;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colCor;
        private DataGridViewTextBoxColumn colMotorista;
    }
}