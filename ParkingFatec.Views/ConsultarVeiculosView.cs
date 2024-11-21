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
    public partial class ConsultarVeiculosView : Form
    {
            VeiculoDAO veiculoDAO = new VeiculoDAO();
        public ConsultarVeiculosView()
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

                string query = "SELECT id, placa, tipo, modelo, cor, motorista_id FROM veiculos WHERE placa LIKE @termo OR modelo LIKE @termo";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                gridVeiculos.Rows.Clear();

                while (reader.Read())
                {
                    gridVeiculos.Rows.Add(
                         reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.IsDBNull(5) ? "Sem motorista" : reader.GetString(5)
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

                string query = @"
            SELECT 
                veiculos.id, 
                veiculos.placa, 
                veiculos.tipo, 
                veiculos.modelo, 
                veiculos.cor, 
                motoristas.nome AS nome
            FROM 
                veiculos
            LEFT JOIN 
                motoristas 
            ON 
                veiculos.motoristas_id = motoristas.id
            ORDER BY 
                veiculos.id ASC";

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                MySqlDataReader reader = cmd.ExecuteReader();

                gridVeiculos.Rows.Clear();

                while (reader.Read())
                {
                    gridVeiculos.Rows.Add(
                reader.GetInt32(0).ToString(),
                reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3),
                reader.GetString(4),
                reader.IsDBNull(5) ? "Sem motorista" : reader.GetString(5)
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
            if (gridVeiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um item para excluir.");
                return;
            }

            var itemSelecionado = gridVeiculos.SelectedRows[0];
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

                    string query = "DELETE FROM veiculos WHERE id = @id";
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

            if (gridVeiculos.CurrentRow != null) // Verifica se há uma linha selecionada
            {
                try
                {

                    int id = Convert.ToInt32(gridVeiculos.CurrentRow.Cells["colID"].Value);
                    string novaPlaca = gridVeiculos .CurrentRow.Cells["colPlaca"].Value?.ToString() ?? string.Empty;
                    string novoModelo = gridVeiculos.CurrentRow.Cells["colModelo"].Value?.ToString() ?? string.Empty;
                    string novaCor = gridVeiculos.CurrentRow.Cells["colCor"].Value?.ToString() ?? string.Empty;

                    if (string.IsNullOrWhiteSpace(novaPlaca) || string.IsNullOrWhiteSpace(novoModelo) || string.IsNullOrWhiteSpace(novaCor))
                    {
                        MessageBox.Show("Ops! Há campos vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    Veiculo veiculoAtualizado = new Veiculo
                    {
                        Id = id,
                        Placa = novaPlaca,
                        Modelo = novoModelo,
                        Cor = novaCor,
                    };


                    veiculoDAO.alterarVeiculo(veiculoAtualizado);

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
