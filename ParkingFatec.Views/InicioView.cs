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
    public partial class InicioView : Form
    {
        Usuarios usuarios = new Usuarios();
        public InicioView()
        {
            InitializeComponent();
            esconderPanel();

        }

        private void esconderPanel()
        {
            panelFuncionario.Visible = false;
            panelCadastrarAdmin.Visible = false;
            panelConsultarAdmin.Visible = false;
            panelCadastrarFuncio.Visible = false;
            panelConsultarFunc.Visible = false;
        }

        private void btnFuncionario_MouseClick(object sender, MouseEventArgs e)
        {
            // Verifica se o painelFuncionario já está visível
            if (panelFuncionario.Visible)
            {
                // Se estiver visível, apenas o esconde
                panelFuncionario.Visible = false;
            }
            else
            {
                // Se não estiver visível, esconde os outros painéis e exibe o painelFuncionario
                esconderPanel();
                panelFuncionario.Visible = true;
            }
        }

        private void btnCadastros_MouseClick(object sender, MouseEventArgs e)
        {
            if (usuarios.NivelAcesso == 0)
            {
                if (panelCadastrarAdmin.Visible)
                {
                    panelCadastrarAdmin.Visible = false;
                }
                else
                {
                    esconderPanel();
                    panelCadastrarAdmin.Visible = true;
                }


            }
            else
            {

                if (panelCadastrarFuncio.Visible)
                {
                    panelCadastrarFuncio.Visible = false;
                }
                else
                {
                    esconderPanel();
                    panelCadastrarFuncio.Visible = true;
                }
            }
        }

        private void btnConsultar_MouseClick(object sender, MouseEventArgs e)
        {
            if (usuarios.NivelAcesso == 0)
            {
                if (panelConsultarAdmin.Visible)
                {
                    panelConsultarAdmin.Visible = false;
                }
                else
                {
                    esconderPanel();
                    panelConsultarAdmin.Visible = true;
                }


            }
            else
            {

                if (panelConsultarFunc.Visible)
                {
                    panelConsultarFunc.Visible = false;
                }
                else
                {
                    esconderPanel();
                    panelConsultarFunc.Visible = true;
                }
            }
        }

        private void btnSair_MouseClick(object sender, MouseEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Close();
        }

        private void btnEntradas_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
        }

        private void btnSaidas_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
        }

        private void lblEstacionamento_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();

            EstacionamentoView estacionamentoView = new EstacionamentoView();
            estacionamentoView.TopLevel = false;
            estacionamentoView.StartPosition = FormStartPosition.Manual;  // Define que a posição será manual

            // Calcula a posição para centralizar o formulário no painel
            estacionamentoView.Location = new Point(
                (panelForms.Width - estacionamentoView.Width) / 2,  // Centraliza horizontalmente
                (panelForms.Height - estacionamentoView.Height) / 2  // Centraliza verticalmente
            );

            //aq ele ta adicionando o form estacionamento dentro do panel
            panelForms.Controls.Add(estacionamentoView);

            // Desabilita os controles fora do panel
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl != panelForms) ctrl.Enabled = false;
            }

            estacionamentoView.Show();

            // Evento para reativar controles ao fechar
            estacionamentoView.FormClosed += (s, args) =>
            {
                foreach (System.Windows.Forms.Control ctrl in this.Controls)
                {
                    if (ctrl != panelForms) ctrl.Enabled = true;
                }
            };
        }

        private void lblPerfil_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();

            PerfilView perfilView = new PerfilView();
            perfilView.TopLevel = false;
            perfilView.StartPosition = FormStartPosition.Manual;

            perfilView.Location = new Point(
                (panelForms.Width - perfilView.Width) / 2,  // Centraliza horizontalmente
                (panelForms.Height - perfilView.Height) / 2  // Centraliza verticalmente
            );

            panelForms.Controls.Add(perfilView);

            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl != panelForms) ctrl.Enabled = false;
            }

            perfilView.Show();

            perfilView.FormClosed += (s, args) =>
            {
                foreach (System.Windows.Forms.Control ctrl in this.Controls)
                {
                    if (ctrl != panelForms) ctrl.Enabled = true;
                }
            };
        }
    }
}
