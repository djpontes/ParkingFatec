using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingFatec.Views
{
    public class FecharForm : Form
    {

        Form formulario = new Form();

        public FecharForm() { }


        public bool Fechar(Form formulario)
        {
            var resultado = MessageBox.Show("Cadastro realizado com sucesso!\n" +
                                            "Deseja realizar novo cadastro?\n",
                                            "Confirmação",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                formulario.Close();  // Fecha o formulário
                return true;
            }

            return false;
        }
    }
}
