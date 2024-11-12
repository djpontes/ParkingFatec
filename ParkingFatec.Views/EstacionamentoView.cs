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
using System.Web;
using System.Windows.Forms;

namespace ParkingFatec.Views
{
    public partial class EstacionamentoView : Form
    {
        Estacionamento estacionamento = new Estacionamento();
        EstacionamentoDAO estacionamentoDAO = new EstacionamentoDAO();
        public EstacionamentoView()
        {
            InitializeComponent();
            estacionamento = estacionamentoDAO.obterDadosEstacionamento(1);
            txtMoto.Text = estacionamento.VagaMoto.ToString();
            txtCarro.Text = estacionamento.VagaCarro.ToString();
        
        }

        private void txtMoto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtCarro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMoto.Text) || string.IsNullOrWhiteSpace(txtCarro.Text))
            {
                MessageBox.Show("Ops, há campo(s) vazio(s). Por favor, preencha-os e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 

            estacionamento.VagaMoto = int.Parse(txtMoto.Text);
            estacionamento.VagaCarro = int.Parse(txtCarro.Text);


            if (!estacionamentoDAO.existeEstacionamento())
            {
                estacionamentoDAO.inserirEstacionamento(estacionamento);
                MessageBox.Show("Vagas registradas com sucesso", "Vagas Disponiveis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                estacionamentoDAO.alterarEstacionamento(estacionamento);
                MessageBox.Show("Vagas registradas com sucesso", "Vagas Disponiveis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
