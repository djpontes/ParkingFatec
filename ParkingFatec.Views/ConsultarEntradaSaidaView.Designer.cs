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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEntradaSaidaView));
            pictureBox1 = new PictureBox();
            btnPesquisar = new Util.BtnRedondo();
            listView1 = new ListView();
            colunaID = new ColumnHeader();
            colunaDataEntrada = new ColumnHeader();
            colunaHoraEntrada = new ColumnHeader();
            colunaMotorista = new ColumnHeader();
            colunaPlaca = new ColumnHeader();
            colunaDataSaida = new ColumnHeader();
            colunaHoraSaida = new ColumnHeader();
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
            btnPesquisar.Cursor = Cursors.Hand;
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
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colunaID, colunaDataEntrada, colunaHoraEntrada, colunaMotorista, colunaPlaca, colunaDataSaida, colunaHoraSaida });
            listView1.Location = new Point(13, 96);
            listView1.Name = "listView1";
            listView1.Size = new Size(674, 410);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colunaID
            // 
            colunaID.Text = "ID";
            colunaID.Width = 30;
            // 
            // colunaDataEntrada
            // 
            colunaDataEntrada.Text = "Data de entrada";
            colunaDataEntrada.Width = 100;
            // 
            // colunaHoraEntrada
            // 
            colunaHoraEntrada.Text = "Hora da entrada";
            colunaHoraEntrada.Width = 100;
            // 
            // colunaMotorista
            // 
            colunaMotorista.Text = "Motorista";
            colunaMotorista.Width = 140;
            // 
            // colunaPlaca
            // 
            colunaPlaca.Text = "Placa";
            colunaPlaca.Width = 100;
            // 
            // colunaDataSaida
            // 
            colunaDataSaida.Text = "Data da saida";
            colunaDataSaida.Width = 100;
            // 
            // colunaHoraSaida
            // 
            colunaHoraSaida.Text = "Hora da saida";
            colunaHoraSaida.Width = 100;
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
            btnEditar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(487, 535);
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
            btnRelatorio.Cursor = Cursors.Hand;
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnRelatorio.ForeColor = Color.White;
            btnRelatorio.Location = new Point(271, 535);
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
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(56, 535);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(150, 55);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextColor = Color.White;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = Color.FromArgb(204, 203, 205);
            txtPesquisar.BorderStyle = BorderStyle.None;
            txtPesquisar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisar.ForeColor = Color.FromArgb(64, 64, 64);
            txtPesquisar.Location = new Point(66, 29);
            txtPesquisar.MaxLength = 50;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(387, 32);
            txtPesquisar.TabIndex = 6;
            txtPesquisar.KeyPress += txtPesquisar_KeyPress;
            // 
            // ConsultarEntradaSaidaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 620);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnRelatorio);
            Controls.Add(btnEditar);
            Controls.Add(listView1);
            Controls.Add(btnPesquisar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarEntradaSaidaView";
            Text = "ConsultarEntradaSaidaView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Util.BtnRedondo btnPesquisar;
        private ListView listView1;
        private ColumnHeader colunaID;
        private ColumnHeader colunaDataEntrada;
        private ColumnHeader colunaHoraEntrada;
        private ColumnHeader colunaMotorista;
        private ColumnHeader colunaPlaca;
        private ColumnHeader colunaDataSaida;
        private ColumnHeader colunaHoraSaida;
        private Util.BtnRedondo btnEditar;
        private Util.BtnRedondo btnRelatorio;
        private Util.BtnRedondo btnExcluir;
        private TextBox txtPesquisar;
    }
}