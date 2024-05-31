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
            txtCodigoloteFMed.Clear();
            txtCategoriaMed.Clear();
            txtCodFornecedorMed.Clear();
            txtCodigoProdFMed.Clear();
            txtQuantidadeMed.Clear();
            txtUnidadeMed.Clear();
            txtTipoMed.Clear();
            txtProdutoMed.Clear();
        }


    }
}
