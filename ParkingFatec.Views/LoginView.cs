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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ParkingFatec.Views
{
    public partial class LoginView : Form
    {
        Usuarios usuarios = new Usuarios();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public LoginView(Usuarios usuarios)
        {
            InitializeComponent();
            iconOlhoOff.Visible = false;
            primeiroAcesso();
            this.usuarios = usuarios;
        }

        private void primeiroAcesso()
        {
            if (!usuarioDAO.ExisteUsuario())
            {
                lblPrimeiroAcesso.Visible = true;
                btnCadastrarAdmin.Visible = true;
            }
            else
            {
                lblPrimeiroAcesso.Visible = false;
                btnCadastrarAdmin.Visible = false;
            }
        }

        private void btnCadastrarAdmin_MouseClick(object sender, MouseEventArgs e)
        {
                PrimeiroAcessoView primeiroAcessoView = new PrimeiroAcessoView();
                primeiroAcessoView.Show();
                this.Hide();  
        }


        private void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceuSenhaView esqueceuSenhaView = new EsqueceuSenhaView();
            esqueceuSenhaView.ShowDialog();
        }

        private void btnEntrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSenha.Text)){ 
                MessageBox.Show("Ops, há campo(s) vazio(s). Por favor, preencha-os e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ValidarEmail.validarEmail(txtEmail.Text))
            {
                usuarios.Email = txtEmail.Text;
                usuarios.Senha = txtSenha.Text;

                if (usuarioDAO.AutenticarUsuario(usuarios))
                {
                    //buscando os dados do usuario
                    usuarios = usuarioDAO.ObterDadosUsuario(usuarios.Email);

                    //passando o objeto usuario com os dados de qm ta logando
                    InicioView inicioView = new InicioView(usuarios);
                    inicioView.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("E-mail ou senha inválido. Por favor, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Formato do e-mail incorreto. O formato deve ser '@fatec.sp.gov.br'. Por favor, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloquea caracteres específicos com base na tabela ASCII
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
    }
}
