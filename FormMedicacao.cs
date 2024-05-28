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
            formAux.ShowDialog();
        }

        public void setCodigoLote(String codigo)
        {
            txtCodigoLote.Text = codigo;
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

        private void FormMedicacao_Load(object sender, EventArgs e)
        {

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void btnSalvarFornMed_Click(object sender, EventArgs e)
        {
            SalvarDadosFornMed();
        }

        private void btnConsultarLoteForn_Click(object sender, EventArgs e)
        {
            FormMedicacao_LoteCarencia formAux = new FormMedicacao_LoteCarencia(this);
            formAux.LoadLote();
            formAux.setVisiblepcbMedicamentos(false);
            formAux.setVisibledataGridLote(true);
            formAux.ShowDialog();
        }

        private void btnConsultarProdutoForn_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodProduto, Nome, Categoria, Tipo, Validade FROM Produto";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewProdutos.DataSource = dataTable;
                    dataGridViewProdutos.CellClick += new DataGridViewCellEventHandler(dataGridViewProdutos_CellClick);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar produtos: " + ex.Message);
                }
            }
        }

        private void btnConsultarFornecedorForn_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodFornecedor, CNPJ, Razao_Social, CEP, Telefone FROM Fornecedor";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewFornecedor.DataSource = dataTable;
                    dataGridViewFornecedor.CellClick += new DataGridViewCellEventHandler(dataGridViewFornecedor_CellClick);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar produtos: " + ex.Message);
                }
            }
        }

        private void btnLimparcampos_Click(object sender, EventArgs e)
        {
            txtCodigoloteFMed.Clear();
            txtCategoriaMed.Clear();
            txtCodFornecedorMed.Clear();
            txtCodigoProdFMed.Clear();
            txtQuantidadeMed.Clear();
            txtUnidadeMed.Clear();
            txtTipoMed.Clear();
            txtProdutoMed.Clear();
        }

        private void dataGridViewFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewFornecedor.Rows[e.RowIndex];
                txtCodFornecedorMed.Text = row.Cells["CodFornecedor"].Value.ToString();

            }
        }

        private void dataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProdutos.Rows[e.RowIndex];
                txtCodigoProdFMed.Text = row.Cells["CodProduto"].Value.ToString();
                txtProdutoMed.Text = row.Cells["Nome"].Value.ToString();
                txtCategoriaMed.Text = row.Cells["Categoria"].Value.ToString();
                txtTipoMed.Text = row.Cells["Tipo"].Value.ToString();
                dtpValidadeMed.Value = Convert.ToDateTime(row.Cells["Validade"].Value);

            }
        }
    }
}
