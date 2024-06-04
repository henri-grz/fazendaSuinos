using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fazendaSuinos
{
    public partial class FormMedicacao : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;
        public FormMedicacao()
        {
            InitializeComponent();

            SuspendLayout();
            panelFornecimento.Visible = false;
            panelConsumo.Visible = true;
            ResumeLayout();

            LoadDataGridConsumo();
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
            LoadDataGridFornecimento();
            ResumeLayout();
        }

        private void FormMedicacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazendaSuinosDataSet.Controle_Vacinacao'. Você pode movê-la ou removê-la conforme necessário.
            this.controle_VacinacaoTableAdapter.Fill(this.fazendaSuinosDataSet.Controle_Vacinacao);
            this.fornecimentoMedicamentoTableAdapter.Fill(this.fazendaSuinosDataSet.FornecimentoMedicamento);

        }


        //FORMULARIO CONSUMO

        private void txtCodConsumo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodConsumo.Text == "")
            {
                btnIncluir.Visible = true;
                btnGravar.Visible = false;
            }
            else
            {
                btnIncluir.Visible = false;
                btnGravar.Visible = true;
            }
        }

        private void btnConsultarCodigoLote_Click(object sender, EventArgs e)
        {
            FormMedicacao_LoteCarencia formAux = new FormMedicacao_LoteCarencia(this);
            formAux.LoadLote();
            formAux.setVisiblepcbMedicamentos(false);
            formAux.setVisibledataGridLote(true);
            formAux.setVisibledataGridProduto(false);
            formAux.setVisibledataGridFornecedor(false);
            formAux.ShowDialog();
        }

        private void btnConsultarCarencia_Click(object sender, EventArgs e)
        {
            FormMedicacao_LoteCarencia formAux = new FormMedicacao_LoteCarencia(this);
            formAux.setVisiblepcbMedicamentos(true);
            formAux.setVisibledataGridLote(false);
            formAux.setVisibledataGridProduto(false);
            formAux.setVisibledataGridFornecedor(false);
            formAux.ShowDialog();
        }

        
        //FORMULARIO FORNECIMENTO

        private void btnConsultarLoteForn_Click(object sender, EventArgs e)
        {
            FormMedicacao_LoteCarencia formAux = new FormMedicacao_LoteCarencia(this);
            formAux.LoadLote();
            formAux.setVisiblepcbMedicamentos(false);
            formAux.setVisibledataGridLote(true);
            formAux.setVisibledataGridProduto(false);
            formAux.setVisibledataGridFornecedor(false);
            formAux.ShowDialog();
        }

        private void btnConsultarProdutoForn_Click(object sender, EventArgs e)
        {
            FormMedicacao_LoteCarencia formAux = new FormMedicacao_LoteCarencia(this);
            formAux.LoadProduto();
            formAux.setVisiblepcbMedicamentos(false);
            formAux.setVisibledataGridLote(false);
            formAux.setVisibledataGridProduto(true);
            formAux.setVisibledataGridFornecedor(false);
            formAux.ShowDialog();
        }

        private void btnConsultarFornecedorForn_Click(object sender, EventArgs e)
        {
            FormMedicacao_LoteCarencia formAux = new FormMedicacao_LoteCarencia(this);
            formAux.LoadFornecedor();
            formAux.setVisiblepcbMedicamentos(false);
            formAux.setVisibledataGridLote(false);
            formAux.setVisibledataGridProduto(false);
            formAux.setVisibledataGridFornecedor(true);
            formAux.ShowDialog();
        }


        //CONSUMO

        private void LoadDataGridConsumo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string querySelecao = "SELECT * FROM Controle_Vacinacao";

                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, connectionString);

                    // Cria um DataTable para armazenar os resultados
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os resultados da consulta
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridConsumo.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (dataGridConsumo.Columns["Editar"] == null)
            {
                // Define a coluna de Editar
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Editar";
                btnColumn.HeaderText = "";
                btnColumn.Text = "Editar";
                btnColumn.Width = 80;
                btnColumn.UseColumnTextForButtonValue = true;

                dataGridConsumo.Columns.Add(btnColumn);
            }
            if (dataGridConsumo.Columns["Excluir"] == null)
            {
                // Define a coluna de Excluir
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Excluir";
                btnColumn.HeaderText = "";
                btnColumn.Text = "Excluir";
                btnColumn.Width = 80;
                btnColumn.UseColumnTextForButtonValue = true;

                dataGridConsumo.Columns.Add(btnColumn);
            }
        }

        private void dataGridConsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridConsumo.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                //Exibe mensagem de confirmação da exclusão
                DialogResult result = MessageBox.Show("Confirma a exclusão do registro?.", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    int codConsumo = Convert.ToInt32(dataGridConsumo.Rows[e.RowIndex].Cells[0].Value);

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string queryExclusao = "DELETE FROM Controle_Vacinacao WHERE CodPrescricao = " + codConsumo;

                            SqlCommand command = new SqlCommand(queryExclusao, connection);

                            // Executa o comando SQL
                            command.ExecuteNonQuery();

                            MessageBox.Show("Exclusão feita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadDataGridConsumo();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            if (e.ColumnIndex == dataGridConsumo.Columns["Editar"].Index && e.RowIndex >= 0)
            {

                /*label8.Visible = true;
                txtCodMortalidade.Visible = true;
                btnSalvar.Visible = true;
                btn.Visible = false;*/

                int codConsumo = Convert.ToInt32(dataGridConsumo.Rows[e.RowIndex].Cells[0].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string queryConsulta = "SELECT * FROM Controle_Vacinacao WHERE CodPrescricao = " + codConsumo;

                        SqlCommand command = new SqlCommand(queryConsulta, connection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCodConsumo.Text = reader["CodPrescricao"].ToString();
                                txtMedicamento.Text = reader["Medicacao"].ToString();
                                txtQntVac.Text = reader["Quantidade"].ToString();
                                txtCodigoLote.Text = reader["CodLote"].ToString();
                                dtpVacinacao.Text = Convert.ToDateTime(reader["Data_Inicial"]).ToString("dd/MM/yyyy");
                                txtDiasUso.Text = reader["Dias_Uso"].ToString();
                                txtDiasCarencia.Text = reader["Dias_Carencia"].ToString();
                                txtObservacao.Text = reader["Observacao"].ToString();
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

        //INCLUIR CONSUMO

        private void SalvarDados()
        {
            try
            {
                // Verificação e obtenção dos valores dos controles
                if (string.IsNullOrWhiteSpace(txtMedicamento.Text))
                {
                    MessageBox.Show("O campo de medicação não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string medicacao = txtMedicamento.Text;

                if (!int.TryParse(txtQntVac.Text, out int quantidade))
                {
                    MessageBox.Show("Quantidade de vacinados inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime dataInicial = dtpVacinacao.Value;

                if (!int.TryParse(txtDiasUso.Text, out int diasUso))
                {
                    MessageBox.Show("Dias de uso inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtDiasCarencia.Text, out int diasCarencia))
                {
                    MessageBox.Show("Dias de carência inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string observacao = txtObservacao.Text;

                if (!int.TryParse(txtCodigoLote.Text, out int codLote))
                {
                    MessageBox.Show("Código do lote inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = @"
                        INSERT INTO Controle_Vacinacao 
                        (Medicacao, Quantidade, Data_Inicial, Dias_Uso, Dias_Carencia, Observacao, CodLote) 
                        VALUES 
                        (@Medicacao, @Quantidade, @Data_Inicial, @Dias_Uso, @Dias_Carencia, @Observacao, @CodLote)";

                    SqlCommand command = new SqlCommand(queryInsercao, connection);

                    // Adiciona os parâmetros ao comando SQL
                    command.Parameters.AddWithValue("@Medicacao", medicacao);
                    command.Parameters.AddWithValue("@Quantidade", quantidade);
                    command.Parameters.AddWithValue("@Data_Inicial", dataInicial);
                    command.Parameters.AddWithValue("@Dias_Uso", diasUso);
                    command.Parameters.AddWithValue("@Dias_Carencia", diasCarencia);
                    command.Parameters.AddWithValue("@Observacao", observacao);
                    command.Parameters.AddWithValue("@CodLote", codLote);

                    // Executa o comando SQL
                    command.ExecuteNonQuery();

                    LoadDataGridConsumo();
                    limparCamposConsumo();

                    MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        //GRAVAR CONSUMO

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodConsumo.Text))
            {
                MessageBox.Show("O código de consumo não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtém os valores dos controles e faz as verificações necessárias
                if (!int.TryParse(txtCodConsumo.Text, out int codConsumo))
                {
                    MessageBox.Show("Código de consumo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string medicamento = txtMedicamento.Text;

                if (!int.TryParse(txtQntVac.Text, out int quantVac))
                {
                    MessageBox.Show("Quantidade de vacinados inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCodigoLote.Text, out int codLote))
                {
                    MessageBox.Show("Código do lote inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime data = dtpVacinacao.Value;

                if (!int.TryParse(txtDiasUso.Text, out int diasUso))
                {
                    MessageBox.Show("Dias de uso inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtDiasCarencia.Text, out int diasCarencia))
                {
                    MessageBox.Show("Dias de carência inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string observas = txtObservacao.Text;

                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para atualizar os dados na tabela
                    string queryAtualizacao = @"
                        UPDATE Controle_Vacinacao 
                        SET Medicacao = @Medicamento, 
                            Quantidade = @quantVac,
                            Data_Inicial = @DataInicial,
                            Dias_Uso = @DiasUso,
                            Dias_Carencia = @DiasCarencia,
                            Observacao = @Observas,
                            CodLote = @CodLote
                        WHERE CodPrescricao = @CodConsumo";

                    SqlCommand command = new SqlCommand(queryAtualizacao, connection);

                    // Adiciona os parâmetros ao comando SQL
                    command.Parameters.AddWithValue("@Medicamento", medicamento);
                    command.Parameters.AddWithValue("@quantVac", quantVac);
                    command.Parameters.AddWithValue("@DataInicial", data);
                    command.Parameters.AddWithValue("@DiasUso", diasUso);
                    command.Parameters.AddWithValue("@DiasCarencia", diasCarencia);
                    command.Parameters.AddWithValue("@Observas", observas);
                    command.Parameters.AddWithValue("@CodLote", codLote);
                    command.Parameters.AddWithValue("@CodConsumo", codConsumo);

                    // Executa o comando SQL
                    command.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDataGridConsumo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //LIMPAR CONSUMO

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCamposConsumo();
        }

        private void limparCamposConsumo()
        {
            txtCodConsumo.Clear();
            txtMedicamento.Text = "";
            txtQntVac.Clear();
            txtCodigoLote.Clear();
            txtDiasUso.Clear();
            txtDiasCarencia.Clear();
            txtObservacao.Clear();
        }

        //FORNECIMENTO

        private void txtCodFornecimento_TextChanged(object sender, EventArgs e)
        {
            if (txtCodFornecimento.Text == "")
            {
                btnIncluirForn.Visible = true;
                btnSalvarForn.Visible = false;
            }
            else
            {
                btnIncluirForn.Visible = false;
                btnSalvarForn.Visible = true;
            }
        }

        private void LoadDataGridFornecimento()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string querySelecao = "SELECT * FROM FornecimentoMedicamento";

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

                            string queryExclusao = "DELETE FROM FornecimentoMedicamento WHERE CodFornecimentoMedicamento = " + codFornecimento;

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

                        string queryConsulta = "SELECT * FROM FornecimentoMedicamento WHERE CodFornecimentoMedicamento = " + codFornecimento;

                        SqlCommand command = new SqlCommand(queryConsulta, connection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCodFornecimento.Text = reader["CodFornecimentoMedicamento"].ToString();
                                dtpFornMed.Text = Convert.ToDateTime(reader["DataForn"]).ToString("dd/MM/yyyy");
                                txtCodigoProdFMed.Text = reader["CodProduto"].ToString();
                                txtCodigoloteFMed.Text = reader["CodLote"].ToString();
                                txtProdutoMed.Text = reader["NomeProduto"].ToString();
                                txtCategoriaMed.Text = reader["Categoria"].ToString();
                                txtTipoMed.Text = reader["Tipo"].ToString();
                                dtpValidadeMed.Text = Convert.ToDateTime(reader["Validade"]).ToString("dd/MM/yyyy");
                                txtQuantidadeMed.Text = reader["Quantidade"].ToString();
                                txtUnidadeMed.Text = reader["Unidade"].ToString();
                                txtCodFornecedorMed.Text = reader["CodFornecedor"].ToString();
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


        //INCLUIR FORNECIMENTO

        private void btnIncluirForn_Click(object sender, EventArgs e)
        {
            SalvarDadosFornMed();
        }

        private void SalvarDadosFornMed()
        {
            try
            {
                // Obtém os valores dos controles

                int CodLoteForn = Convert.ToInt32(txtCodigoloteFMed.Text);
                int CodProdForn = Convert.ToInt32(txtCodigoProdFMed.Text);
                int CodFornecedorProd = Convert.ToInt32(txtCodFornecedorMed.Text);

                DateTime DataForn = dtpFornMed.Value;
                string NomeProduto = txtProdutoMed.Text;
                string Categoria = txtCategoriaMed.Text;
                string TipoMed = txtTipoMed.Text;
                DateTime DataValidade = dtpValidadeMed.Value;
                double QuantMed = Convert.ToDouble(txtQuantidadeMed.Text);
                string UnidadeMed = txtUnidadeMed.Text;


                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = "INSERT INTO FornecimentoMedicamento (CodProduto, CodFornecedor, CodLote, DataForn, NomeProduto, Categoria, Tipo, Validade, Quantidade, Unidade) VALUES (@CodProduto, @CodFornecedor, @CodLote, @DataForn, @NomeProduto, @Categoria, @Tipo, @Validade, @Quantidade, @Unidade)";
                    SqlCommand command = new SqlCommand(queryInsercao, connection);

                    // Adiciona os parâmetros ao comando SQL

                    command.Parameters.AddWithValue("@CodLote", CodLoteForn);
                    command.Parameters.AddWithValue("@CodProduto", CodProdForn);
                    command.Parameters.AddWithValue("@CodFornecedor", CodFornecedorProd);

                    command.Parameters.AddWithValue("@DataForn", DataForn);
                    command.Parameters.AddWithValue("@NomeProduto", NomeProduto);
                    command.Parameters.AddWithValue("@Categoria", Categoria);
                    command.Parameters.AddWithValue("@Tipo", TipoMed);
                    command.Parameters.AddWithValue("@Validade", DataValidade);
                    command.Parameters.AddWithValue("@Quantidade", QuantMed);
                    command.Parameters.AddWithValue("@Unidade", UnidadeMed);


                    // Executa o comando SQL
                    command.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDataGridFornecimento();
                    limparCamposFornecimento();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //GRAVAR FORNECIMENTO

        private void btnSalvarFornMed_Click(object sender, EventArgs e)
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
                    DateTime dataForn = dtpFornMed.Value;
                    string nomeProduto = txtProdutoMed.Text;
                    string categoria = txtCategoriaMed.Text;
                    string tipo = txtTipoMed.Text;
                    DateTime dataValidade = dtpValidadeMed.Value;
                    double quant = Convert.ToDouble(txtQuantidadeMed.Text);
                    string unidade = txtUnidadeMed.Text;
                    int codFornecedor = Convert.ToInt32(txtCodFornecedorMed.Text);
                    int codProduto = Convert.ToInt32(txtCodigoProdFMed.Text);
                    int codLote = Convert.ToInt32(txtCodigoloteFMed.Text);

                    // Abre a conexão com o banco de dados
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Cria o comando SQL para inserir os dados na tabela
                        string queryAtualizacao = @"
                            UPDATE FornecimentoMedicamento 
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
                            WHERE CodFornecimentoMedicamento = @CodFornecimento";

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

        //LIMPAR FORNECIMENTO
        private void btnLimparcampos_Click(object sender, EventArgs e)
        {
            limparCamposFornecimento();
        }

        private void limparCamposFornecimento()
        {
            txtCodFornecimento.Clear();
            txtCodigoloteFMed.Clear();
            txtCategoriaMed.Clear();
            txtCodFornecedorMed.Clear();
            txtCodigoProdFMed.Clear();
            txtQuantidadeMed.Clear();
            txtUnidadeMed.Clear();
            txtTipoMed.Clear();
            txtProdutoMed.Clear();
        }


        //GETTERS AND SETTERS

        public void setCodigoLote(String codigo)
        {
            txtCodigoLote.Text = codigo;
            txtCodigoloteFMed.Text = codigo;
        }

        public void setCodigoProduto(String codigo)
        {
            txtCodigoProdFMed.Text = codigo;
        }

        public void setCodigoFornecedor(String codigo)
        {
            txtCodFornecedorMed.Text = codigo;
        }

        
    }
}
