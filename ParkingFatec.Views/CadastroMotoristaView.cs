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
    public partial class CadastroMotoristaView : Form
    {
        public CadastroMotoristaView()
        {
            InitializeComponent();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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

        private void txtCNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            // Lógica para aplicar a máscara conforme a quantidade de caracteres
            if (e.KeyChar != (char)Keys.Back) // Ignora quando é o Backspace
            {
                switch (txtCPF.TextLength)
                {
                    case 3:
                        txtCPF.Text = txtCPF.Text + ".";
                        txtCPF.SelectionStart = txtCPF.Text.Length;
                        break;
                    case 7:
                        txtCPF.Text = txtCPF.Text + ".";
                        txtCPF.SelectionStart = txtCPF.Text.Length;
                        break;
                    case 11:
                        txtCPF.Text = txtCPF.Text + "-";
                        txtCPF.SelectionStart = txtCPF.Text.Length;
                        break;
                }
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar != (char)Keys.Back) // Ignora quando é o Backspace
            {
                switch (txtTelefone.TextLength)
                {
                    case 1:
                        txtTelefone.Text = "(" + txtTelefone.Text;
                        txtTelefone.SelectionStart = txtTelefone.Text.Length;
                        break;
                    case 3:
                        txtTelefone.Text = txtTelefone.Text + ")";
                        txtTelefone.SelectionStart = txtTelefone.Text.Length;
                        break;
                    case 9:
                        txtTelefone.Text = txtTelefone.Text + "-";
                        txtTelefone.SelectionStart = txtTelefone.Text.Length;
                        break;
                }
            }
        }
    }
}
