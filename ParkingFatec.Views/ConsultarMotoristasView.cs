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
    public partial class ConsultarMotoristasView : Form
    {
        public ConsultarMotoristasView()
        {
            InitializeComponent();

            listMotorista.View = View.Details;
            listMotorista.LabelEdit = true;
            listMotorista.AllowColumnReorder = true;
            listMotorista.FullRowSelect = true;
            listMotorista.GridLines = true;

            listMotorista.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listMotorista.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listMotorista.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            listMotorista.Columns.Add("CNH", 100, HorizontalAlignment.Left);
            listMotorista.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            listMotorista.Columns.Add("Telefone", 100, HorizontalAlignment.Left);

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

                listMotorista.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),          
                        reader.GetString(2),           
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5)
                    };

                    listMotorista.Items.Add(new ListViewItem(row));
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

                listMotorista.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                reader.GetInt32(0).ToString(), 
                reader.GetString(1),          
                reader.GetString(2),           
                reader.GetString(3),
                reader.GetString(4),
                reader.GetString(5)
            };

                    listMotorista.Items.Add(new ListViewItem(row));
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
            if (listMotorista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um item para excluir.");
                return;
            }

            var itemSelecionado = listMotorista.SelectedItems[0];
            int idSelecionado = int.Parse(itemSelecionado.SubItems[0].Text);

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
    }
}
