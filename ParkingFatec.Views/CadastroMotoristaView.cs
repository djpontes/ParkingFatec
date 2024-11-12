using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingFatec.Control;
using ParkingFatec.Model;

namespace ParkingFatec.Views
{
    public partial class CadastroMotoristaView : Form
    {
        Motoristas motoristas = new Motoristas();
        Usuarios usuarios = new Usuarios();
        MotoristasDAO motoristasDAO = new MotoristasDAO();
        private InicioView inicioView;
        public CadastroMotoristaView(Usuarios usuarios, InicioView inicioView)
        {
            InitializeComponent();
            this.inicioView = inicioView;
            this.usuarios = usuarios;

            txtDesabilitado();

        }

        private void txtDesabilitado()
        {
            txtCNH.Enabled = false;
            txtEmail.Enabled = false;
            txtNome.Enabled = false;
            txtRa_rm.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void txtHabilitado()
        {
            txtCNH.Enabled = true;
            txtEmail.Enabled = true;
            txtNome.Enabled = true;
            txtRa_rm.Enabled = true;
            txtTelefone.Enabled = true;
        }

        private void limparCampo()
        {
            txtCNH.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtRa_rm.Clear();
            txtTelefone.Clear();
            boxTipoMotorista.SelectedIndex = -1;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
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

        private void btnCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (boxTipoMotorista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de motorista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (boxTipoMotorista.SelectedIndex == 0 || boxTipoMotorista.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtRa_rm.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtCNH.Text) ||
                    string.IsNullOrEmpty(txtTelefone.Text))
                {
                    MessageBox.Show("Ops, há campo(s) vazio(s). Por favor, preencha-os e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidarEmailFatec.validarEmailFatec(txtEmail.Text))
                {
                    MessageBox.Show("O e-mail fornecido não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                motoristas.Nome = txtNome.Text;
                motoristas.Email = txtEmail.Text;
                motoristas.Cnh = txtCNH.Text;
                motoristas.Ra_rm = txtRa_rm.Text;
                motoristas.Telefone = txtTelefone.Text;
                motoristas.Tipo = boxTipoMotorista.SelectedIndex;

                int usuario = usuarios.Id;
                motoristas.Usuarios_id = usuario;

                motoristasDAO.inserirMotorista(motoristas);

                MessageBox.Show("Cadastro efetuado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (boxTipoMotorista.SelectedIndex >= 2)
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtCNH.Text) || string.IsNullOrEmpty(txtTelefone.Text))
                {
                    MessageBox.Show("Ops, há campo(s) vazio(s). Por favor, preencha-os e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidarEmail.validarEmail(txtEmail.Text))
                {
                    MessageBox.Show("O e-mail fornecido não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                motoristas.Nome = txtNome.Text;
                motoristas.Email = txtEmail.Text;
                motoristas.Cnh = txtCNH.Text;
                motoristas.Telefone = txtTelefone.Text;
                motoristas.Tipo = boxTipoMotorista.SelectedIndex;

                int usuario = usuarios.Id;
                motoristas.Usuarios_id = usuario;

                motoristasDAO.inserirMotorista(motoristas);

                MessageBox.Show("Cadastro efetuado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limparCampo();
            txtDesabilitado();
        }


        private void txtRa_rm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void boxTipoMotorista_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxTipoMotorista.SelectedIndex == 0 || boxTipoMotorista.SelectedIndex == 1)
            {
                txtHabilitado();
            }
            else
            {
                txtHabilitado();
                txtRa_rm.Enabled = false;
            }
        }
    }
}
