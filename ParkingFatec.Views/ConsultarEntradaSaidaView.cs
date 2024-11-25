using MySql.Data.MySqlClient;
using ParkingFatec.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using GemBox.Document;
using GemBox.Document.Tables;
using System.Diagnostics;

namespace ParkingFatec.Views
{
    public partial class ConsultarEntradaSaidaView : Form
    {



        VeiculoDAO veiculos = new VeiculoDAO();
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
                    DateTime? dataEntrada = reader.IsDBNull(1) ? (DateTime?)null : reader.GetDateTime(1);
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

                    string query = "DELETE FROM registros WHERE id = @id";
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

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                // Exibe a caixa de diálogo para o usuário escolher o local de salvamento
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Salvar Relatório";
                saveFileDialog.FileName = "RelatorioEntradaSaida.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = saveFileDialog.FileName;

                    ComponentInfo.SetLicense("FREE-LIMITED-KEY");

                    var documento = new DocumentModel();

                    // Adicionando título
                    var tituloParagrafo = new Paragraph(documento, new Run(documento, "Relatório Entrada e Saída de Veículos"));
                    tituloParagrafo.ParagraphFormat.Alignment = GemBox.Document.HorizontalAlignment.Center;

                    var run = tituloParagrafo.Inlines[0] as Run;
                    run.CharacterFormat.Bold = true;
                    run.CharacterFormat.Size = 16;

                    documento.Sections.Add(new Section(documento, tituloParagrafo));

                    // Adicionando data de geração
                    documento.Sections.Add(new Section(documento,
                        new Paragraph(documento, $"Data de geração: {DateTime.Now:dd/MM/yyyy}\n\n")));

                    // Criando a tabela
                    var tabela = new Table(documento);
                    tabela.Rows.Add(
                        new TableRow(documento,
                            new TableCell(documento, "ID"),
                            new TableCell(documento, "Placa"),
                            new TableCell(documento, "Tipo"),
                            new TableCell(documento, "Modelo"),
                            new TableCell(documento, "Motorista"),
                            new TableCell(documento, "D. Entrada"),
                            new TableCell(documento, "H. Entrada"),
                            new TableCell(documento, "D. Saída"),
                            new TableCell(documento, "H. Saída")
                        )
                    );



                    // Adicionando os dados do DataGridView à tabela
                    foreach (DataGridViewRow row in gridEntradaSaida.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Verificando o conteúdo da linha
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                Debug.WriteLine($"Valor da célula {i}: {row.Cells[i].Value?.ToString() ?? "N/A"}");
                            }

                            tabela.Rows.Add(
                                new TableRow(documento,
                                    new TableCell(documento, row.Cells[0].Value?.ToString() ?? "N/A"),  // ID
                                    new TableCell(documento, row.Cells[1].Value?.ToString() ?? "N/A"),  // Placa
                                    new TableCell(documento, row.Cells[2].Value?.ToString() ?? "N/A"),  // Tipo
                                    new TableCell(documento, row.Cells[3].Value?.ToString() ?? "N/A"),  // Modelo
                                    new TableCell(documento, row.Cells[4].Value?.ToString() ?? "N/A"),  // Motorista
                                    new TableCell(documento, row.Cells[5].Value?.ToString() ?? "N/A"),  // Data Entrada
                                    new TableCell(documento, row.Cells[6].Value?.ToString() ?? "N/A"),  // Hora Entrada
                                    new TableCell(documento, row.Cells[7].Value?.ToString() ?? "N/A"),  // Data Saída
                                    new TableCell(documento, row.Cells[8].Value?.ToString() ?? "N/A")   // Horário Saída
                                )
                                        );
                        }
                    }
                    //new TableCell(documento, row.Cells["ID"].Value?.ToString() ?? "N/A"),  // ID

                    // Salva o documento no caminho escolhido pelo usuário
                    documento.Save(caminhoArquivo);
                    //MessageBox.Show($"Relatório gerado com sucesso: {caminhoArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
