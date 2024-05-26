﻿using System;
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
            LoadDataGridPesagem();
        }

        private void LoadDataGridPesagem()
        {
            if (dataGridPesoMedio.Columns["Editar"] == null)
            {
                // Define a coluna de Check
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Editar";
                btnColumn.HeaderText = "";
                btnColumn.Text = "Editar";
                btnColumn.UseColumnTextForButtonValue = true;

                dataGridPesoMedio.Columns.Add(btnColumn);
            }
            if (dataGridPesoMedio.Columns["Excluir"] == null)
            {
                // Define a coluna de Check
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Excluir";
                btnColumn.HeaderText = "";
                btnColumn.Text = "Excluir";
                btnColumn.UseColumnTextForButtonValue = true;

                dataGridPesoMedio.Columns.Add(btnColumn);
            }
        }

        private void SalvarDados()
        {
            try
            {
                // Obtém os valores dos controles
                DateTime Data = dateTimePickerData.Value;
                double PesoMedio = Convert.ToDouble(txtPesoMedio.Text);
                int CodLote = Convert.ToInt32(txtCodigoLote.Text);
                int DiaCiclo = Convert.ToInt32(txtDiaCiclo.Text);


                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Verifica se já existe um registro com o mesmo DiaCiclo e CodLote
                    string queryVerificacao = "SELECT COUNT(*) FROM Peso_Medio WHERE Dia_Ciclo = @DiaCiclo AND CodLote = @CodLote";

                    SqlCommand commandVerificacao = new SqlCommand(queryVerificacao, connection);

                    commandVerificacao.Parameters.AddWithValue("@DiaCiclo", DiaCiclo);
                    commandVerificacao.Parameters.AddWithValue("@CodLote", CodLote);
                    commandVerificacao.Parameters.AddWithValue("@Data", Data);

                    int count = (int)commandVerificacao.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Já existe um registro para este dia e lote.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = "INSERT INTO Peso_Medio (Data, PesoMedio, Dia_Ciclo, CodLote) VALUES (@Data, @PesoMedio, @DiaCiclo, @CodLote)";
                    SqlCommand command = new SqlCommand(queryInsercao, connection);

                    // Adiciona os parâmetros ao comando SQL
                    command.Parameters.AddWithValue("@Data", Data);
                    command.Parameters.AddWithValue("@PesoMedio", PesoMedio);
                    command.Parameters.AddWithValue("@DiaCiclo", DiaCiclo);
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

        private void btnConsultarCodigoLote_Click_1(object sender, EventArgs e)
        {
            FormPeso_Medio_Lote formAux = new FormPeso_Medio_Lote(this);
            formAux.LoadLote();
            formAux.ShowDialog();
        }

        public void setCodigoLote(String codigo)
        {
            txtCodigoLote.Text = codigo;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDiaCiclo.Clear();
            txtPesoMedio.Clear();
            txtCodigoLote.Clear();
            txtCodPesagem.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();

            txtCodigoLote.Text = "";
            txtPesoMedio.Text = "";
            txtDiaCiclo.Text = "";

            atualizaDataGrid();
        }

        private void atualizaDataGrid()
        {
            dataGridPesoMedio.Refresh();
            this.peso_MedioTableAdapter.Fill(this.fazendaSuinosDataSet.Peso_Medio);
        }

        private void FormPeso_Medio_Load(object sender, EventArgs e)
        {
            SuspendLayout();
            // TODO: esta linha de código carrega dados na tabela 'fazendaSuinosDataSet.Peso_Medio'. Você pode movê-la ou removê-la conforme necessário.
            this.peso_MedioTableAdapter.Fill(this.fazendaSuinosDataSet.Peso_Medio);
            ResumeLayout();

        }

        private void dataGridPesoMedio_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridPesoMedio.Columns[0].HeaderText = "Código";
            dataGridPesoMedio.Columns[0].Width = 80;

            dataGridPesoMedio.Columns[2].HeaderText = "Peso Médio";
            dataGridPesoMedio.Columns[3].HeaderText = "Dia do Ciclo";
            dataGridPesoMedio.Columns[4].HeaderText = "Código Lote";

        }

        private void txtCodPesagem_TextChanged(object sender, EventArgs e)
        {
            if (txtCodPesagem.Text != "")
            {
                btnIncluir.Visible = false;
                btnGravar.Visible = true;
            }
            if (txtCodPesagem.Text == "")
            {
                btnIncluir.Visible = true;
                btnGravar.Visible = false;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodPesagem.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    // Obtém os valores dos controles
                    int codPesagem = Convert.ToInt32(txtCodPesagem.Text);
                    double PesoMedio = Convert.ToDouble(txtPesoMedio.Text);
                    int codLote = Convert.ToInt32(txtCodigoLote.Text);
                    int diaCiclo = Convert.ToInt32(txtDiaCiclo.Text);
                    DateTime Data = dateTimePickerData.Value;

                    // Abre a conexão com o banco de dados
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Cria o comando SQL para inserir os dados na tabela
                        string queryInsercao = "UPDATE Peso_Medio SET Data=@Data, CodLote=@CodLote, PesoMedio=@PesoMedio, Dia_Ciclo=@DiaCiclo WHERE CodPeso_Medio=@CodPeso_Medio";
                        SqlCommand command = new SqlCommand(queryInsercao, connection);

                        // Adiciona os parâmetros ao comando SQL
                        command.Parameters.AddWithValue("@Data", Data);
                        command.Parameters.AddWithValue("@PesoMedio", PesoMedio);
                        command.Parameters.AddWithValue("@DiaCiclo", diaCiclo);
                        command.Parameters.AddWithValue("@CodLote", codLote);
                        command.Parameters.AddWithValue("@CodPeso_Medio", codPesagem);

                        // Executa o comando SQL
                        command.ExecuteNonQuery();

                        MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        atualizaDataGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridPesoMedio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridPesoMedio.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                //Exibe mensagem de confirmação da exclusão
                DialogResult result = MessageBox.Show("Confirma a exclusão do registro?.", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    int codPesagem = (int)dataGridPesoMedio.Rows[e.RowIndex].Cells[0].Value;

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string queryExclusao = "DELETE FROM Peso_Medio WHERE CodPeso_Medio = " + codPesagem;

                            SqlCommand command = new SqlCommand(queryExclusao, connection);

                            // Executa o comando SQL
                            command.ExecuteNonQuery();

                            MessageBox.Show("Exclusão feita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            atualizaDataGrid();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            if (e.ColumnIndex == dataGridPesoMedio.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                int codPesagem = (int)dataGridPesoMedio.Rows[e.RowIndex].Cells[0].Value;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string queryConsulta = "SELECT * FROM Peso_Medio WHERE CodPeso_Medio = " + codPesagem;

                        SqlCommand command = new SqlCommand(queryConsulta, connection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCodPesagem.Text = reader["CodPeso_Medio"].ToString();
                                dateTimePickerData.Text = Convert.ToDateTime(reader["Data"]).ToString("dd/MM/yyyy");
                                txtCodigoLote.Text = reader["CodLote"].ToString();
                                txtPesoMedio.Text = reader["PesoMedio"].ToString();
                                txtDiaCiclo.Text = reader["Dia_Ciclo"].ToString();
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
                    MessageBox.Show("Erro ao editar registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
