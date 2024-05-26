using fazendaSuinos.Relatorios;
using Microsoft.Reporting.WinForms;
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

        private void FormRelatorios_Load(object sender, EventArgs e)
        {
            try
            {
                // Verifica ou cria a pasta de relatórios (se necessário)
                RelatorioHelper.VerificarOuCriarPasta();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter as seleções do CheckedListBox
                var selecoes = ObterSelecoes();

                // Obter os dados baseados nas seleções
                var dados = ObterDadosBaseadosNasSelecoes(selecoes);

                // Abrir o formulário de visualização do relatório
                FormRelatorioEntidade formRelatorioViewer = new FormRelatorioEntidade(dados);
                formRelatorioViewer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> ObterSelecoes()
        {
            var selecoes = new List<string>();
            foreach (object item in clbSelecaoRelatorio.CheckedItems)
            {
                selecoes.Add(item.ToString());
            }
            return selecoes;
        }

        private Dictionary<string, List<object>> ObterDadosBaseadosNasSelecoes(List<string> selecoes)
        {
            var dados = new Dictionary<string, List<object>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (var selecao in selecoes)
                {
                    string query = string.Empty;
                    switch (selecao)
                    {
                        case "Administrador":
                            query = "SELECT Nome, CPF, Telefone FROM Administrador";
                            break;
                        case "Fornecedor":
                            query = "SELECT Razao_Social, CNPJ, Telefone, CEP FROM Fornecedor";
                            break;
                        case "Gerente":
                            query = "SELECT Nome, CPF, Telefone, Setor FROM Gerente";
                            break;
                        case "Produtor":
                            query = "SELECT Nome, CPF, Telefone, CEP FROM Produtor";
                            break;
                        case "Técnico":
                            query = "SELECT Nome, CPF, Telefone, Especialidade FROM Tecnico";
                            break;
                    }

                    if (!string.IsNullOrEmpty(query))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                var listaDados = new List<object>();
                                while (reader.Read())
                                {
                                    var dadosItem = new
                                    {
                                        Nome = reader.GetString(0),
                                        CPF = reader.GetString(1),
                                        Telefone = reader.GetString(2),
                                        CampoExtra1 = reader.FieldCount > 3 ? reader.GetString(3) : null,
                                        CampoExtra2 = reader.FieldCount > 4 ? reader.GetString(4) : null
                                    };
                                    listaDados.Add(dadosItem);
                                }
                                dados[selecao] = listaDados;
                            }
                        }
                    }
                }
            }

            return dados;
        }

        private void comboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbSelecaoRelatorio.Items.Clear();

            switch (comboModelo.SelectedIndex)
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
                                        string nomePropriedade = reader.GetString(1);
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
                    mostrarLotes();
                    break;
                case 4:
                    mostrarLotes();
                    break;
                case 5:
                    mostrarLotes();
                    break;
                case 6:
                    mostrarLotes();
                    break;
                case 7:
                    mostrarLotes();
                    break;
                case 8:
                    mostrarLotes();
                    break;
            }
        }

        private void mostrarLotes()
        {
            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string querySelecao = "SELECT * FROM Lote";

                    using (SqlCommand command = connection.CreateCommand(querySelecao))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Lê os nomes dos campos retornados pela consulta
                            while (reader.Read())
                            {
                                int codLote = reader.GetInt32(0);
                                clbSelecaoRelatorio.Items.Add(codLote);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar lotes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
