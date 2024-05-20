using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fazendaSuinos
{
    public partial class FormDashboard : Form
    {

        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;
        public FormDashboard()
        {
            InitializeComponent();
            fillComboCodLote();
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

            if (dataGridAgenda.Columns["Status"] == null)
            {
                // Define a coluna de Check
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Status";
                checkColumn.HeaderText = "Status";
                checkColumn.Width = 80;
                checkColumn.FillWeight = 10;

                dataGridAgenda.Columns.Add(checkColumn);
            }

            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string querySelecao = "SELECT * FROM Agenda";

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
                        // Define a coluna de status como editável
                        column.ReadOnly = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar objeto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Define a coluna de status como editável
            dataGridAgenda.Columns["Status"].ReadOnly = false;

            // Define o foco para a célula desejada
            if (dataGridAgenda.Rows.Count > 1)
            {
                dataGridAgenda.CurrentCell = null; // Foca na célula da primeira coluna na segunda linha
            }

            sincronizaStatus();
        }

        private void sincronizaStatus()
        {
            // Configura as células de checkbox de acordo com o valor da coluna 'Finalizada'
            foreach (DataGridViewRow row in dataGridAgenda.Rows)
            {
                bool finalizada = (bool)row.Cells["Finalizada"].Value;
                row.Cells["Status"].Value = finalizada;
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
            // Renomeia a coluna de acordo com o nome desejado
            if (dataGridAgenda.Columns["DataAtividade"] != null)
            {
                dataGridAgenda.Columns["DataAtividade"].HeaderText = "Data";
                dataGridAgenda.Columns["DataAtividade"].Width = 100;
                dataGridAgenda.Columns["Status"].Width = 80;
            }
            if (dataGridAgenda.Columns["CodVacinacao"] != null)
            {
                dataGridAgenda.Columns["CodVacinacao"].HeaderText = "Contr. Vac.";
                dataGridAgenda.Columns["CodVacinacao"].Width = 40;
            }
            if (dataGridAgenda.Columns["CodAtividade"] != null)
            {
                dataGridAgenda.Columns["CodAtividade"].HeaderText = "Cód.";
                dataGridAgenda.Columns["CodAtividade"].Width = 45;
                dataGridAgenda.Columns["CodAtividade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataGridAgenda.Columns["CodRacao"] != null)
            {
                dataGridAgenda.Columns["CodRacao"].HeaderText = "Cons. Ração";
                dataGridAgenda.Columns["CodRacao"].Width = 40;
            }
            if (dataGridAgenda.Columns["CodMortalidade"] != null)
            {
                dataGridAgenda.Columns["CodMortalidade"].HeaderText = "Contr. Mort.";
                dataGridAgenda.Columns["CodMortalidade"].Width = 40;
            }
            if (dataGridAgenda.Columns["CodLote"] != null)
            {
                dataGridAgenda.Columns["CodLote"].HeaderText = "Lote";
                dataGridAgenda.Columns["CodLote"].Width = 80;
            }

            //Oculta colunas que não é para exibir
            dataGridAgenda.Columns["Finalizada"].Visible = false;
            dataGridAgenda.Columns["CodVacinacao"].Visible = false;
            dataGridAgenda.Columns["CodMortalidade"].Visible = false;
            dataGridAgenda.Columns["CodRacao"].Visible = false;
            dataGridAgenda.Columns["CodVisita"].Visible = false;

            // Define o foco para a célula desejada após atualizar a agenda
            if (dataGridAgenda.Rows.Count > 1)
            {
                dataGridAgenda.CurrentCell = null; // Foca na célula da primeira coluna na segunda linha
            }

            // Ordena pela coluna DataAtividade em ordem crescente
            dataGridAgenda.Sort(dataGridAgenda.Columns["DataAtividade"], ListSortDirection.Ascending);
        }

        //Verifica marcação dos Check Boxes

        private void dataGridAgenda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se a célula alterada é uma célula de checkbox
            if (e.ColumnIndex == dataGridAgenda.Columns["Status"].Index && e.RowIndex >= 0)
            {
                // Obtenha o valor do checkbox
                bool isChecked = (bool)dataGridAgenda.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Obtenha o código da atividade
                int codAtividade = (int)dataGridAgenda.Rows[e.RowIndex].Cells["CodAtividade"].Value;

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
                string codAgenda = dataGridAgenda.Rows[e.RowIndex].Cells["CodAtividade"].Value.ToString();
                string codAtividade = "";

                if (dataGridAgenda.Rows[e.RowIndex].Cells["CodMortalidade"].Value != DBNull.Value)
                {
                    codAtividade = dataGridAgenda.Rows[e.RowIndex].Cells["CodMortalidade"].Value.ToString();
                    Console.WriteLine(codAtividade);
                }
                else if (dataGridAgenda.Rows[e.RowIndex].Cells["CodVacinacao"].Value != DBNull.Value)
                {
                    codAtividade = dataGridAgenda.Rows[e.RowIndex].Cells["CodVacinacao"].Value.ToString();
                    Console.WriteLine(codAtividade);
                }
                else if (dataGridAgenda.Rows[e.RowIndex].Cells["CodVisita"].Value != DBNull.Value)
                {
                    codAtividade = dataGridAgenda.Rows[e.RowIndex].Cells["CodVisita"].Value.ToString();
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

        private void fillLoteFields(String Lote)
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

        private void comboCodLote_Det_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLoteFields(comboCodLote_Det.Text);
        }
    }
}
