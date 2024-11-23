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
    public partial class ConsultarEntradaSaidaView : Form
    {

        VeiculoDAO veiculoDAO = new VeiculoDAO();
        EntradasDAO entradas = new EntradasDAO();
        SaidasDAO saidas = new SaidasDAO();
        MotoristasDAO motoristas = new MotoristasDAO();


        public ConsultarEntradaSaidaView()
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

            try
            {
                using (MySqlConnection conexao = conn.GetConnection())
                {
                    string query = @" SELECT registros.id, registros.data_entrada, 
                    registros.horario_entrada, registros.data_saida, 
                    registros.horario_saida, veiculos.placa AS placa, 
                    veiculos.tipo AS tipo, veiculos.modelo AS modelo, 
                    motoristas.nome AS nome FROM registros LEFT JOIN veiculos ON
                    registros.veiculos_id = veiculos.id LEFT JOIN motoristas ON 
                    veiculos.motoristas_id = motoristas.id WHERE veiculos.placa 
                    LIKE @termo OR veiculos.modelo LIKE @termo 
                    OR motoristas.nome LIKE @termo
                    ORDER BY registros.id ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            gridEntradaSaida.Rows.Clear();

                            while (reader.Read())
                            {
                                // Tratamento de valores nulos
                                int id = reader.GetInt32(0); // registros.id
                                string placa = reader.IsDBNull(5) ? "Veículo excluído" : reader.GetString(5);
                                string tipo = reader.IsDBNull(6) ? "Veículo excluído" : reader.GetString(6);
                                string modelo = reader.IsDBNull(7) ? "Veículo excluído" : reader.GetString(7);
                                string motorista = reader.IsDBNull(8) ? "Sem condutor" : reader.GetString(8);

                                DateTime? dataEntrada = reader.IsDBNull(1) ? (DateTime?)null : reader.GetDateTime(1);
                                TimeSpan? horarioEntrada = reader.IsDBNull(2) ? (TimeSpan?)null : reader.GetTimeSpan(2);
                                DateTime? dataSaida = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                                TimeSpan? horarioSaida = reader.IsDBNull(4) ? (TimeSpan?)null : reader.GetTimeSpan(4);

                                // Adiciona ao DataGridView
                                gridEntradaSaida.Rows.Add(
                                    id,
                                    placa,
                                    tipo,
                                    modelo,
                                    motorista,
                                    dataEntrada?.ToString("yyyy-MM-dd"),  // Formata a data (se necessário)
                                    horarioEntrada?.ToString(@"hh\:mm"), // Formata o horário
                                    dataSaida?.ToString("yyyy-MM-dd"),   // Formata a data
                                    horarioSaida?.ToString(@"hh\:mm")    // Formata o horário
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a busca: " + ex.Message);
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
            registros.id, 
            registros.data_entrada, 
            registros.horario_entrada, 
            registros.data_saida, 
            registros.horario_saida, 
            veiculos.placa AS placa, 
            veiculos.tipo AS tipo, 
            veiculos.modelo AS modelo, 
            motoristas.nome AS nome
        FROM registros 
        LEFT JOIN veiculos ON registros.veiculos_id = veiculos.id 
        LEFT JOIN motoristas ON veiculos.motoristas_id = motoristas.id
        ORDER BY registros.id ASC";

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                MySqlDataReader reader = cmd.ExecuteReader();

                gridEntradaSaida.Rows.Clear();

                while (reader.Read())
                {
                    // Tratamento de valores nulos
                    int id = reader.GetInt32(0); // registros.id
                    string placa = reader.IsDBNull(5) ? "Veiculo excluido" : reader.GetString(5); // veiculos.placa
                    string tipo = reader.IsDBNull(6) ? "Veiculo excluido" : reader.GetString(6); // veiculos.tipo
                    string modelo = reader.IsDBNull(7) ? "Veiculo excluido" : reader.GetString(7); // veiculos.modelo
                    string motorista = reader.IsDBNull(8) ? "Sem condutor" : reader.GetString(8); // motoristas.nome

                    // Datas e horários com DateTime?
                    // Datas com DateTime
                    DateTime? dataEntrada = reader.IsDBNull(1) ? (DateTime?) null : reader.GetDateTime(1);
                    DateTime? dataSaida = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);

                    // Horários com TimeSpan
                    TimeSpan? horarioEntrada = reader.IsDBNull(2) ? (TimeSpan?)null : reader.GetTimeSpan(2);
                    TimeSpan? horarioSaida = reader.IsDBNull(4) ? (TimeSpan?)null : reader.GetTimeSpan(4);

                    // Adicionar ao DataGridView sem conversões
                    gridEntradaSaida.Rows.Add(
                        id,
                        placa,
                        tipo,
                        modelo,
                        motorista,
                        dataEntrada,     // Adiciona o valor DateTime? diretamente
                        horarioEntrada,  // Adiciona o valor DateTime? diretamente
                        dataSaida,       // Adiciona o valor DateTime? diretamente
                        horarioSaida     // Adiciona o valor DateTime? diretamente
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

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisar.Text))
            {

                CarregarTodos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridEntradaSaida.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um item para excluir.");
                return;
            }

            var itemSelecionado = gridEntradaSaida.SelectedRows[0];
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

    }
}
