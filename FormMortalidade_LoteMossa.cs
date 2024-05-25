using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fazendaSuinos
{
    public partial class FormMortalidade_LoteMossa : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;
        private FormMortalidade _parentForm;

        public FormMortalidade_LoteMossa(FormMortalidade parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        public FormMortalidade_LoteMossa(FormPeso_Medio formPeso_Medio)
        {
        }

        public void setVisibledataGridLote(bool b)
        {
            if (b)
            {
                dataGridViewLote.Visible = true;
            }
            else
            {
                dataGridViewLote.Visible = false;
            }
        }

        public void setVisibleimgMossa(bool b)
        {
            if (b)
            {
                imgMossa.Visible = true;
            }
            else
            {
                imgMossa.Visible = false;
            }
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

        private void FormMortalidade_LoteMossa_Load(object sender, EventArgs e)
        {

        }
    }
}
