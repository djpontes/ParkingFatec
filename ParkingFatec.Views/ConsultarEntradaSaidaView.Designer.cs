namespace ParkingFatec.Views
{
    partial class ConsultarEntradaSaidaView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEntradaSaidaView));
            pictureBox1 = new PictureBox();
            btnPesquisar = new Util.BtnRedondo();
            btnExcluir = new Util.BtnRedondo();
            txtPesquisar = new TextBox();
            gridEntradaSaida = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colPlaca = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colMotorista = new DataGridViewTextBoxColumn();
            colDentrada = new DataGridViewTextBoxColumn();
            colHentrada = new DataGridViewTextBoxColumn();
            colDsaida = new DataGridViewTextBoxColumn();
            colHsaida = new DataGridViewTextBoxColumn();
            btnRelatorio = new Util.BtnRedondo();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridEntradaSaida).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FundoConsEntradaSaida;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(824, 620);
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
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(624, 28);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(150, 50);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextColor = Color.White;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(165, 76, 76);
            btnExcluir.BackgroundColor = Color.FromArgb(165, 76, 76);
            btnExcluir.BorderColor = Color.White;
            btnExcluir.BorderRadius = 30;
            btnExcluir.BorderSize = 3;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(193, 533);
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
            txtPesquisar.Location = new Point(32, 40);
            txtPesquisar.MaxLength = 50;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(512, 32);
            txtPesquisar.TabIndex = 6;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            txtPesquisar.KeyPress += txtPesquisar_KeyPress;
            // 
            // gridEntradaSaida
            // 
            gridEntradaSaida.AllowUserToAddRows = false;
            gridEntradaSaida.AllowUserToDeleteRows = false;
            gridEntradaSaida.BackgroundColor = SystemColors.ButtonHighlight;
            gridEntradaSaida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEntradaSaida.Columns.AddRange(new DataGridViewColumn[] { colID, colPlaca, colTipo, colModelo, colMotorista, colDentrada, colHentrada, colDsaida, colHsaida });
            gridEntradaSaida.Location = new Point(7, 95);
            gridEntradaSaida.Name = "gridEntradaSaida";
            gridEntradaSaida.Size = new Size(804, 411);
            gridEntradaSaida.TabIndex = 8;
            // 
            // colID
            // 
            colID.FillWeight = 50F;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.Visible = false;
            colID.Width = 50;
            // 
            // colPlaca
            // 
            colPlaca.FillWeight = 60F;
            colPlaca.HeaderText = "Placa";
            colPlaca.Name = "colPlaca";
            colPlaca.Width = 96;
            // 
            // colTipo
            // 
            colTipo.FillWeight = 50F;
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            colTipo.Width = 80;
            // 
            // colModelo
            // 
            colModelo.FillWeight = 80F;
            colModelo.HeaderText = "Modelo";
            colModelo.Name = "colModelo";
            colModelo.Width = 127;
            // 
            // colMotorista
            // 
            colMotorista.FillWeight = 80F;
            colMotorista.HeaderText = "Motorista";
            colMotorista.Name = "colMotorista";
            colMotorista.ReadOnly = true;
            colMotorista.Width = 128;
            // 
            // colDentrada
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            colDentrada.DefaultCellStyle = dataGridViewCellStyle1;
            colDentrada.FillWeight = 50F;
            colDentrada.HeaderText = "D. Entrada";
            colDentrada.Name = "colDentrada";
            colDentrada.Width = 90;
            // 
            // colHentrada
            // 
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            colHentrada.DefaultCellStyle = dataGridViewCellStyle2;
            colHentrada.FillWeight = 50F;
            colHentrada.HeaderText = "H. Entrada";
            colHentrada.Name = "colHentrada";
            colHentrada.Width = 90;
            // 
            // colDsaida
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            colDsaida.DefaultCellStyle = dataGridViewCellStyle3;
            colDsaida.FillWeight = 50F;
            colDsaida.HeaderText = "D. Saída";
            colDsaida.Name = "colDsaida";
            colDsaida.Width = 75;
            // 
            // colHsaida
            // 
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            colHsaida.DefaultCellStyle = dataGridViewCellStyle4;
            colHsaida.FillWeight = 50F;
            colHsaida.HeaderText = "H. Saída";
            colHsaida.Name = "colHsaida";
            colHsaida.Width = 75;
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
            btnRelatorio.Location = new Point(462, 530);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(150, 60);
            btnRelatorio.TabIndex = 9;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.TextColor = Color.White;
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // ConsultarEntradaSaidaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 620);
            Controls.Add(btnRelatorio);
            Controls.Add(gridEntradaSaida);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarEntradaSaidaView";
            Text = "Consultar Entrada e Saída de Veículos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridEntradaSaida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Util.BtnRedondo btnPesquisar;
        private Util.BtnRedondo btnExcluir;
        private TextBox txtPesquisar;
        private DataGridView gridEntradaSaida;
        private Util.BtnRedondo btnRelatorio;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colPlaca;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colMotorista;
        private DataGridViewTextBoxColumn colDentrada;
        private DataGridViewTextBoxColumn colHentrada;
        private DataGridViewTextBoxColumn colDsaida;
        private DataGridViewTextBoxColumn colHsaida;
    }
}