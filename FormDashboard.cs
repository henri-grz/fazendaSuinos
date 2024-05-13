using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazendaSuinos
{
    public partial class FormDashboard : Form
    {

        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;
        public FormDashboard()
        {
            InitializeComponent();
            fillComboCodLote();
        }

        private void fillComboCodLote()
        {
            String query = "SELECT CodLote FROM Lote";
            comboCodLote_Det.Items.Clear();

            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection.GetConnection()))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboCodLote_Det.Items.Add(reader["CodLote"].ToString());
                                Console.WriteLine("Codigos encontrados " + comboCodLote_Det.Items);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ler códigos: " + ex.Message);
                }
            }
        }

        private void fillLoteFields(String Lote)
        {
            string codigoLote = comboCodLote_Det.Text;

            string query ="SELECT * FROM Lote WHERE CodLote = " + codigoLote;

            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection.GetConnection()))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                campoDetQuant.Text = reader["Quantidade"].ToString();
                                campoDetPesoTotal.Text = reader["Peso_Total"].ToString();
                                campoDetPesoMedio.Text = reader["Peso_Medio"].ToString();
                                campoDetSituacao.Text = reader["Situacao"].ToString();
                                campoDetDataAloj.Text = reader["Data_Alojamento"].ToString();
                                campoDetDataCarreg.Text = reader["Estimativa_Carregamento"].ToString();
                                campoDetCodGerente.Text = reader["CodGerente"].ToString();
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
                    MessageBox.Show("Erro ao consultar dados" + ex.Message);
                }
            }
        }

        private void comboCodLote_Det_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLoteFields(comboCodLote_Det.Text);
        }
    }
}
