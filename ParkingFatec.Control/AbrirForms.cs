public class AbrirForms
{
    public void abrirForms(Form mainForm, Form form, Panel panel)
    {
        // Limpa o painel antes de adicionar o novo formulário
        panel.Controls.Clear();

        // Configura o formulário para que ele não seja uma janela de nível superior
        form.TopLevel = false;

        // Define a posição inicial do formulário no painel
        form.StartPosition = FormStartPosition.Manual;

        // Centraliza o formulário no painel
        form.Location = new Point(
            (panel.Width - form.Width) / 2,
            (panel.Height - form.Height) / 2
        );

        // Adiciona o formulário ao painel
        panel.Controls.Add(form);
        form.BringToFront();

        // Desativa os controles fora do painel, exceto o próprio painel
        foreach (Control ctrl in mainForm.Controls)
        {
            if (ctrl != panel) ctrl.Enabled = false;
        }

        // Exibe o formulário dentro do painel
        form.Show();

        // Reabilita os controles quando o formulário é fechado
        form.FormClosed += (s, args) =>
        {
            foreach (Control ctrl in mainForm.Controls)
            {
                if (ctrl != panel) ctrl.Enabled = true;
            }

            // Remove o formulário do painel após o fechamento
            panel.Controls.Remove(form);
        };
    }
}
