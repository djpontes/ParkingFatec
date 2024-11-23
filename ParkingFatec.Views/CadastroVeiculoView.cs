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
    public partial class CadastroVeiculoView : Form
    {
        Motoristas motoristas = new Motoristas();
        MotoristasDAO motoristasDAO = new MotoristasDAO();
        Usuarios usuarios = new Usuarios();
        Veiculo veiculo = new Veiculo();
        VeiculoDAO veiculoDAO = new VeiculoDAO();
        private InicioView inicioView;


        public CadastroVeiculoView(Usuarios usuarios, InicioView inicioView)
        {
            InitializeComponent();
            this.inicioView = inicioView;
            this.usuarios = usuarios;
        }

        private void LimparCampos()
        {
            txtCNH.Clear();
            txtCor.Clear();
            txtModelo.Clear();
            boxTipoVeiculo.SelectedIndex = -1;
            txtPlaca.Clear();
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || (char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlaca.Text) || string.IsNullOrEmpty(txtModelo.Text) || string.IsNullOrEmpty(txtCor.Text) ||
                string.IsNullOrEmpty(txtCNH.Text) || boxTipoVeiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Ops, há campo(s) vazio(s). Por favor, preencha-os e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                veiculo.Placa = txtPlaca.Text;
                veiculo.Modelo = txtModelo.Text;
                veiculo.Cor = txtCor.Text;
                veiculo.Tipo = boxTipoVeiculo.SelectedItem.ToString();

                // Busca o objeto Motorista com base no nome digitado
                Motoristas motorista = motoristasDAO.obterDadosMotorista(txtCNH.Text);

                if (motorista == null)
                {
                    MessageBox.Show("Motorista não encontrado. Verifique a cnh e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                veiculo.Motoristas_id = motorista.Id;

                veiculo.Usuarios_id = usuarios.Id;


                veiculoDAO.inserirVeiculo(veiculo);

                MessageBox.Show("Cadastro efetuado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();


            }
        }

        private void txtCNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

