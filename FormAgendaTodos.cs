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
    public partial class FormAgendaTodos : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;
        private FormDashboard _parentForm;

        public FormAgendaTodos(FormDashboard parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;

            dataGridAgenda.ContextMenuStrip = contextMenuStripVisivel;
        }

        public void LoadDataGrid()
        {
            dataGridAgenda.Refresh();
            this.agendaTableAdapter.Fill(this.fazendaSuinosDataSet.Agenda);
        }

        private void FormAgendaTodos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazendaSuinosDataSet.Agenda'. Você pode movê-la ou removê-la conforme necessário.
            this.agendaTableAdapter.Fill(this.fazendaSuinosDataSet.Agenda);

        }

        private void tornarVisívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridAgenda.CurrentCell != null && dataGridAgenda.CurrentCell.RowIndex >= 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Agenda SET Oculto = 0 WHERE CodAtividade = @Id";

                        foreach (DataGridViewRow row in dataGridAgenda.SelectedRows)
                        {
                            int id = (int)row.Cells[1].Value;

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@Id", id);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected == 0)
                                {
                                    MessageBox.Show("Erro ao modificar o registro com ID: " + id + ". Registro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        MessageBox.Show("Registros ocultados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Atualize o DataGridView para refletir a mudança
                        LoadDataGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao modificar registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para tornar visível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAgendaTodos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.LoadAgenda();
        }
    }
}
