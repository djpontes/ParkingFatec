using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingFatec.Control
{
    public class AbrirForms
    {
        public void abrirForms(Form mainForm, Form form, Panel panel)
        {
            // ta definindo que o formulário não será uma janela de nível superior 
            form.TopLevel = false;

            // ta falando que a posição será feita manualmento
            form.StartPosition = FormStartPosition.Manual;

            // ta centralizando o form
            form.Location = new Point(
                (panel.Width - form.Width) / 2,  
                (panel.Height - form.Height) / 2  
            );

            // ta adicionando o form dentro do painel
            panel.Controls.Add(form);

            // ta desabilitando os botoes fora do painel
            foreach (System.Windows.Forms.Control ctrl in mainForm.Controls)
            {
                if (ctrl != panel) ctrl.Enabled = false;
            }

            form.Show();

            // reativando os botoes ao fechar o formulário
            form.FormClosed += (s, args) =>
            {
                foreach (System.Windows.Forms.Control ctrl in mainForm.Controls)
                {
                    if (ctrl != panel) ctrl.Enabled = true;
                }

                panel.Controls.Remove(form);
            };
        }
    }
}
