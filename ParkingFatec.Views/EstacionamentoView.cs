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
    public partial class EstacionamentoView : Form
    {
        public EstacionamentoView()
        {
            InitializeComponent();
        }

        private void txtMoto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter (e.KeyChar) || char.IsSymbol (e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == 32)
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
    }
}
