using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace fazendaSuinos
{
    public partial class FormMortalidade : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;

        public FormMortalidade()
        {
            SuspendLayout();
            InitializeComponent();
            loadDataGridMortalidade();
            dataGridMortalidade.CellContentClick += new DataGridViewCellEventHandler(dataGridMortalidade_CellContentClick);
            ResumeLayout();
        }

        private void loadDataGridMortalidade()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string querySelecao = "SELECT * FROM Controle_Mortalidade";

                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, connectionString);

                    // Cria um DataTable para armazenar os resultados
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os resultados da consulta
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridMortalidade.DataSource = dataTable;

                    dataGridMortalidade.Columns["CodMortalidade"].HeaderText = "Cód. Mortalidade";

                    dataGridMortalidade.Columns["Causa_Mortis"].HeaderText = "Causa";

                    dataGridMortalidade.Columns["CodLote"].HeaderText = "Cód. Lote";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (dataGridMortalidade.Columns["Editar"] == null)
            {
                // Define a coluna de Editar
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Editar";
                btnColumn.HeaderText = "";
                btnColumn.Text = "Editar";
                btnColumn.UseColumnTextForButtonValue = true;

                dataGridMortalidade.Columns.Add(btnColumn);
            }
            if (dataGridMortalidade.Columns["Excluir"] == null)
            {
                // Define a coluna de Excluir
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Excluir";
                btnColumn.HeaderText = "";
                btnColumn.Text = "Excluir";
                btnColumn.UseColumnTextForButtonValue = true;

                dataGridMortalidade.Columns.Add(btnColumn);
            }


        }
        private void SalvarDados()
        {
            try
            {
                // Verificação e obtenção dos valores dos controles
                DateTime data = dateTimePickerData.Value;

                if (!double.TryParse(txtPeso.Text, out double peso))
                {
                    MessageBox.Show("Peso inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCodigoLote.Text, out int codLote))
                {
                    MessageBox.Show("Código do lote inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtMossa.Text, out int mossa))
                {
                    MessageBox.Show("Mossa inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxSexo.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxSexo.SelectedItem.ToString()))
                {
                    MessageBox.Show("Sexo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string sexo = comboBoxSexo.SelectedItem.ToString();

                if (comboBoxCausa.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxCausa.SelectedItem.ToString()))
                {
                    MessageBox.Show("Causa Mortis inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string causaMortis = comboBoxCausa.SelectedItem.ToString();

                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = @"
                        INSERT INTO Controle_Mortalidade 
                        (Data, Peso, Mossa, CodLote, Sexo, Causa_Mortis) 
                        VALUES 
                        (@Data, @Peso, @Mossa, @CodLote, @Sexo, @Causa_Mortis)";

                    using (SqlCommand command = new SqlCommand(queryInsercao, connection))
                    {
                        // Adiciona os parâmetros ao comando SQL
                        command.Parameters.AddWithValue("@Data", data);
                        command.Parameters.AddWithValue("@Peso", peso);
                        command.Parameters.AddWithValue("@Mossa", mossa);
                        command.Parameters.AddWithValue("@CodLote", codLote);
                        command.Parameters.AddWithValue("@Sexo", sexo);
                        command.Parameters.AddWithValue("@Causa_Mortis", causaMortis);

                        // Executa o comando SQL
                        command.ExecuteNonQuery();

                        MessageBox.Show("Dados incluídos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarCodigoLote_Click(object sender, EventArgs e)
        {
            FormMortalidade_LoteMossa formAux = new FormMortalidade_LoteMossa(this);
            formAux.LoadLote();
            formAux.setVisibleimgMossa(false);
            formAux.setVisibledataGridLote(true);
            formAux.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
            atualizaDataGrid();
            txtCodigoLote.Clear();
            txtMossa.Clear();
            txtPeso.Clear();
        }

        public void setCodigoLote(String codigo)
        {
            txtCodigoLote.Text = codigo;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            txtCodMortalidade.Visible = false;

            txtCodigoLote.Clear();
            txtMossa.Clear();
            txtPeso.Clear();
        }

        private void btnConsultarMossa_Click(object sender, EventArgs e)
        {
            FormMortalidade_LoteMossa formAux = new FormMortalidade_LoteMossa(this);
            formAux.setVisibleimgMossa(true);
            formAux.setVisibledataGridLote(false);
            formAux.ShowDialog();
        }

        private void FormMortalidade_Load(object sender, EventArgs e)
        {

        }

        private void atualizaDataGrid()
        {
            loadDataGridMortalidade();
        }

        private void dataGridMortalidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridMortalidade.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                //Exibe mensagem de confirmação da exclusão
                DialogResult result = MessageBox.Show("Confirma a exclusão do registro?.", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    int codMortalidade = Convert.ToInt32(dataGridMortalidade.Rows[e.RowIndex].Cells["CodMortalidade"].Value);

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string queryExclusao = "DELETE FROM Agenda WHERE CodMortalidade = " + codMortalidade + " DELETE FROM Controle_Mortalidade WHERE CodMortalidade = " + codMortalidade;

                            SqlCommand command = new SqlCommand(queryExclusao, connection);

                            // Executa o comando SQL
                            command.ExecuteNonQuery();

                            MessageBox.Show("Exclusão feita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            atualizaDataGrid();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            if (e.ColumnIndex == dataGridMortalidade.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                label8.Visible = true;
                txtCodMortalidade.Visible = true;
                btnGravar.Visible = true;
                btnIncluir.Visible = false;

                int codMortalidade = Convert.ToInt32(dataGridMortalidade.Rows[e.RowIndex].Cells["CodMortalidade"].Value);
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string queryConsulta = "SELECT * FROM Controle_Mortalidade WHERE CodMortalidade = " + codMortalidade;

                        SqlCommand command = new SqlCommand(queryConsulta, connection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCodMortalidade.Text = reader["CodMortalidade"].ToString();
                                dateTimePickerData.Text = Convert.ToDateTime(reader["Data"]).ToString("dd/MM/yyyy");
                                comboBoxSexo.SelectedItem = reader["Sexo"].ToString();
                                txtCodigoLote.Text = reader["CodLote"].ToString();
                                txtPeso.Text = reader["Peso"].ToString();
                                comboBoxCausa.SelectedItem = reader["Causa_Mortis"].ToString();
                                txtMossa.Text = reader["Mossa"].ToString();
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            txtCodMortalidade.Visible = false;
            btnGravar.Visible = false;
            btnIncluir.Visible = true;

            if (string.IsNullOrWhiteSpace(txtCodMortalidade.Text))
            {
                MessageBox.Show("O código de mortalidade não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Verificação e obtenção dos valores dos controles
                if (!int.TryParse(txtCodMortalidade.Text, out int codMortalidade))
                {
                    MessageBox.Show("Código de mortalidade inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtPeso.Text, out double peso))
                {
                    MessageBox.Show("Peso inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCodigoLote.Text, out int codLote))
                {
                    MessageBox.Show("Código do lote inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxSexo.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxSexo.SelectedItem.ToString()))
                {
                    MessageBox.Show("Sexo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                char sexo = Convert.ToChar(comboBoxSexo.SelectedItem.ToString());

                if (comboBoxCausa.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxCausa.SelectedItem.ToString()))
                {
                    MessageBox.Show("Causa Mortis inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string causaMortis = comboBoxCausa.SelectedItem.ToString();

                if (!int.TryParse(txtMossa.Text, out int mossa))
                {
                    MessageBox.Show("Mossa inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime data = dateTimePickerData.Value;

                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para atualizar os dados na tabela
                    string queryAtualizacao = @"
                        UPDATE Controle_Mortalidade 
                        SET Data = @Data, 
                            Sexo = @Sexo, 
                            Peso = @Peso, 
                            Causa_Mortis = @Causa_Mortis, 
                            Mossa = @Mossa, 
                            CodLote = @CodLote 
                        WHERE CodMortalidade = @CodMortalidade";

                    using (SqlCommand command = new SqlCommand(queryAtualizacao, connection))
                    {
                        // Adiciona os parâmetros ao comando SQL
                        command.Parameters.AddWithValue("@CodMortalidade", codMortalidade);
                        command.Parameters.AddWithValue("@Data", data);
                        command.Parameters.AddWithValue("@Sexo", sexo);
                        command.Parameters.AddWithValue("@Peso", peso);
                        command.Parameters.AddWithValue("@Causa_Mortis", causaMortis);
                        command.Parameters.AddWithValue("@Mossa", mossa);
                        command.Parameters.AddWithValue("@CodLote", codLote);

                        // Executa o comando SQL
                        command.ExecuteNonQuery();

                        MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        atualizaDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
