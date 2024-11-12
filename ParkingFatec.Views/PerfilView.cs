using Microsoft.VisualBasic.Logging;
using Org.BouncyCastle.Ocsp;
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
    public partial class PerfilView : Form
    {
        private Usuarios usuarios;
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        private InicioView inicioView;

        public PerfilView(Usuarios usuarios, InicioView inicioView)
        {
            InitializeComponent();
            iconOlhoOff.Visible = false;
            this.usuarios = usuarios;
            this.inicioView = inicioView;

            txtEmail.Text = usuarios.Email;
            txtNome.Text = usuarios.Nome;
            txtSenha.Text = usuarios.Senha;


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
                e.Handled = true;
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
                e.Handled = true;
            }
        }

        private void btnEditar_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Ops, há campo(s) vazio(s). Por favor, preencha-os e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ValidarEmailFatec.validarEmailFatec(txtEmail.Text))
            {
                string email = txtEmail.Text;
                string nome = txtNome.Text;
                int idUser = usuarios.Id; 
                string senha = txtSenha.Text;

                DialogResult opcao = MessageBox.Show("Deseja alterar o(s) dado(s) do administrador?", "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    
                    usuarios.Nome = nome;
                    usuarios.Senha = senha;
                    usuarios.Email = email;
                    usuarios.Id = idUser;

                    usuarioDAO.alterarUsuario(usuarios);

                    inicioView.Close();
                    new LoginView(usuarios).Show(); 
                    this.Close();

                }

            }
            else
            {
                MessageBox.Show("E-mail inválido: por favor, cadastre seu e-mail institucional.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
