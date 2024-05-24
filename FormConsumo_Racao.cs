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
using System.Windows.Forms.DataVisualization.Charting;

namespace fazendaSuinos
{
    public partial class FormConsumo_Racao : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;

        public FormConsumo_Racao()
        {
            InitializeComponent();
        }

        private void FormConsumo_Racao_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConsumo.Clear();
            txtCodigoLote.Clear();
            txtSemana.Clear();
        }

        private void SalvarDados()
        {
            try
            {
                // Obtém os valores dos controles
                DateTime Data = dateTimePickerData.Value;
                double Consumo = Convert.ToDouble(txtConsumo.Text);
                int CodLote = Convert.ToInt32(txtCodigoLote.Text);
                int Semana = Convert.ToInt32(txtSemana.Text);

                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = "INSERT INTO Consumo_Racao (Data, Consumo, Semana, CodLote) VALUES (@Data, @Consumo, @Semana, @CodLote)";
                    SqlCommand command = new SqlCommand(queryInsercao, connection);

                    // Adiciona os parâmetros ao comando SQL
                    command.Parameters.AddWithValue("@Data", Data);
                    command.Parameters.AddWithValue("@Consumo", Consumo);
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

        

        private void btnGerar_Grafico_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            // Configurações do gráfico
            chart1.Titles.Add("Gráfico de Consumo");
            var series = chart1.Series.Add("Consumo por Semana");
            series.ChartType = SeriesChartType.Line;

            chart1.Legends.Add("Legenda");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].BorderColor = Color.Black;

            // Obtém os dados do banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Semana, Consumo FROM Consumo_Racao ORDER BY Semana";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int semana = reader.GetInt32(0);
                    double consumo = reader.GetDouble(1);
                    series.Points.AddXY(semana, consumo);
                }

                reader.Close();
            }
        }
    }
}
