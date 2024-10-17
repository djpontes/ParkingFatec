namespace ParkingFatec.Views
{
    partial class InicioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioView));
            iconFundo = new PictureBox();
            btnFuncionario = new Button();
            btnCadastros = new Button();
            btnEntradas = new Button();
            btnSaidas = new Button();
            btnConsultar = new Button();
            btnSair = new Button();
            lblEstacionamento = new Label();
            lblPerfil = new Label();
            panelFuncionario = new TableLayoutPanel();
            lblMotorista = new Label();
            lblVeiculos = new Label();
            panelCadastrarAdmin = new TableLayoutPanel();
            lblFuncionario = new Label();
            panelConsultar = new TableLayoutPanel();
            lblMotoristaCon = new Label();
            lblVeiculosCon = new Label();
            lblEntraSai = new Label();
            panelCadastrarFuncio = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconFundo).BeginInit();
            panelFuncionario.SuspendLayout();
            panelCadastrarAdmin.SuspendLayout();
            panelConsultar.SuspendLayout();
            panelCadastrarFuncio.SuspendLayout();
            SuspendLayout();
            // 
            // iconFundo
            // 
            iconFundo.Image = Properties.Resources.Inicio;
            iconFundo.Location = new Point(0, 0);
            iconFundo.Name = "iconFundo";
            iconFundo.Size = new Size(1280, 720);
            iconFundo.TabIndex = 0;
            iconFundo.TabStop = false;
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = Color.White;
            btnFuncionario.Cursor = Cursors.Hand;
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatStyle = FlatStyle.Flat;
            btnFuncionario.Font = new Font("Segoe UI Variable Small Semibol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuncionario.ForeColor = Color.FromArgb(64, 64, 64);
            btnFuncionario.Image = Properties.Resources.iconAdmin;
            btnFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionario.Location = new Point(0, 212);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Padding = new Padding(20, 0, 80, 0);
            btnFuncionario.Size = new Size(391, 96);
            btnFuncionario.TabIndex = 1;
            btnFuncionario.Text = "Funcionário";
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.MouseClick += btnFuncionario_MouseClick;
            // 
            // btnCadastros
            // 
            btnCadastros.BackColor = Color.White;
            btnCadastros.Cursor = Cursors.Hand;
            btnCadastros.FlatAppearance.BorderSize = 0;
            btnCadastros.FlatStyle = FlatStyle.Flat;
            btnCadastros.Font = new Font("Segoe UI Variable Small Semibol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastros.ForeColor = Color.FromArgb(64, 64, 64);
            btnCadastros.Image = Properties.Resources.iconCadastrar;
            btnCadastros.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastros.Location = new Point(0, 311);
            btnCadastros.Name = "btnCadastros";
            btnCadastros.Padding = new Padding(25, 0, 100, 0);
            btnCadastros.Size = new Size(391, 97);
            btnCadastros.TabIndex = 2;
            btnCadastros.Text = "Cadastrar";
            btnCadastros.UseVisualStyleBackColor = false;
            btnCadastros.MouseClick += btnCadastros_MouseClick;
            // 
            // btnEntradas
            // 
            btnEntradas.BackColor = Color.White;
            btnEntradas.Cursor = Cursors.Hand;
            btnEntradas.FlatAppearance.BorderSize = 0;
            btnEntradas.FlatStyle = FlatStyle.Flat;
            btnEntradas.Font = new Font("Segoe UI Variable Small Semibol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntradas.ForeColor = Color.FromArgb(64, 64, 64);
            btnEntradas.Image = Properties.Resources.iconEntrada;
            btnEntradas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntradas.Location = new Point(0, 411);
            btnEntradas.Name = "btnEntradas";
            btnEntradas.Padding = new Padding(22, 0, 105, 0);
            btnEntradas.Size = new Size(391, 95);
            btnEntradas.TabIndex = 3;
            btnEntradas.Text = "Entradas";
            btnEntradas.UseVisualStyleBackColor = false;
            btnEntradas.MouseClick += btnEntradas_MouseClick;
            // 
            // btnSaidas
            // 
            btnSaidas.BackColor = Color.White;
            btnSaidas.Cursor = Cursors.Hand;
            btnSaidas.FlatAppearance.BorderSize = 0;
            btnSaidas.FlatStyle = FlatStyle.Flat;
            btnSaidas.Font = new Font("Segoe UI Variable Small Semibol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaidas.ForeColor = Color.FromArgb(64, 64, 64);
            btnSaidas.Image = Properties.Resources.iconSaida;
            btnSaidas.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaidas.Location = new Point(0, 509);
            btnSaidas.Name = "btnSaidas";
            btnSaidas.Padding = new Padding(24, 0, 130, 0);
            btnSaidas.Size = new Size(391, 99);
            btnSaidas.TabIndex = 4;
            btnSaidas.Text = "Saídas";
            btnSaidas.UseVisualStyleBackColor = false;
            btnSaidas.MouseClick += btnSaidas_MouseClick;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.White;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI Variable Small Semibol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.FromArgb(64, 64, 64);
            btnConsultar.Image = Properties.Resources.iconConsultar;
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(0, 612);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Padding = new Padding(24, 0, 100, 0);
            btnConsultar.Size = new Size(391, 108);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.MouseClick += btnConsultar_MouseClick;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.White;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.FromArgb(64, 64, 64);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(1115, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(96, 61);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.MouseClick += btnSair_MouseClick;
            // 
            // lblEstacionamento
            // 
            lblEstacionamento.Anchor = AnchorStyles.None;
            lblEstacionamento.AutoSize = true;
            lblEstacionamento.Cursor = Cursors.Hand;
            lblEstacionamento.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstacionamento.Location = new Point(24, 16);
            lblEstacionamento.Name = "lblEstacionamento";
            lblEstacionamento.Size = new Size(151, 27);
            lblEstacionamento.TabIndex = 0;
            lblEstacionamento.Text = "Estacionamento";
            // 
            // lblPerfil
            // 
            lblPerfil.Anchor = AnchorStyles.None;
            lblPerfil.AutoSize = true;
            lblPerfil.Cursor = Cursors.Hand;
            lblPerfil.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerfil.Location = new Point(72, 76);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(56, 27);
            lblPerfil.TabIndex = 1;
            lblPerfil.Text = "Perfil";
            // 
            // panelFuncionario
            // 
            panelFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelFuncionario.BackColor = Color.White;
            panelFuncionario.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panelFuncionario.ColumnCount = 1;
            panelFuncionario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelFuncionario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelFuncionario.Controls.Add(lblEstacionamento, 0, 0);
            panelFuncionario.Controls.Add(lblPerfil, 0, 1);
            panelFuncionario.Location = new Point(392, 198);
            panelFuncionario.Name = "panelFuncionario";
            panelFuncionario.RowCount = 2;
            panelFuncionario.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelFuncionario.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelFuncionario.Size = new Size(200, 120);
            panelFuncionario.TabIndex = 8;
            // 
            // lblMotorista
            // 
            lblMotorista.Anchor = AnchorStyles.None;
            lblMotorista.AutoSize = true;
            lblMotorista.Cursor = Cursors.Hand;
            lblMotorista.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMotorista.Location = new Point(51, 13);
            lblMotorista.Name = "lblMotorista";
            lblMotorista.Size = new Size(98, 27);
            lblMotorista.TabIndex = 0;
            lblMotorista.Text = "Motorista";
            // 
            // lblVeiculos
            // 
            lblVeiculos.Anchor = AnchorStyles.None;
            lblVeiculos.AutoSize = true;
            lblVeiculos.Cursor = Cursors.Hand;
            lblVeiculos.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVeiculos.Location = new Point(58, 66);
            lblVeiculos.Name = "lblVeiculos";
            lblVeiculos.Size = new Size(84, 27);
            lblVeiculos.TabIndex = 1;
            lblVeiculos.Text = "Veículos";
            lblVeiculos.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelCadastrarAdmin
            // 
            panelCadastrarAdmin.Anchor = AnchorStyles.None;
            panelCadastrarAdmin.BackColor = Color.White;
            panelCadastrarAdmin.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panelCadastrarAdmin.ColumnCount = 1;
            panelCadastrarAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelCadastrarAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelCadastrarAdmin.Controls.Add(lblFuncionario, 0, 2);
            panelCadastrarAdmin.Controls.Add(lblMotorista, 0, 0);
            panelCadastrarAdmin.Controls.Add(lblVeiculos, 0, 1);
            panelCadastrarAdmin.Location = new Point(392, 284);
            panelCadastrarAdmin.Name = "panelCadastrarAdmin";
            panelCadastrarAdmin.RowCount = 3;
            panelCadastrarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelCadastrarAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelCadastrarAdmin.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            panelCadastrarAdmin.Size = new Size(200, 155);
            panelCadastrarAdmin.TabIndex = 9;
            // 
            // lblFuncionario
            // 
            lblFuncionario.Anchor = AnchorStyles.None;
            lblFuncionario.AutoSize = true;
            lblFuncionario.Cursor = Cursors.Hand;
            lblFuncionario.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncionario.Location = new Point(42, 117);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(115, 27);
            lblFuncionario.TabIndex = 2;
            lblFuncionario.Text = "Funcionario";
            lblFuncionario.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelConsultar
            // 
            panelConsultar.Anchor = AnchorStyles.None;
            panelConsultar.BackColor = Color.White;
            panelConsultar.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panelConsultar.ColumnCount = 1;
            panelConsultar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelConsultar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelConsultar.Controls.Add(lblMotoristaCon, 0, 0);
            panelConsultar.Controls.Add(lblVeiculosCon, 0, 1);
            panelConsultar.Controls.Add(lblEntraSai, 0, 2);
            panelConsultar.Location = new Point(392, 578);
            panelConsultar.Name = "panelConsultar";
            panelConsultar.RowCount = 3;
            panelConsultar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelConsultar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelConsultar.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            panelConsultar.Size = new Size(200, 142);
            panelConsultar.TabIndex = 10;
            // 
            // lblMotoristaCon
            // 
            lblMotoristaCon.Anchor = AnchorStyles.None;
            lblMotoristaCon.AutoSize = true;
            lblMotoristaCon.Cursor = Cursors.Hand;
            lblMotoristaCon.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMotoristaCon.Location = new Point(51, 10);
            lblMotoristaCon.Name = "lblMotoristaCon";
            lblMotoristaCon.Size = new Size(98, 27);
            lblMotoristaCon.TabIndex = 0;
            lblMotoristaCon.Text = "Motorista";
            lblMotoristaCon.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblVeiculosCon
            // 
            lblVeiculosCon.Anchor = AnchorStyles.None;
            lblVeiculosCon.AutoSize = true;
            lblVeiculosCon.Cursor = Cursors.Hand;
            lblVeiculosCon.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVeiculosCon.Location = new Point(58, 55);
            lblVeiculosCon.Name = "lblVeiculosCon";
            lblVeiculosCon.Size = new Size(83, 28);
            lblVeiculosCon.TabIndex = 1;
            lblVeiculosCon.Text = "Veículos";
            lblVeiculosCon.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEntraSai
            // 
            lblEntraSai.Anchor = AnchorStyles.None;
            lblEntraSai.AutoSize = true;
            lblEntraSai.Cursor = Cursors.Hand;
            lblEntraSai.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEntraSai.Location = new Point(20, 103);
            lblEntraSai.Name = "lblEntraSai";
            lblEntraSai.Size = new Size(160, 27);
            lblEntraSai.TabIndex = 2;
            lblEntraSai.Text = "Entradas e saídas";
            lblEntraSai.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelCadastrarFuncio
            // 
            panelCadastrarFuncio.Anchor = AnchorStyles.None;
            panelCadastrarFuncio.BackColor = Color.White;
            panelCadastrarFuncio.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            panelCadastrarFuncio.ColumnCount = 1;
            panelCadastrarFuncio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelCadastrarFuncio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelCadastrarFuncio.Controls.Add(label1, 0, 0);
            panelCadastrarFuncio.Controls.Add(label2, 0, 1);
            panelCadastrarFuncio.Location = new Point(393, 303);
            panelCadastrarFuncio.Name = "panelCadastrarFuncio";
            panelCadastrarFuncio.RowCount = 2;
            panelCadastrarFuncio.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelCadastrarFuncio.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelCadastrarFuncio.Size = new Size(200, 120);
            panelCadastrarFuncio.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 16);
            label1.Name = "label1";
            label1.Size = new Size(98, 27);
            label1.TabIndex = 0;
            label1.Text = "Motorista";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 76);
            label2.Name = "label2";
            label2.Size = new Size(84, 27);
            label2.TabIndex = 1;
            label2.Text = "Veículos";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // InicioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelCadastrarFuncio);
            Controls.Add(panelConsultar);
            Controls.Add(panelCadastrarAdmin);
            Controls.Add(panelFuncionario);
            Controls.Add(btnSair);
            Controls.Add(btnConsultar);
            Controls.Add(btnSaidas);
            Controls.Add(btnEntradas);
            Controls.Add(btnCadastros);
            Controls.Add(btnFuncionario);
            Controls.Add(iconFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "InicioView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioView";
            ((System.ComponentModel.ISupportInitialize)iconFundo).EndInit();
            panelFuncionario.ResumeLayout(false);
            panelFuncionario.PerformLayout();
            panelCadastrarAdmin.ResumeLayout(false);
            panelCadastrarAdmin.PerformLayout();
            panelConsultar.ResumeLayout(false);
            panelConsultar.PerformLayout();
            panelCadastrarFuncio.ResumeLayout(false);
            panelCadastrarFuncio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconFundo;
        private Button btnFuncionario;
        private Button btnCadastros;
        private Button btnEntradas;
        private Button btnSaidas;
        private Button btnConsultar;
        private Button btnSair;
        private Label lblEstacionamento;
        private Label lblPerfil;
        private TableLayoutPanel panelFuncionario;
        private Label lblMotorista;
        private Label lblVeiculos;
        private TableLayoutPanel panelCadastrarAdmin;
        private Label lblFuncionario;
        private TableLayoutPanel panelConsultar;
        private Label lblMotoristaCon;
        private Label lblVeiculosCon;
        private Label lblEntraSai;
        private TableLayoutPanel panelCadastrarFuncio;
        private Label label1;
        private Label label2;
    }
}