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
    public partial class CadastroFuncionarioView : Form
    {
        Usuarios usuarios = new Usuarios();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public CadastroFuncionarioView()
        {
            InitializeComponent();
            iconOlhoOff.Visible = false;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            boxNivelAcesso.SelectedIndex = -1;
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

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 || e.KeyChar == 34 || e.KeyChar == 39 ||
                (e.KeyChar >= 40 && e.KeyChar <= 41) || e.KeyChar == 44 ||
                e.KeyChar == 47 || (e.KeyChar >= 58 && e.KeyChar <= 59) ||
                (e.KeyChar >= 60 && e.KeyChar <= 62) ||
                (e.KeyChar >= 91 && e.KeyChar <= 93) || e.KeyChar == 92 ||
                e.KeyChar == 95 || e.KeyChar == 96 ||
                (e.KeyChar >= 123 && e.KeyChar <= 125) || e.KeyChar == 124)
            {
                e.Handled = true; // bloqueia o caractere
            }
        }

        private void iconOlhoOff_MouseClick(object sender, MouseEventArgs e)
        {
            iconOlhoOff.Visible = false;
            iconOlho.Visible = true;
            txtSenha.UseSystemPasswordChar = true;
        }

        private void iconOlho_MouseClick(object sender, MouseEventArgs e)
        {
            iconOlho.Visible = false;
            iconOlhoOff.Visible = true;
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(txtNome.Text) ||
                boxNivelAcesso.SelectedIndex == -1)
            {
                MessageBox.Show("Ops, há campo(s) vazio(s). Por favor, preencha-os e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool emailValido = false;

            if (boxNivelAcesso.SelectedIndex == 0) //admin
            {
                emailValido = ValidarEmailFatec.validarEmailFatec(txtEmail.Text);
                if (!emailValido)
                {
                    MessageBox.Show("E-mail inválido: por favor, cadastre seu e-mail institucional.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (boxNivelAcesso.SelectedIndex == 1) //segurança
            {
                emailValido = ValidarEmail.validarEmail(txtEmail.Text);
                if (!emailValido)
                {
                    MessageBox.Show("E-mail inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            usuarios.Nome = txtNome.Text;
            usuarios.Email = txtEmail.Text;
            usuarios.Senha = txtSenha.Text;
            usuarios.NivelAcesso = boxNivelAcesso.SelectedIndex;

            usuarioDAO.inserirUsuario(usuarios);

            MessageBox.Show("Cadastro efetuado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
        }

    }
}
