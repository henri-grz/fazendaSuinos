using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace fazendaSuinos
{
    public partial class FormDashboard : Form
    {

        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;
        public FormDashboard()
        {
            InitializeComponent();
            fillComboCodLote();
            fillComboCodProp();
            fillComboLoteCons();
            InitializeDataGridView();

            LoadAgenda();
        }

        private void btnAtualizarAgenda_Click(object sender, EventArgs e)
        {
            // Confirma as alterações feitas no DataGridView antes de atualizar a agenda
            dataGridAgenda.EndEdit();
            atualizarAgenda();
            LoadAgenda();
        }

        private void atualizarAgenda()
        {
            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Inserir dados de Controle_Mortalidade na Agenda, apenas se ainda não existem
                    string queryMortalidade = @"
                        INSERT INTO Agenda (Atividade, DataAtividade, CodMortalidade, CodLote)
                        SELECT 'Mortalidade', Data, CodMortalidade, CodLote
                        FROM Controle_Mortalidade
                        WHERE CodMortalidade NOT IN (SELECT CodMortalidade FROM Agenda WHERE CodMortalidade IS NOT NULL)";
                    using (SqlCommand command = connection.CreateCommand(queryMortalidade))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Inserir dados de Controle_Vacinacao na Agenda, apenas se ainda não existem
                    string queryVacinacao = @"
                        INSERT INTO Agenda (Atividade, DataAtividade, CodVacinacao, CodLote)
                        SELECT 'Vacinação', Data_Inicial, CodPrescricao, CodLote
                        FROM Controle_Vacinacao
                        WHERE CodPrescricao NOT IN (SELECT CodVacinacao FROM Agenda WHERE CodVacinacao IS NOT NULL)";
                    using (SqlCommand command = connection.CreateCommand(queryVacinacao))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Inserir dados de Controle_Vacinacao na Agenda, apenas se ainda não existem
                    string queryVisita = @"
                        INSERT INTO Agenda (Atividade, DataAtividade, CodVisita)
                        SELECT 'Visita', Data, CodVisita
                        FROM Visita
                        WHERE CodVisita NOT IN (SELECT CodVisita FROM Agenda WHERE CodVisita IS NOT NULL)";
                    using (SqlCommand command = connection.CreateCommand(queryVisita))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Inserir dados de Consumo_Racao na Agenda, apenas se ainda não existem
                    string queryRacao = @"
                        INSERT INTO Agenda (Atividade, DataAtividade, CodRacao, CodLote)
                        SELECT 'Alimentação', Data, CodConsumo, CodLote
                        FROM Consumo_Racao
                        WHERE CodConsumo NOT IN (SELECT CodRacao FROM Agenda WHERE CodRacao IS NOT NULL)";
                    using (SqlCommand command = connection.CreateCommand(queryRacao))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Agenda atualizada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar agenda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //LoadAgenda();
        }

        public void LoadAgenda()
        {
            // Remove todas as linhas, exceto a primeira (que contém os headers)
            while (dataGridAgenda.Rows.Count > 0)
            {
                dataGridAgenda.Rows.RemoveAt(0);
            }

            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string querySelecao = "SELECT * FROM Agenda WHERE Oculto = 0";

                    // Cria um adaptador de dados para executar a query
                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, connectionString);

                    // Cria um DataTable para armazenar os resultados
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os resultados da consulta
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridAgenda.DataSource = dataTable;

                    foreach (DataGridViewColumn column in dataGridAgenda.Columns)
                    {
                        column.ReadOnly = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar objeto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Define a coluna de status como editável
            dataGridAgenda.Columns[0].ReadOnly = false;

            // Define o foco para a célula desejada
            if (dataGridAgenda.Rows.Count > 1)
            {
                dataGridAgenda.CurrentCell = null; // Foca na célula da primeira coluna na segunda linha
            }
        }


        private void InitializeDataGridView()
        {
            dataGridAgenda.CellValueChanged += new DataGridViewCellEventHandler(dataGridAgenda_CellValueChanged);
            dataGridAgenda.CurrentCellDirtyStateChanged += new EventHandler(dataGridAgenda_CurrentCellDirtyStateChanged);
            dataGridAgenda.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridAgenda_DataBindingComplete);
        }

        private void dataGridAgenda_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Define o foco para a célula desejada após atualizar a agenda
            if (dataGridAgenda.Rows.Count > 1)
            {
                dataGridAgenda.CurrentCell = null; // Foca na célula da primeira coluna na segunda linha
            }
        }

        //Verifica marcação dos Check Boxes

        private void dataGridAgenda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se a célula alterada é uma célula de checkbox
            if (e.ColumnIndex == dataGridAgenda.Columns[0].Index && e.RowIndex >= 0)
            {
                // Obtenha o valor do checkbox
                bool isChecked = (bool)dataGridAgenda.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Obtenha o código da atividade
                int codAtividade = (int)dataGridAgenda.Rows[e.RowIndex].Cells[1].Value;

                // Atualize a tabela de Agenda com o novo status
                using (DatabaseConnection connection = new DatabaseConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string queryAtualizacao = "UPDATE Agenda SET Finalizada = @Finalizada WHERE CodAtividade = @CodAtividade";

                        using (SqlCommand command = connection.CreateCommand(queryAtualizacao))
                        {
                            command.Parameters.AddWithValue("@Finalizada", isChecked);
                            command.Parameters.AddWithValue("@CodAtividade", codAtividade);
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar status: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Console.WriteLine("Atividade setada como " + (isChecked ? "Finalizada" : "Não Finalizada"));
            }
        }

        // Este método é necessário para garantir que a alteração do checkbox seja registrada imediatamente
        private void dataGridAgenda_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridAgenda.IsCurrentCellDirty)
            {
                dataGridAgenda.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }


        //DETALHES DA AGENDA

        private void dataGridAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string codAgenda = dataGridAgenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                string codAtividade = "";

                if (dataGridAgenda.Rows[e.RowIndex].Cells[6].Value != DBNull.Value)
                {
                    codAtividade = dataGridAgenda.Rows[e.RowIndex].Cells[6].Value.ToString();
                    Console.WriteLine(codAtividade);
                }
                else if (dataGridAgenda.Rows[e.RowIndex].Cells[4].Value != DBNull.Value)
                {
                    codAtividade = dataGridAgenda.Rows[e.RowIndex].Cells[4].Value.ToString();
                    Console.WriteLine(codAtividade);
                }
                else if (dataGridAgenda.Rows[e.RowIndex].Cells[7].Value != DBNull.Value)
                {
                    codAtividade = dataGridAgenda.Rows[e.RowIndex].Cells[7].Value.ToString();
                    Console.WriteLine(codAtividade);
                }
                else if (dataGridAgenda.Rows[e.RowIndex].Cells[5].Value != DBNull.Value)
                {
                    codAtividade = dataGridAgenda.Rows[e.RowIndex].Cells[5].Value.ToString();
                    Console.WriteLine(codAtividade);
                }
                else
                {
                    // Caso nenhuma das condições anteriores seja satisfeita, você pode tratar o caso aqui.
                    MessageBox.Show("Nenhuma atividade encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FormAgendaDetalhes formAux = new FormAgendaDetalhes(codAgenda, codAtividade);
                formAux.ShowDialog();
            }
        }


        //DETALHES DO LOTE

        private void fillComboCodLote()
        {
            String query = "SELECT CodLote FROM Lote";
            comboCodLote_Det.Items.Clear();

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
                                comboCodLote_Det.Items.Add(reader["CodLote"].ToString());
                                Console.WriteLine("Codigos encontrados " + comboCodLote_Det.Items);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ler códigos: " + ex.Message);
                }
            }
        }

        private void comboCodLote_Det_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLoteFields();
        }

        private void fillLoteFields()
        {
            string codigoLote = comboCodLote_Det.Text;

            string query = "SELECT * FROM Lote WHERE CodLote = " + codigoLote;

            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection.GetConnection()))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                campoDetQuant.Text = reader["Quantidade"].ToString();
                                campoDetPesoTotal.Text = reader["Peso_Total"].ToString();
                                campoDetPesoMedio.Text = reader["Peso_Medio"].ToString();
                                campoDetSituacao.Text = reader["Situacao"].ToString();
                                campoDetDataAloj.Text = Convert.ToDateTime(reader["Data_Alojamento"]).ToString("dd/MM/yyyy");
                                campoDetDataCarreg.Text = Convert.ToDateTime(reader["Estimativa_Carregamento"]).ToString("dd/MM/yyyy");
                                campoDetCodGerente.Text = reader["CodGerente"].ToString();
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
                    MessageBox.Show("Erro ao consultar dados" + ex.Message);
                }
            }
        }


        //DETALHES DA PROPRIEDADE
        private void fillComboCodProp()
        {
            String query = "SELECT CodPropriedade FROM Propriedade";
            comboCodProp.Items.Clear();

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
                                comboCodProp.Items.Add(reader["CodPropriedade"].ToString());
                                Console.WriteLine("Codigos encontrados " + comboCodProp.Items);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ler códigos: " + ex.Message);
                }
            }
        }

        private void fillPropFields()
        {
            string codigoProp = comboCodProp.Text;

            // Obtém nome da propriedade e código do produtor
            string query = "SELECT * FROM Propriedade WHERE CodPropriedade = " + codigoProp;
            int codProdutor = 0;
            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection.GetConnection()))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                campoNomeProp.Text = reader["Nome"].ToString();
                                codProdutor = Convert.ToInt32(reader["CodProdutor"].ToString());
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
                    MessageBox.Show("Erro ao consultar dados" + ex.Message);
                }
            }

            // Através do código do produtor, consulta seu nome
            string queryProdutor = "SELECT Nome FROM Produtor WHERE CodProdutor = " + codProdutor;
            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryProdutor, connection.GetConnection()))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                campoNomeProd.Text = reader["Nome"].ToString();
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
                    MessageBox.Show("Erro ao consultar dados" + ex.Message);
                }
            }

            // Consulta quantidade de pocilgas, lotes e lotes abertos contidos na propriedade
            string queryPocilgas = "SELECT COUNT(*) FROM Pocilga WHERE CodPropriedade = @codigoProp";
            string queryLotes = @"
                SELECT COUNT(*)
                FROM LotePocilga lp
                JOIN Lote l ON lp.CodLote = l.CodLote
                WHERE lp.CodPocilga IN (SELECT CodPocilga FROM Pocilga WHERE CodPropriedade = @codigoProp)";
            string queryLotesAbertos = @"
                SELECT COUNT(*)
                FROM LotePocilga lp
                JOIN Lote l ON lp.CodLote = l.CodLote
                WHERE lp.CodPocilga IN (SELECT CodPocilga FROM Pocilga WHERE CodPropriedade = @codigoProp) AND l.Situacao = 'Aberto'";
            string queryQuantidadeSuinos = @"
                SELECT SUM(l.Quantidade)
                FROM LotePocilga lp
                JOIN Lote l ON lp.CodLote = l.CodLote
                WHERE lp.CodPocilga IN (SELECT CodPocilga FROM Pocilga WHERE CodPropriedade = @codigoProp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Contar Pocilgas
                    using (SqlCommand command = new SqlCommand(queryPocilgas, connection))
                    {
                        command.Parameters.AddWithValue("@codigoProp", codigoProp);
                        int countPocilgas = (int)command.ExecuteScalar();
                        campoPocilgas.Text = countPocilgas.ToString();
                    }

                    // Contar Lotes
                    using (SqlCommand command = new SqlCommand(queryLotes, connection))
                    {
                        command.Parameters.AddWithValue("@codigoProp", codigoProp);
                        int countLotes = (int)command.ExecuteScalar();
                        campoLotes.Text = countLotes.ToString();
                    }

                    // Contar Lotes com Situação "Aberto"
                    using (SqlCommand command = new SqlCommand(queryLotesAbertos, connection))
                    {
                        command.Parameters.AddWithValue("@codigoProp", codigoProp);
                        int countLotesAbertos = (int)command.ExecuteScalar();
                        campoLotesAbertos.Text = countLotesAbertos.ToString();
                    }

                    // Somar Quantidade de Suínos
                    using (SqlCommand command = new SqlCommand(queryQuantidadeSuinos, connection))
                    {
                        command.Parameters.AddWithValue("@codigoProp", codigoProp);
                        object result = command.ExecuteScalar();
                        int quantidadeSuinos = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        campoQuant.Text = quantidadeSuinos.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar dados: " + ex.Message);
                }
            }
        }

        private void comboCodProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPropFields();
        }


        //CONSUMO RACAO

        private void fillComboLoteCons()
        {
            String query = "SELECT CodLote FROM Lote";
            comboLoteCons.Items.Clear();

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
                                comboLoteCons.Items.Add(reader["CodLote"].ToString());
                                Console.WriteLine("Codigos encontrados " + comboLoteCons.Items);
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

        private void geraGrafico()
        {
            chartConsumo.Series.Clear();
            chartConsumo.Titles.Clear();
            chartConsumo.Legends.Clear();
            chartConsumo.ChartAreas.Clear();

            // Configurações do gráfico
            //chartConsumo.Titles.Add("Gráfico de Consumo");
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
            int codLote = Convert.ToInt32(comboLoteCons.Text);
            int intervaloDias = calcularIntervaloDias(codLote);

            try
            {
                // Obtém os dados do banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Dia_Ciclo, Quantidade_Consumo FROM Consumo_Racao WHERE CodLote = @CodLote ORDER BY Dia_Ciclo";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@CodLote", Convert.ToInt32(comboLoteCons.Text));

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

        private void comboLoteCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            geraGrafico();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazendaSuinosDataSet.Agenda'. Você pode movê-la ou removê-la conforme necessário.
            this.agendaTableAdapter.Fill(this.fazendaSuinosDataSet.Agenda);
            dataGridAgenda.ContextMenuStrip = contextMenuStripAgenda;

        }

        private void ocultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dataGridAgenda.SelectedRows.Count);

            if (dataGridAgenda.CurrentCell != null && dataGridAgenda.CurrentCell.RowIndex >= 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Agenda SET Oculto = 1 WHERE CodAtividade = @Id";

                        foreach (DataGridViewRow row in dataGridAgenda.SelectedRows)
                        {
                            int id = (int)row.Cells[1].Value;

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@Id", id);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected == 0)
                                {
                                    MessageBox.Show("Erro ao ocultar o registro com ID: " + id + ". Registro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        MessageBox.Show("Registros ocultados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Atualize o DataGridView para refletir a mudança
                        LoadAgenda();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ocultar o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para ocultar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            FormAgendaTodos formAux = new FormAgendaTodos(this);
            formAux.ShowDialog();
        }
    }
}
