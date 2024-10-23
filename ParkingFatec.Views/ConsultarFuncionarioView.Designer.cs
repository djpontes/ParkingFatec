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
            btnRedondo1 = new Util.BtnRedondo();
            listView1 = new ListView();
            colunaID = new ColumnHeader();
            colunaNome = new ColumnHeader();
            colunaEmail = new ColumnHeader();
            btnRedondo2 = new Util.BtnRedondo();
            btnRedondo3 = new Util.BtnRedondo();
            btnRedondo4 = new Util.BtnRedondo();
            textBox1 = new TextBox();
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
            // btnRedondo1
            // 
            btnRedondo1.BackColor = Color.FromArgb(73, 92, 102);
            btnRedondo1.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnRedondo1.BorderColor = Color.White;
            btnRedondo1.BorderRadius = 25;
            btnRedondo1.BorderSize = 3;
            btnRedondo1.FlatAppearance.BorderSize = 0;
            btnRedondo1.FlatStyle = FlatStyle.Flat;
            btnRedondo1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRedondo1.ForeColor = Color.White;
            btnRedondo1.Location = new Point(493, 19);
            btnRedondo1.Name = "btnRedondo1";
            btnRedondo1.Size = new Size(150, 50);
            btnRedondo1.TabIndex = 1;
            btnRedondo1.Text = "Pesquisar";
            btnRedondo1.TextColor = Color.White;
            btnRedondo1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colunaID, colunaNome, colunaEmail });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(62, 107);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(563, 411);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colunaID
            // 
            colunaID.Text = "ID";
            // 
            // colunaNome
            // 
            colunaNome.Text = "Nome";
            colunaNome.Width = 250;
            // 
            // colunaEmail
            // 
            colunaEmail.Text = "E-mail";
            colunaEmail.Width = 250;
            // 
            // btnRedondo2
            // 
            btnRedondo2.BackColor = Color.FromArgb(73, 92, 102);
            btnRedondo2.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnRedondo2.BorderColor = Color.White;
            btnRedondo2.BorderRadius = 30;
            btnRedondo2.BorderSize = 3;
            btnRedondo2.FlatAppearance.BorderSize = 0;
            btnRedondo2.FlatStyle = FlatStyle.Flat;
            btnRedondo2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRedondo2.ForeColor = Color.White;
            btnRedondo2.Location = new Point(465, 542);
            btnRedondo2.Name = "btnRedondo2";
            btnRedondo2.Size = new Size(150, 55);
            btnRedondo2.TabIndex = 3;
            btnRedondo2.Text = "Editar";
            btnRedondo2.TextColor = Color.White;
            btnRedondo2.UseVisualStyleBackColor = false;
            // 
            // btnRedondo3
            // 
            btnRedondo3.BackColor = Color.FromArgb(73, 92, 102);
            btnRedondo3.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnRedondo3.BorderColor = Color.White;
            btnRedondo3.BorderRadius = 30;
            btnRedondo3.BorderSize = 3;
            btnRedondo3.FlatAppearance.BorderSize = 0;
            btnRedondo3.FlatStyle = FlatStyle.Flat;
            btnRedondo3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRedondo3.ForeColor = Color.White;
            btnRedondo3.Location = new Point(263, 542);
            btnRedondo3.Name = "btnRedondo3";
            btnRedondo3.Size = new Size(150, 55);
            btnRedondo3.TabIndex = 4;
            btnRedondo3.Text = "Relatorio";
            btnRedondo3.TextColor = Color.White;
            btnRedondo3.UseVisualStyleBackColor = false;
            // 
            // btnRedondo4
            // 
            btnRedondo4.BackColor = Color.FromArgb(165, 76, 76);
            btnRedondo4.BackgroundColor = Color.FromArgb(165, 76, 76);
            btnRedondo4.BorderColor = Color.White;
            btnRedondo4.BorderRadius = 30;
            btnRedondo4.BorderSize = 3;
            btnRedondo4.FlatAppearance.BorderSize = 0;
            btnRedondo4.FlatStyle = FlatStyle.Flat;
            btnRedondo4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnRedondo4.ForeColor = Color.White;
            btnRedondo4.Location = new Point(63, 542);
            btnRedondo4.Name = "btnRedondo4";
            btnRedondo4.Size = new Size(150, 55);
            btnRedondo4.TabIndex = 5;
            btnRedondo4.Text = "Excluir";
            btnRedondo4.TextColor = Color.White;
            btnRedondo4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(204, 203, 205);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(64, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(389, 32);
            textBox1.TabIndex = 6;
            // 
            // ConsultarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 620);
            Controls.Add(textBox1);
            Controls.Add(btnRedondo4);
            Controls.Add(btnRedondo3);
            Controls.Add(btnRedondo2);
            Controls.Add(listView1);
            Controls.Add(btnRedondo1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarFuncionario";
            Text = "Consultar Funcionários";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Util.BtnRedondo btnRedondo1;
        private ListView listView1;
        private ColumnHeader colunaID;
        private ColumnHeader colunaNome;
        private ColumnHeader colunaEmail;
        private Util.BtnRedondo btnRedondo2;
        private Util.BtnRedondo btnRedondo3;
        private Util.BtnRedondo btnRedondo4;
        private TextBox textBox1;
    }
}