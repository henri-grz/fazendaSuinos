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
            FormMortalidade_LoteMossa formAux = new FormMortalidade_LoteMossa(this);
            formAux.LoadLote();
            formAux.setVisibleimgMossa(false);
            formAux.setVisibledataGridLote(true);
            formAux.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        public void setCodigoLote(String codigo)
        {
            txtCodigoLote.Text = codigo;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoLote.Clear();
            txtMossa.Clear();
            txtPeso.Clear();           
        }

        private void btnConsultarMossa_Click(object sender, EventArgs e)
        {
            FormMortalidade_LoteMossa formAux = new FormMortalidade_LoteMossa(this);
            formAux.setVisibleimgMossa(true);
            formAux.setVisibledataGridLote(false);
            formAux.ShowDialog();
        }
    }
}
