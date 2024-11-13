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
    public partial class InicioView : Form
    {
        private Usuarios usuarios;
        public InicioView(Usuarios usuarios)
        {
            InitializeComponent();
            esconderPanel();
            this.usuarios = usuarios;
           
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
            LoginView loginView = new LoginView(usuarios);
            loginView.Show();
            this.Close();
        }

        private void btnEntradas_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            EntradaVeiculosView entradaVeiculosView = new EntradaVeiculosView(usuarios, this);
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, entradaVeiculosView, panelForms);
        }

        private void btnSaidas_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            SaidaVeiculoView saidaVeiculoView = new SaidaVeiculoView();
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, saidaVeiculoView, panelForms);
        }

        private void lblEstacionamento_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            EstacionamentoView estacionamentoView = new EstacionamentoView();
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, estacionamentoView, panelForms);
        }

        private void lblPerfil_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            PerfilView perfilView = new PerfilView(usuarios, this);
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, perfilView, panelForms);
        }

        private void lblMotoristaFuncio_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            CadastroMotoristaView cadastroMotoristaView = new CadastroMotoristaView(usuarios, this);
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, cadastroMotoristaView, panelForms);
        }

        private void lblVeiculosFuncio_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            CadastroVeiculoView cadastroVeiculoView = new CadastroVeiculoView(usuarios, this);
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, cadastroVeiculoView, panelForms);
        }

        private void lblFuncionario_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            CadastroFuncionarioView cadastroFuncionarioView = new CadastroFuncionarioView();
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, cadastroFuncionarioView, panelForms);
        }

        private void lblMotorista_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            CadastroMotoristaView cadastroMotoristaView = new CadastroMotoristaView(usuarios, this);
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, cadastroMotoristaView, panelForms);
        }

        private void lblVeiculos_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            CadastroVeiculoView cadastroVeiculoView = new CadastroVeiculoView(usuarios, this);
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, cadastroVeiculoView, panelForms);
        }

        private void lblMotoristasFuncio_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            ConsultarMotoristasView consultarMotoristasView = new ConsultarMotoristasView();
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, consultarMotoristasView, panelForms);
        }

        private void lblVeiculoFuncio_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            ConsultarVeiculosView consultarVeiculosView = new ConsultarVeiculosView();
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, consultarVeiculosView, panelForms);
        }

        private void lblEntraSaiFuncio_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            ConsultarEntradaSaidaView consultarEntradaSaidaView = new ConsultarEntradaSaidaView();
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, consultarEntradaSaidaView, panelForms);
        }

        private void lblMotoristaAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            ConsultarMotoristasView consultarMotoristasView = new ConsultarMotoristasView();
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, consultarMotoristasView, panelForms);
        }

        private void lblFuncionarioAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            ConsultarFuncionarioView consultarFuncionarioView = new ConsultarFuncionarioView();
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, consultarFuncionarioView, panelForms);
        }

        private void lblVeiculosAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            ConsultarVeiculosView consultarVeiculosView = new ConsultarVeiculosView();
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, consultarVeiculosView, panelForms);
        }

        private void lblEntraSai_MouseClick(object sender, MouseEventArgs e)
        {
            esconderPanel();
            ConsultarEntradaSaidaView consultarEntradaSaidaView = new ConsultarEntradaSaidaView();
            AbrirForms abrir = new AbrirForms();
            abrir.abrirForms(this, consultarEntradaSaidaView, panelForms);
        }
    }
}
