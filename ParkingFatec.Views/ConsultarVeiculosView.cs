using MySql.Data.MySqlClient;
using ParkingFatec.Control;
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

                listVeiculo.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(), 
                        reader.GetString(1),          
                        reader.GetString(2),           
                        reader.GetString(3),
                        reader.GetString(4)
                    };

                    listVeiculo.Items.Add(new ListViewItem(row));
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

                // Consulta com JOIN para buscar o nome do motorista
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
            /*
            if (listVeiculo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um item para excluir.");
                return;
            }

            // Obter o ID do item selecionado
            var itemSelecionado = listVeiculo.SelectedItems[0];
            int idSelecionado = int.Parse(itemSelecionado.SubItems[0].Text);

            // Confirmação do usuário
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
                    // Conexão com o banco
                    ConexaoDAO conn = new ConexaoDAO();
                    conexao = conn.GetConnection();

                    // Comando para excluir registros nas tabelas filhas
                    string deleteQueryFilha1 = "DELETE FROM registros WHERE veiculo_id = @id";
                    MySqlCommand cmdFilha1 = new MySqlCommand(deleteQueryFilha1, conexao);
                    cmdFilha1.Parameters.AddWithValue("@id", idSelecionado);
                    cmdFilha1.ExecuteNonQuery();

                    
                    string deleteQueryFilha2 = "DELETE FROM tabela_filha2 WHERE veiculo_id = @id";
                    MySqlCommand cmdFilha2 = new MySqlCommand(deleteQueryFilha2, conexao);
                    cmdFilha2.Parameters.AddWithValue("@id", idSelecionado);
                    cmdFilha2.ExecuteNonQuery();

                    // Agora excluindo o registro da tabela veiculos
                    string query = "DELETE FROM veiculos WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id", idSelecionado);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recarregar o ListView
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
            }*/

        }
    }
}
