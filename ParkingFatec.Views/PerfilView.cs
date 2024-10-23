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
    public partial class PerfilView : Form
    {
        public PerfilView()
        {
            InitializeComponent();
            iconOlhoOff.Visible = false;
        }

        private void iconOlhoOff_MouseClick(object sender, MouseEventArgs e)
        {
            iconOlhoOff.Visible = false;
            iconOlho.Visible = true;
            txtSenha.UseSystemPasswordChar = true;
        }

        private void iconOlho_MouseClick(object sender, MouseEventArgs e)
        {
            iconOlho.Visible = false;
            iconOlhoOff.Visible = true;
            txtSenha.UseSystemPasswordChar = false;
        }
    }
}
