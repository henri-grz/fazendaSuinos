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

namespace fazendaSuinos
{
    public partial class FormConsumo_Racao_Lote : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;
        private FormConsumo_Racao _parentForm;

        public FormConsumo_Racao_Lote(FormConsumo_Racao parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        public void LoadLote()
        {
            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string querySelecao = "SELECT * FROM Lote";

                    // Cria um adaptador de dados para executar a query
                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, connectionString);

                    // Cria um DataTable para armazenar os resultados
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os resultados da consulta
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridViewLote.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar objeto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridViewLote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object codigo = dataGridViewLote.Rows[e.RowIndex].Cells[0].Value;

            _parentForm.setCodigoLote(codigo.ToString());

            this.Close();
        }

        private void dataGridViewFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object codigo = dataGridViewFornecedor.Rows[e.RowIndex].Cells[0].Value;

            _parentForm.setCodigoFornecedor(codigo.ToString());

            this.Close();
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object codigo = dataGridViewProdutos.Rows[e.RowIndex].Cells[0].Value;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProdutos.Rows[e.RowIndex];
                _parentForm.txtCodigoProdFRacao.Text = row.Cells["CodProduto"].Value.ToString();
                _parentForm.txtProdutoRacao.Text = row.Cells["Nome"].Value.ToString();
                _parentForm.txtCategoriaRacao.Text = row.Cells["Categoria"].Value.ToString();
                _parentForm.txtTipoRacao.Text = row.Cells["Tipo"].Value.ToString();
                _parentForm.dtpValidadeRacao.Value = Convert.ToDateTime(row.Cells["Validade"].Value);

            }

            _parentForm.setCodigoProduto(codigo.ToString());

            this.Close();
        }

        internal void LoadProduto()
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar produtos: " + ex.Message);
                }
            }
        }

        internal void LoadFornecedor()
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar produtos: " + ex.Message);
                }
            }
        }

        internal void setVisibleDataGridLote(bool v)
        {
            if (v)
            {
                dataGridViewLote.Visible = true;
            }
            else
            {
                dataGridViewLote.Visible = false;
            }
        }

        internal void setVisibleDataGridFornecedor(bool v)
        {
            if (v)
            {
                dataGridViewFornecedor.Visible = true;
            }
            else
            {
                dataGridViewFornecedor.Visible = false;
            }
        }

        internal void setVisibleDataGridProduto(bool v)
        {
            if (v)
            {
                dataGridViewProdutos.Visible = true;
            }
            else
            {
                dataGridViewProdutos.Visible = false;
            }
        }
    }
}
