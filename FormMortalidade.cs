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
using FontAwesome.Sharp;



namespace fazendaSuinos
{
    public partial class FormMortalidade : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;

        public FormMortalidade()
        {
            InitializeComponent();

            panel1.Visible = false;

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
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar objeto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void SalvarDados()
        {
            try
            {
                // Obtém os valores dos controles
                DateTime Data = dateTimePickerData.Value;
                double Peso = Convert.ToDouble(txtPeso.Text);                
                int CodLote = Convert.ToInt32(txtCodigoLote.Text);
                int Mossa = Convert.ToInt32(txtMossa.Text);
                string Sexo = comboBoxSexo.SelectedItem.ToString();
                string Causa_Mortis = textBoxCausa.Text;

                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = "INSERT INTO Controle_Mortalidade (Data, Peso, Mossa, CodLote, Sexo, Causa_Mortis) VALUES (@Data, @Peso, @Mossa, @CodLote, @Sexo, @Causa_Mortis)";
                    SqlCommand command = new SqlCommand(queryInsercao, connection);

                    // Adiciona os parâmetros ao comando SQL
                    command.Parameters.AddWithValue("@Data", Data);
                    command.Parameters.AddWithValue("@Peso", Peso);
                    command.Parameters.AddWithValue("@Mossa", Mossa);
                    command.Parameters.AddWithValue("@CodLote", CodLote);
                    command.Parameters.AddWithValue("@Sexo", Sexo);
                    command.Parameters.AddWithValue("@Causa_Mortis", Causa_Mortis);

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
            LoadLote();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }
    
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoLote.Clear();
            txtMossa.Clear();
            txtPeso.Clear();           

        }

        private void FormMortalidade_Load(object sender, EventArgs e)
        {

        }

        private void txtMossa_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoLote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
