using System;
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
            LoadAgenda();
        }

        public void LoadAgenda()
        {
            // Define a coluna de Check
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Status";
            checkColumn.HeaderText = "Status";
            checkColumn.Width = 80;
            checkColumn.FillWeight = 10;

            dataGridAgenda.Columns.Add(checkColumn);

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar objeto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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
                                campoDetDataAloj.Text = reader["Data_Alojamento"].ToString();
                                campoDetDataCarreg.Text = reader["Estimativa_Carregamento"].ToString();
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

        }

        private void btnAtualizarAgenda_Click(object sender, EventArgs e)
        {
            atualizarAgenda();
        }

        private void atualizarAgenda()
        {
            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Limpar a tabela Agenda antes de atualizar (opcional)
                    string queryLimparAgenda = "DELETE FROM Agenda";
                    using (SqlCommand command = connection.CreateCommand(queryLimparAgenda))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Inserir dados de Controle_Mortalidade na Agenda
                    string queryMortalidade = @"
                        INSERT INTO Agenda (Atividade, DataAtividade, CodMortalidade, CodLote)
                        SELECT 'Mortalidade', Data, CodMortalidade, CodLote
                        FROM Controle_Mortalidade";
                    using (SqlCommand command = connection.CreateCommand(queryMortalidade))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Inserir dados de Controle_Vacinacao na Agenda
                    string queryVacinacao = @"
                        INSERT INTO Agenda (Atividade, DataAtividade, CodVacinacao, CodLote)
                        SELECT 'Vacinação', Data_Inicial, CodPrescricao, CodLote
                        FROM Controle_Vacinacao";
                    using (SqlCommand command = connection.CreateCommand(queryVacinacao))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Inserir dados de Consumo_Racao na Agenda
                    /*string queryRacao = @"
                        INSERT INTO Agenda (Atividade, DataAtividade, CodRacao, CodLote)
                        SELECT 'Consumo de Ração', DataConsumo, CodConsumo, CodLote
                        FROM Consumo_Racao";
                    using (SqlCommand command = new SqlCommand(queryRacao, connection))
                    {
                        command.ExecuteNonQuery();
                    }*/

                    MessageBox.Show("Agenda atualizada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar agenda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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
    }
}
