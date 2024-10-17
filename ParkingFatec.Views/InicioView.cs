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
            panelConsultar.Visible = false;
            panelCadastrarFuncio.Visible = false;
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
            if (panelConsultar.Visible)
            {
                panelConsultar.Visible = false;
            }
            else
            {
                esconderPanel();
                panelConsultar.Visible = true;
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
    }
}
