using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;

namespace fazendaSuinos
{
    public partial class FormConsumo_Racao : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;

        public FormConsumo_Racao()
        {
            InitializeComponent();
            fillComboCodLote();

            SuspendLayout();
            panelFornecimento.Visible = false;
            panelConsumo.Visible = true;
            ResumeLayout();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConsumo.Clear();
            txtCodigoLote.Clear();
            txtDiaCiclo.Clear();
        }

        private void SalvarDados()
        {
            try
            {
                // Obtém os valores dos controles
                DateTime Data = dateTimePickerData.Value;
                double QuantConsumo = Convert.ToDouble(txtConsumo.Text);
                int CodLote = Convert.ToInt32(txtCodigoLote.Text);
                int Dia_Ciclo = Convert.ToInt32(txtDiaCiclo.Text);

                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = "INSERT INTO Consumo_Racao (Data, Quantidade_Consumo, Dia_Ciclo, CodLote) VALUES (@Data, @QuantConsumo, @Dia_Ciclo, @CodLote)";
                    SqlCommand command = new SqlCommand(queryInsercao, connection);

                    // Adiciona os parâmetros ao comando SQL
                    command.Parameters.AddWithValue("@Data", Data);
                    command.Parameters.AddWithValue("@QuantConsumo", QuantConsumo);
                    command.Parameters.AddWithValue("@Dia_Ciclo", Dia_Ciclo);
                    command.Parameters.AddWithValue("@CodLote", CodLote);

                    // Executa o comando SQL
                    command.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerar_Grafico_Click(object sender, EventArgs e)
        {
            chartConsumo.Series.Clear();
            chartConsumo.Titles.Clear();
            chartConsumo.Legends.Clear();
            chartConsumo.ChartAreas.Clear();

            // Configurações do gráfico
            chartConsumo.Titles.Add("Gráfico de Consumo");
            var series = chartConsumo.Series.Add("Consumo por Dia");
            series.ChartType = SeriesChartType.Line;

            chartConsumo.Legends.Add("Legenda");
            chartConsumo.Legends[0].LegendStyle = LegendStyle.Table;
            chartConsumo.Legends[0].Docking = Docking.Bottom;
            chartConsumo.Legends[0].Alignment = StringAlignment.Center;
            chartConsumo.Legends[0].BorderColor = Color.Black;

            // Configurações da área do gráfico
            ChartArea chartArea = new ChartArea();
            chartConsumo.ChartAreas.Add(chartArea);

            chartArea.AxisX.Title = "Dias";
            chartArea.AxisY.Title = "Consumo (kg)";

            chartArea.AxisX.Minimum = 0;
            chartArea.AxisY.Minimum = 0;

            // Obtém o intervalo de dias do lote
            int codLote = Convert.ToInt32(comboLoteGrafico.Text);
            int intervaloDias = calcularIntervaloDias(codLote);

            try
            {
                // Obtém os dados do banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Dia_Ciclo, Quantidade_Consumo FROM Consumo_Racao WHERE CodLote = @CodLote ORDER BY Dia_Ciclo";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@CodLote", Convert.ToInt32(comboLoteGrafico.Text));

                    SqlDataReader reader = command.ExecuteReader();

                    int maxDia = 0;
                    while (reader.Read())
                    {
                        int dia = reader.GetInt32(0);
                        double consumo = reader.GetDouble(1);
                        series.Points.AddXY(dia, consumo);

                        if (dia > maxDia)
                        {
                            maxDia = dia;
                        }
                    }

                    reader.Close();

                    // Configura o valor máximo do eixo X
                    chartArea.AxisX.Maximum = intervaloDias;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar gráfico.\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int calcularIntervaloDias(int codLote)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Data_Alojamento, Estimativa_Carregamento FROM Lote WHERE CodLote = @CodLote";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CodLote", codLote);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    DateTime dataAlojamento = reader.GetDateTime(0);
                    DateTime estimativaCarregamento = reader.GetDateTime(1);
                    reader.Close();
                    return (estimativaCarregamento - dataAlojamento).Days;
                }
                else
                {
                    reader.Close();
                    throw new Exception("Lote não encontrado.");
                }
            }
        }

        private void btnConsultarCodigoLote_Click(object sender, EventArgs e)
        {
            FormConsumo_Racao_Lote formAux = new FormConsumo_Racao_Lote(this);
            formAux.LoadLote();
            formAux.setVisibleDataGridLote(true);
            formAux.setVisibleDataGridFornecedor(false);
            formAux.setVisibleDataGridProduto(false);
            formAux.ShowDialog();
        }

        public void setCodigoLote(String codigo)
        {
            txtCodigoLote.Text = codigo;
            txtCodigoloteFRacao.Text = codigo;
        }

        internal void setCodigoFornecedor(string v)
        {
            txtCodFornecedorRacao.Text = v;
        }

        internal void setCodigoProduto(string v)
        {
            txtCodigoProdFRacao.Text = v;
        }

        private void fillComboCodLote()
        {
            String query = "SELECT CodLote FROM Lote";
            comboLoteGrafico.Items.Clear();

            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection.GetConnection()))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboLoteGrafico.Items.Add(reader["CodLote"].ToString());
                                Console.WriteLine("Codigos encontrados " + comboLoteGrafico.Items);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar lotes: " + ex.Message);
                }
            }
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            panelFornecimento.Visible = false;
            panelConsumo.Visible = true;
            ResumeLayout();
        }

        private void btnFornecimento_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            panelConsumo.Visible = false;
            panelFornecimento.Visible = true;
            ResumeLayout();
        }

        private void SalvarDadosFornRacao()
        {
            try
            {
                // Obtém os valores dos controles

                int CodLoteForn = Convert.ToInt32(txtCodigoloteFRacao.Text);
                int CodProdForn = Convert.ToInt32(txtCodigoProdFRacao.Text);
                int CodFornecedorProd = Convert.ToInt32(txtCodFornecedorRacao.Text);

                DateTime DataForn = dtpFornRacao.Value;
                string NomeProduto = txtProdutoRacao.Text;
                string Categoria = txtCategoriaRacao.Text;
                string TipoRacao = txtTipoRacao.Text;
                DateTime DataValidade = dtpValidadeRacao.Value;
                double QuantRacao = Convert.ToDouble(txtQuantidadeRacao.Text);
                string UnidadeRacao = txtUnidadeRacao.Text;


                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = "INSERT INTO FornecimentoRacao (CodProduto, CodFornecedor, CodLote, DataForn, NomeProduto, Categoria, Tipo, Validade, Quantidade, Unidade) VALUES (@CodProduto, @CodFornecedor, @CodLote, @DataForn, @NomeProduto, @Categoria, @Tipo, @Validade, @Quantidade, @Unidade)";
                    SqlCommand command = new SqlCommand(queryInsercao, connection);

                    // Adiciona os parâmetros ao comando SQL

                    command.Parameters.AddWithValue("@CodLote", CodLoteForn);
                    command.Parameters.AddWithValue("@CodProduto", CodProdForn);
                    command.Parameters.AddWithValue("@CodFornecedor", CodFornecedorProd);

                    command.Parameters.AddWithValue("@DataForn", DataForn);
                    command.Parameters.AddWithValue("@NomeProduto", NomeProduto);
                    command.Parameters.AddWithValue("@Categoria", Categoria);
                    command.Parameters.AddWithValue("@Tipo", TipoRacao);
                    command.Parameters.AddWithValue("@Validade", DataValidade);
                    command.Parameters.AddWithValue("@Quantidade", QuantRacao);
                    command.Parameters.AddWithValue("@Unidade", UnidadeRacao);


                    // Executa o comando SQL
                    command.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalvarFornRacao_Click(object sender, EventArgs e)
        {
            SalvarDadosFornRacao();
        }

        private void btnConsultarProdutoForn_Click(object sender, EventArgs e)
        {
            FormConsumo_Racao_Lote formAux = new FormConsumo_Racao_Lote(this);
            formAux.LoadProduto();
            formAux.setVisibleDataGridLote(false);
            formAux.setVisibleDataGridFornecedor(false);
            formAux.setVisibleDataGridProduto(true);
            formAux.ShowDialog();
        }
        private void btnConsultarFornecedorForn_Click_1(object sender, EventArgs e)
        {
            FormConsumo_Racao_Lote formAux = new FormConsumo_Racao_Lote(this);
            formAux.LoadFornecedor();
            formAux.setVisibleDataGridLote(false);
            formAux.setVisibleDataGridFornecedor(true);
            formAux.setVisibleDataGridProduto(false);
            formAux.ShowDialog();
        }


        private void btnConsultarLoteForn_Click(object sender, EventArgs e)
        {
            FormConsumo_Racao_Lote formAux = new FormConsumo_Racao_Lote(this);
            formAux.LoadLote();
            formAux.setVisibleDataGridLote(true);
            formAux.setVisibleDataGridFornecedor(false);
            formAux.setVisibleDataGridProduto(false);
            formAux.ShowDialog();
        }

        private void btnLimparcampos_Click(object sender, EventArgs e)
        {
            txtCodigoloteFRacao.Clear();
            txtCategoriaRacao.Clear();
            txtCodFornecedorRacao.Clear();
            txtCodigoProdFRacao.Clear();
            txtQuantidadeRacao.Clear();
            txtUnidadeRacao.Clear();
            txtTipoRacao.Clear();
            txtProdutoRacao.Clear();
        }

    }
}
