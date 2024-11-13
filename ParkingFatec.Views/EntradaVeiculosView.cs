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
    public partial class EntradaVeiculosView : Form
    {
        Entradas entradas = new Entradas();
        EntradasDAO entradasDAO = new EntradasDAO();
        Usuarios usuarios = new Usuarios();
        Veiculo veiculo = new Veiculo();
        VeiculoDAO veiculoDAO = new VeiculoDAO();
        Estacionamento estacionamento = new Estacionamento();
        EstacionamentoDAO estacionamentoDAO = new EstacionamentoDAO();

        private InicioView inicioView;
        public EntradaVeiculosView(Usuarios usuarios, InicioView inicioView)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.inicioView = inicioView;

            Estacionamento estacionamento = estacionamentoDAO.obterDadosEstacionamento(1);

            txtVagasMoto.Text = estacionamento.VagaMoto.ToString();
            txtVagasCarro.Text = estacionamento.VagaCarro.ToString();
        }


        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar != (char)Keys.Back)
            {
                switch (txtData.TextLength)
                {
                    case 2:
                        txtData.Text = txtData.Text + "/";
                        txtData.SelectionStart = txtData.Text.Length;
                        break;
                    case 5:
                        txtData.Text = txtData.Text + "/";
                        txtData.SelectionStart = txtData.Text.Length;
                        break;
                }
            }
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar != (char)Keys.Back)
            {
                switch (txtHora.TextLength)
                {
                    case 2:
                        txtHora.Text = txtHora.Text + ":";
                        txtHora.SelectionStart = txtHora.Text.Length;
                        break;
                }
            }
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || (char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || (char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_MouseClick(object sender, MouseEventArgs e)
        {

        }

       
    }
}
