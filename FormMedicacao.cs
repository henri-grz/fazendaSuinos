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

        private void SalvarDados()
        {
            try
            {
                // Obtém os valores dos controles
                string Medicacao = txtMedicamento.SelectedItem.ToString();
                int Quantidade = Convert.ToInt32(txtQntVac.Text);
                DateTime Data_Inicial = dtpVacinacao.Value;
                int Dias_Uso = Convert.ToInt32(txtDiasUso.Text);
                int Dias_Carencia = Convert.ToInt32(txtDiasCarencia.Text);
                string Observacao = txtObservacao.Text;
                int CodLote = Convert.ToInt32(txtCodigoLote.Text);

                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = "INSERT INTO Controle_Vacinacao (Medicacao,Quantidade,Data_Inicial,Dias_Uso,Dias_Carencia,Observacao,CodLote) VALUES (@Medicacao,@Quantidade,@Data_Inicial,@Dias_Uso,@Dias_Carencia,@Observacao,@CodLote)";
                    SqlCommand command = new SqlCommand(queryInsercao, connection);

                    // Adiciona os parâmetros ao comando SQL
                    command.Parameters.AddWithValue("@Medicacao", Medicacao);
                    command.Parameters.AddWithValue("@Quantidade", Quantidade);
                    command.Parameters.AddWithValue("@Data_Inicial", Data_Inicial);
                    command.Parameters.AddWithValue("@Dias_Uso", Dias_Uso);
                    command.Parameters.AddWithValue("@Dias_Carencia", Dias_Carencia);
                    command.Parameters.AddWithValue("@Observacao", Observacao);
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void btnLimparcampos_Click(object sender, EventArgs e)
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

        private void FormMedicacao_Load(object sender, EventArgs e)
        {
            this.fornecimentoMedicamentoTableAdapter.Fill(this.fazendaSuinosDataSet.FornecimentoMedicamento);

        }

        private void dataGridFornecimento_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridFornecimento.Columns[0].HeaderText = "Cód.";
            dataGridFornecimento.Columns[0].Width = 60;
            dataGridFornecimento.Columns[1].HeaderText = "Data";
            dataGridFornecimento.Columns[2].HeaderText = "Produto";
            dataGridFornecimento.Columns[6].HeaderText = "Quant.";
            dataGridFornecimento.Columns[6].Width = 80;
            dataGridFornecimento.Columns[7].HeaderText = "Un.";
            dataGridFornecimento.Columns[7].Width = 50;
            dataGridFornecimento.Columns[8].HeaderText = "Lote";
            dataGridFornecimento.Columns[8].Width = 60;

            dataGridFornecimento.Columns[9].Visible = false;
            dataGridFornecimento.Columns[10].Visible = false;

        }

        private void btnIncluirForn_Click(object sender, EventArgs e)
        {
            SalvarDadosFornMed();
        }

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
    }
}
