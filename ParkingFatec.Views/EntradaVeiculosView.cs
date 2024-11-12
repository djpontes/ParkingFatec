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
        public EntradaVeiculosView()
        {
            InitializeComponent();
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
    }
}
