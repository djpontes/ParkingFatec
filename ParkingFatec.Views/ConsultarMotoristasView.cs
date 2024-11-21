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
    public partial class ConsultarMotoristasView : Form
    {
        MotoristasDAO motoristasDAO = new MotoristasDAO();
        public ConsultarMotoristasView()
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

                string query = "SELECT id, nome, email, cnh, ra_rm, telefone FROM motoristas WHERE nome LIKE @termo OR email LIKE @termo";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                gridMotorista.Rows.Clear();

                while (reader.Read())
                {
                    gridMotorista.Rows.Add(
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5)
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

                string query = "SELECT id, nome, email, cnh, ra_rm, telefone FROM motoristas ORDER BY id ASC"; // Ordena por ID
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                MySqlDataReader reader = cmd.ExecuteReader();

                gridMotorista.Rows.Clear();

                while (reader.Read())
                {
                    gridMotorista.Rows.Add(
                 reader.GetInt32(0).ToString(),
                reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3),
                reader.IsDBNull(4) ? "" : reader.GetString(4),
                reader.GetString(5)
            );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar registros: " + ex.Message);
            }
            finally
            {
                conexao?.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridMotorista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um item para excluir.");
                return;
            }

            var itemSelecionado = gridMotorista.SelectedRows[0];
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

                    string query = "DELETE FROM motoristas WHERE id = @id";
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
            if (gridMotorista.CurrentRow != null) // Verifica se há uma linha selecionada
            {
                try
                {
                    
                    int id = Convert.ToInt32(gridMotorista.CurrentRow.Cells["colID"].Value);
                    string novoNome = gridMotorista.CurrentRow.Cells["colNome"].Value?.ToString() ?? string.Empty;
                    string novoEmail = gridMotorista.CurrentRow.Cells["colEmail"].Value?.ToString() ?? string.Empty;
                    string novaCNH = gridMotorista.CurrentRow.Cells["colCNH"].Value?.ToString() ?? string.Empty;
                    string novoRa_rm = gridMotorista.CurrentRow.Cells["colRa_rm"].Value?.ToString() ?? string.Empty;
                    string novoTelefone = gridMotorista.CurrentRow.Cells["colTelefone"].Value?.ToString() ?? string.Empty;

                    if (string.IsNullOrWhiteSpace(novoNome) || string.IsNullOrWhiteSpace(novoEmail) || string.IsNullOrWhiteSpace(novaCNH) 
                        || string.IsNullOrWhiteSpace(novoTelefone))
                    {
                        MessageBox.Show("Ops! Há campos vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

          
                    Motoristas motoristaAtualizado = new Motoristas
                    {
                        Id = id,
                        Nome = novoNome,
                        Email = novoEmail,
                        Cnh = novaCNH,
                        Ra_rm = novoRa_rm,
                        Telefone = novoTelefone,
                    };

                   
                    motoristasDAO.alterarMotorista(motoristaAtualizado);

                    MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
