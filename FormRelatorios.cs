using System;
using System.Collections;
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
    public partial class FormRelatorios : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;

        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void comboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboModelo.SelectedIndex)
            {
                case 0:
                    clbSelecaoRelatorio.Items.Add("Administrador");
                    clbSelecaoRelatorio.Items.Add("Fornecedor");
                    clbSelecaoRelatorio.Items.Add("Gerente");
                    clbSelecaoRelatorio.Items.Add("Produtor");
                    clbSelecaoRelatorio.Items.Add("Técnico");
                    clbSelecaoRelatorio.Items.Add("Visitante");
                    break;
                case 1:
                    clbSelecaoRelatorio.Items.Add("Propriedade");
                    clbSelecaoRelatorio.Items.Add("Pocilga");
                    clbSelecaoRelatorio.Items.Add("Lote");
                    clbSelecaoRelatorio.Items.Add("Visita");
                    clbSelecaoRelatorio.Items.Add("Produto");
                    break;
                case 2:
                    using (DatabaseConnection connection = new DatabaseConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string querySelecao = "SELECT * FROM Propriedade";

                            using (SqlCommand command = connection.CreateCommand(querySelecao))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    // Lê os nomes dos campos retornados pela consulta
                                    while (reader.Read())
                                    {
                                        string nomePropriedade = reader.GetString(0);
                                        clbSelecaoRelatorio.Items.Add(nomePropriedade);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao consultar propriedades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;

                case 7:

                    break;
                case 8:

                    break;
            }
        }

        private void btnSelecionarTodos_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            for (int i = 0; i < clbSelecaoRelatorio.Items.Count; i++)
            {
                clbSelecaoRelatorio.SetItemChecked(i, true);
            }
            ResumeLayout();
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            for (int i = 0; i < clbSelecaoRelatorio.Items.Count; i++)
            {
                clbSelecaoRelatorio.SetItemChecked(i, false);
            }
            ResumeLayout();
        }
    }
}
