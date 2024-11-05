using System.Drawing;
using System.Windows.Forms;

public class AbrirForms
{
    public void abrirForms(Form mainForm, Form form, Panel panel)
    {
        form.TopLevel = true;
        form.FormBorderStyle = FormBorderStyle.FixedSingle;
        form.StartPosition = FormStartPosition.Manual;

        // baixa mais a janela
        int offsetY = 35; 

        // centraliza a janela 
        form.Location = new Point(
            mainForm.Location.X + panel.Location.X + (panel.Width - form.Width) / 2,
            mainForm.Location.Y + panel.Location.Y + (panel.Height - form.Height) / 2 + offsetY
        );

        // a janela fica em cima
        form.Show(mainForm);

        // bloqueia os controles da janela principal enquanto a nova janela está aberto
        mainForm.Enabled = false;

        // volta os controles quando o formulário é fechado
        form.FormClosed += (s, args) =>
        {
            mainForm.Enabled = true;
            mainForm.BringToFront();
        };
    }
}
