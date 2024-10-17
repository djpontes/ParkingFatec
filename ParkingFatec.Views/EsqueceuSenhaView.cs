using ParkingFatec.Control;
using ParkingFatec.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingFatec.Views
{
    public partial class EsqueceuSenhaView : Form
    {
        ConexaoDAO conexaoDAO = new ConexaoDAO();
        Email email = new Email();
        Usuarios usuarios = new Usuarios();
        public EsqueceuSenhaView()
        {
            InitializeComponent();
        }

        private void btnRecuperarSenha_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) {
                MessageBox.Show("Campo vazio, por favor, preencha-o", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                 usuarios.Email = txtEmail.Text;

                email.EnviarNovaSenha(txtEmail.Text, this);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || e.KeyChar == 47 || (e.KeyChar >= 58 && e.KeyChar <= 63) ||
                (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true; // bloquea o caractere
            }
        }
    }
}
