using MySql.Data.MySqlClient;
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
    public partial class ConsultarFuncionarioView : Form
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public ConsultarFuncionarioView()
        {
            InitializeComponent();

            CarregarTodos();
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            string termoBusca = txtPesquisar.Text.Trim();

            if (string.IsNullOrEmpty(termoBusca))
            {
                MessageBox.Show("Por favor, insira um termo para busca.");
                return;
            }

            ConexaoDAO conn = new ConexaoDAO();
            MySqlConnection conexao = null;

            try
            {

                conexao = conn.GetConnection();

                string query = "SELECT id, nome, email, nivel_acesso FROM usuarios WHERE nome LIKE @termo OR email LIKE @termo OR nivel_acesso LIKE @termo";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                gridFuncionario.Rows.Clear();

                while (reader.Read())
                {
                    gridFuncionario.Rows.Add(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a busca: " + ex.Message);
            }
            finally
            {
                conexao?.Close();
            }


        }

        private void CarregarTodos()
        {
            MySqlConnection conexao = null;

            try
            {
                ConexaoDAO conn = new ConexaoDAO();
                conexao = conn.GetConnection();

                string query = "SELECT id, nome, email, nivel_acesso FROM usuarios ORDER BY id ASC";
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                MySqlDataReader reader = cmd.ExecuteReader();

                gridFuncionario.Rows.Clear();

                while (reader.Read())
                {

                    gridFuncionario.Rows.Add(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao?.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridFuncionario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um item para excluir.");
                return;
            }

            var itemSelecionado = gridFuncionario.SelectedRows[0];
            int idSelecionado = Convert.ToInt32(itemSelecionado.Cells[0].Value);

            DialogResult confirmacao = MessageBox.Show(
                "Tem certeza que deseja excluir este registro?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                MySqlConnection conexao = null;

                try
                {
                    ConexaoDAO conn = new ConexaoDAO();
                    conexao = conn.GetConnection();

                    string query = "DELETE FROM usuarios WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id", idSelecionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregarTodos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao?.Close();
                }
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPesquisar.Text))
            {

                CarregarTodos();
            }
        }

        private void btnEditar_MouseClick(object sender, MouseEventArgs e)
        {
            if (gridFuncionario.CurrentRow != null) // Verifica se há uma linha selecionada
            {
                try
                {
                    // Recupera os dados da linha selecionada
                    int id = Convert.ToInt32(gridFuncionario.CurrentRow.Cells["colID"].Value);
                    string novoNome = gridFuncionario.CurrentRow.Cells["colNome"].Value?.ToString() ?? string.Empty;
                    string novoEmail = gridFuncionario.CurrentRow.Cells["colEmail"].Value?.ToString() ?? string.Empty;

                    if (string.IsNullOrWhiteSpace(novoNome) || string.IsNullOrWhiteSpace(novoEmail))
                    {
                        MessageBox.Show("Nome e e-mail não podem estar vazios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Cria um objeto Usuarios com os dados editados
                    Usuarios usuarioAtualizado = new Usuarios
                    {
                        Id = id,
                        Nome = novoNome,
                        Email = novoEmail,
                    };

                    // Chama o método alterarUsuario para atualizar no banco
                    usuarioDAO.alterarUsuario(usuarioAtualizado);

                    MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza a lista no DataGridView
                    CarregarTodos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar o usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

