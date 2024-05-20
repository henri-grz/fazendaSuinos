using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fazendaSuinos
{
    public partial class FormAgendaDetalhes : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;

        public FormAgendaDetalhes(string codAgenda, string CodAtividade)
        {
            InitializeComponent();
            LoadForm(codAgenda, CodAtividade);
        }

        private void LoadForm(string codAgenda, string codAtividade)
        {
            try
            {
                using(DatabaseConnection connection = new DatabaseConnection(connectionString))
                {
                    connection.Open();

                    //Preenche campos do Agendamento
                    string queryAgenda = "SELECT * FROM AGENDA WHERE CodAtividade = " + codAgenda;
                    string tipoAtividade = "";

                    using(SqlCommand command = connection.CreateCommand(queryAgenda))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                campoCodAgendamento.Text = reader["CodAtividade"].ToString();
                                campoDataAgendamento.Text = Convert.ToDateTime(reader["DataAtividade"]).ToString("dd/MM/yyyy");
                                campoAtividade.Text = reader["Atividade"].ToString();
                                checkBoxFinalizada.Checked = (bool) reader["Finalizada"];

                                tipoAtividade = reader["Atividade"].ToString();
                                Console.WriteLine(tipoAtividade);
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro encontrado");
                            }
                        }
                    }

                    //Preenche campos da Atividade
                    string queryAtividade = "";

                    if (tipoAtividade == "Vacinação")
                    {
                        queryAtividade = "SELECT * FROM Controle_Vacinacao WHERE CodPrescricao = " + codAtividade;

                        using (SqlCommand command = connection.CreateCommand(queryAtividade))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    campoCodAtividade.Text = codAtividade.ToString();
                                    campoCodigoLote.Text = reader["CodLote"].ToString();
                                    campoMedicacao.Text = reader["Medicacao"].ToString();
                                    campoDiasUso.Text = reader["Dias_Uso"].ToString();
                                    campoCarencia.Text = reader["Dias_Carencia"].ToString();
                                    campoObservacao.Text = reader["Observacao"].ToString();

                                }
                                else
                                {
                                    MessageBox.Show("Nenhum registro encontrado");
                                }
                            }
                        }
                    }
                    else if(tipoAtividade == "Mortalidade")
                    {
                        queryAtividade = "SELECT * FROM Controle_Mortalidade WHERE CodMortalidade = " + codAtividade;

                        using (SqlCommand command = connection.CreateCommand(queryAtividade))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    campoCodAtividade.Text = codAtividade.ToString();
                                    campoCodigoLote.Text = reader["CodLote"].ToString();
                                    campoCausaMorte.Text = reader["Causa_Mortis"].ToString();
                                    campoSexo.Text = reader["Sexo"].ToString();
                                    campoMossa.Text = reader["Mossa"].ToString();
                                    campoPeso.Text = reader["Peso"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum registro encontrado");
                                }
                            }
                        }
                    }


                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar dados." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
