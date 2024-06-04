using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fazendaSuinos
{
    public partial class FormAgendaDetalhes : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;

        List<Panel> listaPanels = new List<Panel> {};

        string tipoAtividade = "";

        public FormAgendaDetalhes(string codAgenda, string CodAtividade)
        {
            InitializeComponent();

            listaPanels.Add(panelMedicacao);
            listaPanels.Add(panelVisita);
            listaPanels.Add(panelMortalidade);
            listaPanels.Add(panelAlimentacao);

            LoadForm(codAgenda, CodAtividade);

            //Seleciona o panel que ficará visível
            definePanelVisivel();

            // Ajusta o tamanho da Dialog após definir quais painéis estão visíveis
            ajustarTamanhoDialog();
        }

        private void definePanelVisivel()
        {
            foreach(Panel panel in listaPanels)
            {
                panel.Visible = false;
            }

            if (tipoAtividade == "Mortalidade")
            {
                panelMortalidade.Visible = true;
            }else if(tipoAtividade == "Vacinação")
            {
                panelMedicacao.Visible = true;
            }else if(tipoAtividade == "Visita")
            {
                panelVisita.Visible = true;
            }
            else if (tipoAtividade == "Alimentação")
            {
                panelAlimentacao.Visible = true;
            }
        }

        private void ajustarTamanhoDialog()
        {
            int larguraDialog = this.Width; // Pode ser fixo ou calculado conforme necessário
            int alturaNecessaria = 0;

            // Adiciona algum espaço extra para margens e padding
            alturaNecessaria += panelDetalhes.Height; // 50 é um valor arbitrário, ajuste conforme necessário

            if (tipoAtividade == "Mortalidade")
            {
                alturaNecessaria += panelMortalidade.Height;
            }
            else if (tipoAtividade == "Vacinação")
            {
                alturaNecessaria += panelMedicacao.Height;
            }
            else if (tipoAtividade == "Visita")
            {
                alturaNecessaria += panelVisita.Height;
            }
            else if (tipoAtividade == "Alimentação")
            {
                alturaNecessaria += panelAlimentacao.Height;
            }

            // Ajusta o tamanho da Dialog
            this.ClientSize = new System.Drawing.Size(larguraDialog, alturaNecessaria);
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
                    else if (tipoAtividade == "Visita")
                    {
                        queryAtividade = "SELECT * FROM Visita WHERE CodVisita = " + codAtividade;

                        using (SqlCommand command = connection.CreateCommand(queryAtividade))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    campoCodAtividade.Text = codAtividade.ToString();
                                    campoFinalidade.Text = reader["Finalidade"].ToString();
                                    campoCodUlt.Text = reader["Cod_Ult"].ToString();
                                    campoDataUlt.Text = Convert.ToDateTime(reader["Data_Ult"]).ToString("dd/MM/yyyy");
                                    campoVisitante.Text = reader["CodVisitante"].ToString();
                                    campoPocilga.Text = reader["CodPocilga"].ToString();
                                    campoObservacaoVisita.Text = reader["Observacoes"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum registro encontrado");
                                }
                            }
                        }
                    }
                    else if (tipoAtividade == "Alimentação")
                    {
                        queryAtividade = "SELECT * FROM Consumo_Racao WHERE CodConsumo = " + codAtividade;

                        using (SqlCommand command = connection.CreateCommand(queryAtividade))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    campoCodAtividade.Text = codAtividade.ToString();
                                    campoCodigoLote.Text = reader["CodLote"].ToString();
                                    campoDiaCiclo.Text = reader["Dia_Ciclo"].ToString();
                                    campoConsumo.Text = reader["Quantidade_Consumo"].ToString();
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
