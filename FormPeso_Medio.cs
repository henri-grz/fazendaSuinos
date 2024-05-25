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
    public partial class FormPeso_Medio : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;

        public FormPeso_Medio()
        {
            InitializeComponent();

        }


        private void SalvarDados()
        {
            try
            {
                // Obtém os valores dos controles
                DateTime Data = dateTimePickerData.Value;
                double PesoMedio = Convert.ToDouble(txtPesoMedio.Text);
                int CodLote = Convert.ToInt32(txtCodigoLote.Text);
                int Semana = Convert.ToInt32(txtSemana.Text);
                

                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = "INSERT INTO Peso_Medio (Data, PesoMedio, Semana, CodLote) VALUES (@Data, @PesoMedio, @Semana, @CodLote)";
                    SqlCommand command = new SqlCommand(queryInsercao, connection);

                    // Adiciona os parâmetros ao comando SQL
                    command.Parameters.AddWithValue("@Data", Data);
                    command.Parameters.AddWithValue("@PesoMedio", PesoMedio);
                    command.Parameters.AddWithValue("@Semana", Semana);
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

        private void LoadLote()
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


        private void FormPeso_Medio_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarCodigoLote_Click_1(object sender, EventArgs e)
        {
            LoadLote();  
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSemana.Clear();
            txtPesoMedio.Clear();
            txtCodigoLote.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }
    }
}
