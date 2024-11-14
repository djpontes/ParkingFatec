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
        Veiculo veiculos = new Veiculo();
        VeiculoDAO veiculoDAO = new VeiculoDAO();
        Estacionamento estacionamento = new Estacionamento();
        EstacionamentoDAO estacionamentoDAO = new EstacionamentoDAO();

        private InicioView inicioView;
        public EntradaVeiculosView(Usuarios usuarios, InicioView inicioView)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.inicioView = inicioView;

            this.estacionamento = estacionamentoDAO.obterDadosEstacionamento(1);

            txtVagasMoto.Text = estacionamento.VagaMoto.ToString();
            txtVagasCarro.Text = estacionamento.VagaCarro.ToString();
        }

        private void limparCampos()
        {
            txtPlaca.Clear();
            txtVeiculo.Clear();
            txtData.Clear();
            txtHora.Clear();
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
            if (string.IsNullOrEmpty(txtPlaca.Text) || string.IsNullOrEmpty(txtData.Text) || string.IsNullOrEmpty(txtHora.Text)
                || string.IsNullOrEmpty(txtVeiculo.Text))
            {
                MessageBox.Show("Ops, há campo(s) vazio(s). Por favor, preencha-os e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Veiculo veiculo = veiculoDAO.obterDadosVeiculos(txtPlaca.Text);
                if (veiculo == null)
                {
                    MessageBox.Show("Veículo não encontrado. Verifique a placa e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                entradas.Veiculos_id = veiculo.Id;
                txtVeiculo.Text = veiculo.Modelo;
                entradas.Usuarios_id = usuarios.Id;
                entradas.Data_entrada = DateTime.Parse(txtData.Text);
                entradas.Horario_entrada = DateTime.Parse(txtHora.Text);

                if (veiculo.Tipo == "Moto")
                {
                    if (estacionamento.VagaMoto > 0)
                    {
                        estacionamento.VagaMoto--;
                    }
                    else
                    {
                        MessageBox.Show("Não há vagas disponíveis para motos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (veiculo.Tipo == "Carro")
                {
                    if (estacionamento.VagaCarro > 0)
                    {
                        estacionamento.VagaCarro--;
                    }
                    else
                    {
                        MessageBox.Show("Não há vagas disponíveis para carros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                estacionamentoDAO.alterarEstacionamento(estacionamento);

                entradasDAO.inserirEntradas(entradas);

                MessageBox.Show("Cadastro efetuado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();

                txtVagasMoto.Text = estacionamento.VagaMoto.ToString();
                txtVagasCarro.Text = estacionamento.VagaCarro.ToString();
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            if (txtPlaca.Text.Length == 8)
            {
                Veiculo veiculo = veiculoDAO.obterDadosVeiculos(txtPlaca.Text);

                if (veiculo == null)
                {
                    MessageBox.Show("Veículo não encontrado. Verifique a placa e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVeiculo.Clear();
                    txtData.Clear();
                    txtHora.Clear();
                    return;
                }

       
                txtVeiculo.Text = veiculo.Modelo;

                DateTime dataHoraAtual = DateTime.Now;
                entradas.Data_entrada = dataHoraAtual.Date;      
                entradas.Horario_entrada = dataHoraAtual;         


                txtData.Text = dataHoraAtual.ToString("dd/MM/yyyy");
                txtHora.Text = dataHoraAtual.ToString("HH:mm");
            }
        }
    }
}
