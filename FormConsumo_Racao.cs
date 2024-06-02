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

            LoadDataGridFornecimento();
        }

        private void FormConsumo_Racao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazendaSuinosDataSet.FornecimentoRacao'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecimentoRacaoTableAdapter.Fill(this.fazendaSuinosDataSet.FornecimentoRacao);

        }


        //FORMULARIO CONSUMO

        private void btnConsultarCodigoLote_Click(object sender, EventArgs e)
        {
            FormConsumo_Racao_Lote formAux = new FormConsumo_Racao_Lote(this);
            formAux.LoadLote();
            formAux.setVisibleDataGridLote(true);
            formAux.setVisibleDataGridFornecedor(false);
            formAux.setVisibleDataGridProduto(false);
            formAux.ShowDialog();
        }

        //INCLUIR

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
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

        //GRAVAR



        //LIMPAR

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConsumo.Clear();
            txtCodigoLote.Clear();
            txtDiaCiclo.Clear();
        }


        //GRAFICO CONSUMO

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


        //FORMULARIO FORNECIMENTO

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

        private void txtCodFornecimento_TextChanged(object sender, EventArgs e)
        {
            if (txtCodFornecimento.Text == "")
            {
                btnIncluirForn.Visible = true;
                btnGravarForn.Visible = false;
            }
            else
            {
                btnIncluirForn.Visible = false;
                btnGravarForn.Visible = true;
            }
        }


        //DATAGRID FORNECIMENTO
        private void LoadDataGridFornecimento()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string querySelecao = "SELECT * FROM FornecimentoRacao";

                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, connectionString);

                    // Cria um DataTable para armazenar os resultados
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os resultados da consulta
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridFornecimento.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (dataGridFornecimento.Columns["Editar"] == null)
            {
                // Define a coluna de Editar
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Editar";
                btnColumn.HeaderText = "";
                btnColumn.Text = "Editar";
                btnColumn.UseColumnTextForButtonValue = true;

                dataGridFornecimento.Columns.Add(btnColumn);
            }
            if (dataGridFornecimento.Columns["Excluir"] == null)
            {
                // Define a coluna de Excluir
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Excluir";
                btnColumn.HeaderText = "";
                btnColumn.Text = "Excluir";
                btnColumn.UseColumnTextForButtonValue = true;

                dataGridFornecimento.Columns.Add(btnColumn);
            }
        }

        private void dataGridFornecimento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridFornecimento.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                //Exibe mensagem de confirmação da exclusão
                DialogResult result = MessageBox.Show("Confirma a exclusão do registro?.", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    int codFornecimento = Convert.ToInt32(dataGridFornecimento.Rows[e.RowIndex].Cells[0].Value);

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string queryExclusao = "DELETE FROM FornecimentoRacao WHERE CodFornecimentoRacao = " + codFornecimento;

                            SqlCommand command = new SqlCommand(queryExclusao, connection);

                            // Executa o comando SQL
                            command.ExecuteNonQuery();

                            MessageBox.Show("Exclusão feita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadDataGridFornecimento();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            if (e.ColumnIndex == dataGridFornecimento.Columns["Editar"].Index && e.RowIndex >= 0)
            {

                /*label8.Visible = true;
                txtCodMortalidade.Visible = true;
                btnSalvar.Visible = true;
                btn.Visible = false;*/

                int codFornecimento = Convert.ToInt32(dataGridFornecimento.Rows[e.RowIndex].Cells[0].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string queryConsulta = "SELECT * FROM FornecimentoRacao WHERE CodFornecimentoRacao = " + codFornecimento;

                        SqlCommand command = new SqlCommand(queryConsulta, connection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCodFornecimento.Text = reader["CodFornecimentoRacao"].ToString();
                                dtpFornRacao.Text = Convert.ToDateTime(reader["DataForn"]).ToString("dd/MM/yyyy");
                                txtCodProdForn.Text = reader["CodProduto"].ToString();
                                txtCodLoteForn.Text = reader["CodLote"].ToString();
                                txtProdutoForn.Text = reader["NomeProduto"].ToString();
                                txtCategoriaForn.Text = reader["Categoria"].ToString();
                                txtTipoForn.Text = reader["Tipo"].ToString();
                                dtpValidadeForn.Text = Convert.ToDateTime(reader["Validade"]).ToString("dd/MM/yyyy");
                                txtQuantidadeForn.Text = reader["Quantidade"].ToString();
                                txtUnidadeForn.Text = reader["Unidade"].ToString();
                                txtCodFornecedorForn.Text = reader["CodFornecedor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro encontrado");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }


        //INCLUIR 

        private void SalvarDadosFornRacao()
        {
            try
            {
                // Obtém os valores dos controles

                int CodLoteForn = Convert.ToInt32(txtCodLoteForn.Text);
                int CodProdForn = Convert.ToInt32(txtCodProdForn.Text);
                int CodFornecedorProd = Convert.ToInt32(txtCodFornecedorForn.Text);

                DateTime DataForn = dtpFornRacao.Value;
                string NomeProduto = txtProdutoForn.Text;
                string Categoria = txtCategoriaForn.Text;
                string TipoRacao = txtTipoForn.Text;
                DateTime DataValidade = dtpValidadeForn.Value;
                double QuantRacao = Convert.ToDouble(txtQuantidadeForn.Text);
                string UnidadeRacao = txtUnidadeForn.Text;


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

                    LoadDataGridFornecimento();

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

        //GRAVAR

        private void btnGravarForn_Click(object sender, EventArgs e)
        {
            if (txtCodFornecimento.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    // Obtém os valores dos controles
                    int codFornecimento = Convert.ToInt32(txtCodFornecimento.Text);
                    DateTime dataForn = dtpFornRacao.Value;
                    string nomeProduto = txtProdutoForn.Text;
                    string categoria = txtCategoriaForn.Text;
                    string tipo = txtTipoForn.Text;
                    DateTime dataValidade = dtpValidadeForn.Value;
                    double quant = Convert.ToDouble(txtQuantidadeForn.Text);
                    string unidade = txtUnidadeForn.Text;
                    int codFornecedor = Convert.ToInt32(txtCodFornecedorForn.Text);
                    int codProduto = Convert.ToInt32(txtCodProdForn.Text);
                    int codLote = Convert.ToInt32(txtCodLoteForn.Text);

                    // Abre a conexão com o banco de dados
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Cria o comando SQL para inserir os dados na tabela
                        string queryAtualizacao = @"
                            UPDATE FornecimentoRacao
                            SET DataForn = @DataForn, 
                                CodProduto = @CodProduto,
                                CodLote = @CodLote,
                                NomeProduto = @NomeProduto,
                                Categoria = @Categoria,
                                Tipo = @Tipo,
                                Validade = @DataValidade,
                                Quantidade = @Quantidade,
                                Unidade = @Unidade,
                                CodFornecedor = @CodFornecedor
                            WHERE CodFornecimentoRacao = @CodFornecimento";

                        SqlCommand command = new SqlCommand(queryAtualizacao, connection);

                        // Adiciona os parâmetros ao comando SQL
                        command.Parameters.AddWithValue("@DataForn", dataForn);
                        command.Parameters.AddWithValue("@CodProduto", codProduto);
                        command.Parameters.AddWithValue("@CodLote", codLote);
                        command.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                        command.Parameters.AddWithValue("@Categoria", categoria);
                        command.Parameters.AddWithValue("@Tipo", tipo);
                        command.Parameters.AddWithValue("@DataValidade", dataValidade);
                        command.Parameters.AddWithValue("@Quantidade", quant);
                        command.Parameters.AddWithValue("@Unidade", unidade);
                        command.Parameters.AddWithValue("@CodFornecedor", codFornecedor);
                        command.Parameters.AddWithValue("@CodFornecimento", codFornecimento);

                        // Executa o comando SQL
                        command.ExecuteNonQuery();


                        MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataGridFornecimento();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //LIMPAR

        private void btnLimparcampos_Click(object sender, EventArgs e)
        {
            txtCodFornecimento.Clear();
            txtCodLoteForn.Clear();
            txtCategoriaForn.Clear();
            txtCodFornecedorForn.Clear();
            txtCodProdForn.Clear();
            txtQuantidadeForn.Clear();
            txtUnidadeForn.Clear();
            txtTipoForn.Clear();
            txtProdutoForn.Clear();
        }


        //GETTERS AND SETTERS

        public void setCodigoLote(String codigo)
        {
            txtCodigoLote.Text = codigo;
            txtCodLoteForn.Text = codigo;
        }

        internal void setCodigoFornecedor(string v)
        {
            txtCodFornecedorForn.Text = v;
        }

        internal void setCodigoProduto(string v)
        {
            txtCodProdForn.Text = v;
        }
    }
}
