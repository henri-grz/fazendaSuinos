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
    public partial class FormMedicacao_LoteCarencia : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;
        private FormMedicacao _parentForm;

        public FormMedicacao_LoteCarencia(FormMedicacao parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        public void setVisiblepcbMedicamentos(bool b)
        {
            if(b)
            {
                pcbMeicamentos.Visible = true;
            }
            else
            {
                pcbMeicamentos.Visible = false;
            }
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
    }
}
