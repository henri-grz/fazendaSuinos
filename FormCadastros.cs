using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fazendaSuinos
{
    public partial class FormCadastros : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;

        // Lista para armazenar os filtros
        private List<string[]> filtrosEnt = new List<string[]>();
        private List<string[]> filtrosFaz = new List<string[]>();
        private List<string[]> filtrosAco = new List<string[]>();

        private string entidadeSelecionada, fazendaSelecionada;

        private List<IconButton> tagsFiltrosEnt = new List<IconButton>();
        private List<IconButton> tagsFiltrosFaz = new List<IconButton>();
        private List<IconButton> tagsFiltrosAco = new List<IconButton>();

        private string[] listaTipoEntidade = { "Administrador", "Fornecedor", "Gerente", "Produtor", "Tecnico", "Visitante" };

        public FormCadastros()
        {
            InitializeComponent();

            SuspendLayout();
            //AJUSTA PANELS DE FILTRO
            panelFiltroFazenda.Visible = false;
            panelFiltroAcoes.Visible = false;
            panelFiltroEntidade.Visible = true;
            //AJUSTA CAMPOS DE CADASTRO
            panelCadastroFazenda.Visible = false;
            panelCadastroEntidade.Visible = true;
            ResumeLayout();

            //Lista das tags disponíveis para uso
            tagsFiltrosEnt.Add(btnFiltroEnt1);
            tagsFiltrosEnt.Add(btnFiltroEnt2);
            tagsFiltrosEnt.Add(btnFiltroEnt3);
            tagsFiltrosFaz.Add(btnFiltroFaz1);
            tagsFiltrosFaz.Add(btnFiltroFaz2);
            tagsFiltrosFaz.Add(btnFiltroFaz3);
            tagsFiltrosAco.Add(btnFiltroAco1);
            tagsFiltrosAco.Add(btnFiltroAco2);
            tagsFiltrosAco.Add(btnFiltroAco3);
        }

        //BOTOES SUPERIORES

        private void btnEntidades_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            //AJUSTA PANELS DE FILTRO
            panelFiltroFazenda.Visible = false;
            panelFiltroAcoes.Visible = false;
            panelFiltroEntidade.Visible = true;
            //AJUSTA CAMPOS DE CADASTRO
            panelCadastroFazenda.Visible = false;
            panelCadastroEntidade.Visible = true;
            ResumeLayout();
        }

        private void btnFazenda_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            //AJUSTA PANELS DE FILTRO
            panelFiltroAcoes.Visible = false;
            panelFiltroEntidade.Visible = false;
            panelFiltroFazenda.Visible = true;
            //AJUSTA CAMPOS DE CADASTRO
            panelCadastroEntidade.Visible = false;
            panelCadastroFazenda.Visible = true;
            ResumeLayout();

        }

        private void btnAcoesCorretivas_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            //AJUSTA PANELS DE FILTRO
            panelFiltroFazenda.Visible = false;
            panelFiltroEntidade.Visible = false;
            panelFiltroAcoes.Visible = true;
            //AJUSTA CAMPOS DE CADASTRO
            panelCadastroEntidade.Visible = false;
            panelCadastroFazenda.Visible = false;
            ResumeLayout();
        }

        //FILTROS
        private void btnAdicionarFiltroEntidade_Click(object sender, EventArgs e)
        {
            // Verifica se já existem 3 filtrosEnt adicionados
            if (filtrosEnt.Count >= 3)
            {
                MessageBox.Show("Você já adicionou o máximo de 3 filtros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Verifica se o campo Valor não está vazio
            if (campoValorEntidade.Text == "" || comboAtributoEntidade.SelectedItem == null)
            {
                MessageBox.Show("O valor do atributo e do filtro não podem ser nulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtém os valores selecionados na ComboBox e no TextBox
            string atributo = transformaItemParaCampo(comboAtributoEntidade.Text);
            string valor = campoValorEntidade.Text;

            // Adiciona o filtro à lista de filtrosEnt
            filtrosEnt.Add(new string[] { atributo, valor });
            Console.WriteLine("Atributo: " + atributo + " | Valor: " + valor);

            //Mostra tag correspondente
            tagsFiltrosEnt[0].Text = atributo;
            tagsFiltrosEnt[0].Visible = true;
            tagsFiltrosEnt.RemoveAt(0);

            // Limpa os controles após adicionar o filtro
            comboAtributoEntidade.SelectedIndex = -1;
            campoValorEntidade.Clear();

        }

        private string transformaItemParaCampo(string text)
        {
            if (text == "Código")
            {
                return "Cod";
            }
            else if (text == "Razão Social")
            {
                return "Razao_Social";
            }
            else if (text == "Privilégios")
            {
                return "Privilegios";
            }
            else
            {
                return text;
            }
        }

        private void btnAdicionarFiltroFazenda_Click(object sender, EventArgs e)
        {
            // Verifica se já existem 3 filtros adicionados
            if (filtrosFaz.Count >= 3)
            {
                MessageBox.Show("Você já adicionou o máximo de 3 filtros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Verifica se o campo Valor não está vazio
            if (campoValorFazenda.Text == "" || comboAtributoFazenda.SelectedItem == null)
            {
                MessageBox.Show("O valor do atributo e do filtro não podem ser nulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtém os valores selecionados na ComboBox e no TextBox
            string atributo = comboAtributoFazenda.SelectedItem.ToString();
            string valor = campoValorFazenda.Text;

            // Adiciona o filtro à lista de filtrosEnt
            filtrosFaz.Add(new string[] { atributo, valor });

            //Mostra tag correspondente
            tagsFiltrosFaz[0].Text = atributo;
            tagsFiltrosFaz[0].Visible = true;
            tagsFiltrosFaz.RemoveAt(0);

            // Limpa os controles após adicionar o filtro
            comboAtributoFazenda.SelectedIndex = -1;
            campoValorFazenda.Clear();

        }

        private void btnAdicionarFiltroAcoes_Click(object sender, EventArgs e)
        {
            // Verifica se já existem 3 filtros adicionados
            if (filtrosAco.Count >= 3)
            {
                MessageBox.Show("Você já adicionou o máximo de 3 filtros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Verifica se o campo Valor não está vazio
            if (campoValorAcoes.Text == "" || comboAtributoAcoes.SelectedItem == null)
            {
                MessageBox.Show("O valor do atributo e do filtro não podem ser nulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtém os valores selecionados na ComboBox e no TextBox
            string atributo = comboAtributoAcoes.SelectedItem.ToString();
            string valor = campoValorAcoes.Text;

            // Adiciona o filtro à lista de filtrosEnt
            filtrosFaz.Add(new string[] { atributo, valor });

            //Mostra tag correspondente
            tagsFiltrosAco[0].Text = atributo;
            tagsFiltrosAco[0].Visible = true;
            tagsFiltrosAco.RemoveAt(0);

            // Limpa os controles após adicionar o filtro
            comboAtributoAcoes.SelectedIndex = -1;
            campoValorAcoes.Clear();

        }

        private void btnFiltroEnt1_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltroEnt1.Text;

            btnFiltroEnt1.Visible = false;
            btnFiltroEnt1.Text = "";
            tagsFiltrosEnt.Add(btnFiltroEnt1);

            // Itera pela lista de filtrosEnt para encontrar o item a ser removido
            for (int i = 0; i < filtrosEnt.Count; i++)
            {
                string[] filtro = filtrosEnt[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtrosEnt.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnFiltroEnt2_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltroEnt2.Text;

            btnFiltroEnt2.Visible = false;
            btnFiltroEnt2.Text = "";
            tagsFiltrosEnt.Add(btnFiltroEnt2);

            // Itera pela lista de filtrosEnt para encontrar o item a ser removido
            for (int i = 0; i < filtrosEnt.Count; i++)
            {
                string[] filtro = filtrosEnt[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtrosEnt.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnFiltroEnt3_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltroEnt3.Text;

            btnFiltroEnt3.Visible = false;
            btnFiltroEnt3.Text = "";
            tagsFiltrosEnt.Add(btnFiltroEnt3);

            // Itera pela lista de filtrosEnt para encontrar o item a ser removido
            for (int i = 0; i < filtrosEnt.Count; i++)
            {
                string[] filtro = filtrosEnt[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtrosEnt.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnFiltroFaz1_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltroFaz1.Text;

            btnFiltroFaz1.Visible = false;
            btnFiltroFaz1.Text = "";
            tagsFiltrosFaz.Add(btnFiltroFaz1);

            // Itera pela lista de filtros para encontrar o item a ser removido
            for (int i = 0; i < filtrosFaz.Count; i++)
            {
                string[] filtro = filtrosFaz[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtrosFaz.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnFiltroFaz2_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltroFaz2.Text;

            btnFiltroFaz2.Visible = false;
            btnFiltroFaz2.Text = "";
            tagsFiltrosFaz.Add(btnFiltroFaz2);

            // Itera pela lista de filtrosEnt para encontrar o item a ser removido
            for (int i = 0; i < filtrosFaz.Count; i++)
            {
                string[] filtro = filtrosFaz[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtrosFaz.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnFiltroFaz3_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltroFaz3.Text;

            btnFiltroFaz3.Visible = false;
            btnFiltroFaz3.Text = "";
            tagsFiltrosFaz.Add(btnFiltroFaz3);

            // Itera pela lista de filtrosEnt para encontrar o item a ser removido
            for (int i = 0; i < filtrosFaz.Count; i++)
            {
                string[] filtro = filtrosFaz[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtrosFaz.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnFiltroAco1_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltroAco1.Text;

            btnFiltroAco1.Visible = false;
            btnFiltroAco1.Text = "";
            tagsFiltrosAco.Add(btnFiltroAco1);

            // Itera pela lista de filtrosEnt para encontrar o item a ser removido
            for (int i = 0; i < filtrosAco.Count; i++)
            {
                string[] filtro = filtrosAco[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtrosAco.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnFiltroAco2_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltroAco2.Text;

            btnFiltroAco2.Visible = false;
            btnFiltroAco2.Text = "";
            tagsFiltrosAco.Add(btnFiltroAco2);

            // Itera pela lista de filtrosEnt para encontrar o item a ser removido
            for (int i = 0; i < filtrosAco.Count; i++)
            {
                string[] filtro = filtrosAco[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtrosAco.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnFiltroAco3_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltroAco3.Text;

            btnFiltroAco3.Visible = false;
            btnFiltroAco3.Text = "";
            tagsFiltrosAco.Add(btnFiltroAco3);

            // Itera pela lista de filtrosEnt para encontrar o item a ser removido
            for (int i = 0; i < filtrosAco.Count; i++)
            {
                string[] filtro = filtrosAco[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtrosAco.RemoveAt(i);
                    break;
                }
            }
        }

        //RADIO

        private void radio_Entidade_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                entidadeSelecionada = radioButton.Text;
            }
        }

        private void radio_Tecnico_Entidade_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                entidadeSelecionada = "Tecnico";
            }
        }

        private void radio_Fazenda_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                fazendaSelecionada = radioButton.Text;
            }
        }

        //LIMPAR

        private void btnLimparEntidade_Click(object sender, EventArgs e)
        {
            comboAtributoEntidade.Text = "";
            campoValorEntidade.Text = "";
            dataGridEntidade.DataSource = null;
        }

        //CONSULTAR

        private void btnConsultarFazenda_Click(object sender, EventArgs e)
        {
            string querySelecao;

            if (fazendaSelecionada == null)
            {
                MessageBox.Show("Selecione um objeto da fazenda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (filtrosFaz.Count == 0)
            {
                querySelecao = "SELECT * FROM " + fazendaSelecionada;
            }
            else
            {
                // Inicia a query de select
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM " + fazendaSelecionada + " WHERE ");

                // Loop pelos filtros para adicionar as condições WHERE à query
                for (int i = 0; i < filtrosFaz.Count; i++)
                {
                    queryBuilder.Append(filtrosFaz[i][0]); // Adiciona o nome do atributo
                    queryBuilder.Append(" LIKE '%");
                    queryBuilder.Append(filtrosFaz[i][1]); // Adiciona o valor do atributo
                    queryBuilder.Append("%'");

                    // Adiciona o operador lógico AND entre as condições, exceto para a última condição
                    if (i < filtrosFaz.Count - 1)
                    {
                        queryBuilder.Append(" AND ");
                    }
                }

                // Completa a query de seleção
                querySelecao = queryBuilder.ToString();
            }

            Console.WriteLine(querySelecao);

            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Abriu com " + fazendaSelecionada);

                    // Cria um adaptador de dados para executar a query
                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, connectionString);

                    // Cria um DataTable para armazenar os resultados
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os resultados da consulta
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridFazenda.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar objeto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnConsultarEntidade_Click(object sender, EventArgs e)
        {
            string querySelecao;

            if (entidadeSelecionada == null)
            {
                MessageBox.Show("Selecione um tipo de entidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (filtrosEnt.Count == 0)
            {
                querySelecao = "SELECT * FROM " + entidadeSelecionada;
            }
            else
            {
                // Inicia a query de select
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM " + entidadeSelecionada + " WHERE ");

                // Loop pelos filtros para adicionar as condições WHERE à query
                for (int i = 0; i < filtrosEnt.Count; i++)
                {
                    queryBuilder.Append(filtrosEnt[i][0]); // Adiciona o nome do atributo
                    queryBuilder.Append(" LIKE '%");
                    queryBuilder.Append(filtrosEnt[i][1]); // Adiciona o valor do atributo
                    queryBuilder.Append("%'");

                    // Adiciona o operador lógico AND entre as condições, exceto para a última condição
                    if (i < filtrosEnt.Count - 1)
                    {
                        queryBuilder.Append(" AND ");
                    }
                }

                // Completa a query de seleção
                querySelecao = queryBuilder.ToString();
            }

            Console.WriteLine(querySelecao);

            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Abriu com " + entidadeSelecionada);

                    // Cria um adaptador de dados para executar a query
                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, connectionString);

                    // Cria um DataTable para armazenar os resultados
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os resultados da consulta
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridEntidade.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar entidade: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        //CADASTRO ENTIDADES

        private void comboTipoEntidade_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboTipoEntidade.SelectedItem.ToString() == "Fornecedor")
            {
                escondeTodosCadastroEntidade();
                limpaCamposCadastroEntidade();

                campoRazaoSocial.Visible = true;
                labelRazaoSocial.Visible = true;
                campoCNPJ.Visible = true;
                labelCNPJ.Visible = true;
                campoTelefone.Visible = true;
                labelTelefone.Visible = true;
                comboPrivilegios.Visible = true;
                labelPrivilegios.Visible = true;
                campoCEP.Visible = true;
                labelCEP.Visible = true;
            }
            else if (comboTipoEntidade.SelectedItem.ToString() == "Gerente")
            {
                escondeTodosCadastroEntidade();
                limpaCamposCadastroEntidade();

                campoNome.Visible = true;
                labelNome.Visible = true;
                campoCPF.Visible = true;
                labelCPF.Visible = true;
                campoTelefone.Visible = true;
                labelTelefone.Visible = true;
                comboPrivilegios.Visible = true;
                labelPrivilegios.Visible = true;
                comboSetor.Visible = true;
                labelSetor.Visible = true;
            }
            else if (comboTipoEntidade.SelectedItem.ToString() == "Técnico")
            {
                escondeTodosCadastroEntidade();
                limpaCamposCadastroEntidade();

                campoNome.Visible = true;
                labelNome.Visible = true;
                campoCPF.Visible = true;
                labelCPF.Visible = true;
                campoTelefone.Visible = true;
                labelTelefone.Visible = true;
                comboPrivilegios.Visible = true;
                labelPrivilegios.Visible = true;
                comboEspecialidade.Visible = true;
                labelEspecialidade.Visible = true;
            }
            else if (comboTipoEntidade.SelectedItem.ToString() == "Produtor")
            {
                escondeTodosCadastroEntidade();
                limpaCamposCadastroEntidade();

                campoNome.Visible = true;
                labelNome.Visible = true;
                campoCPF.Visible = true;
                labelCPF.Visible = true;
                campoTelefone.Visible = true;
                labelTelefone.Visible = true;
                campoCEP.Visible = true;
                labelCEP.Visible = true;
                comboPrivilegios.Visible = true;
                labelPrivilegios.Visible = true;
            }
            else
            {
                escondeTodosCadastroEntidade();
                limpaCamposCadastroEntidade();

                campoNome.Visible = true;
                labelNome.Visible = true;
                campoCPF.Visible = true;
                labelCPF.Visible = true;
                campoTelefone.Visible = true;
                labelTelefone.Visible = true;
                comboPrivilegios.Visible = true;
                labelPrivilegios.Visible = true;
            }
        }

        //INCLUIR
        private void btnIncluirEntidade_Click(object sender, EventArgs e)
        {
            //Vê o índice da Combo Box e atribui o valor a uma string.
            String entidadeTabela = listaTipoEntidade[comboTipoEntidade.SelectedIndex];

            //Inicia a Query SQL
            StringBuilder queryBuilder = new StringBuilder("INSERT INTO " + entidadeTabela + "(");

            //Gera a lista com o valor dos devidos campos
            List<string> listaValores = verificaCamposEntidade();

            if (listaValores == null)
            {
                MessageBox.Show("Há campos obrigatórios em branco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gera automaticamente a estrutura que vincula o campo da tabela ao valor da Text Box
            Dictionary<string, string> dados = geraDadosQueryEntidade(entidadeTabela, listaValores);

            // Adiciona os nomes dos campos à consulta SQL
            queryBuilder.Append(string.Join(",", dados.Keys));
            queryBuilder.Append(") VALUES (");

            // Adiciona os valores à consulta SQL
            foreach (var valor in dados.Values)
            {
                // Se o valor for uma string, adiciona aspas simples à volta
                if (valor != null)
                {
                    queryBuilder.Append("'");
                    queryBuilder.Append(valor);
                    queryBuilder.Append("'");
                }
                else
                {
                    // Se o valor for nulo, insere NULL na consulta
                    queryBuilder.Append("NULL");
                }

                // Adiciona uma vírgula para separar os valores, exceto o último
                if (!valor.Equals(dados.Values.Last()))
                {
                    queryBuilder.Append(",");
                }
            }

            queryBuilder.Append(")");

            // Query de inserção completa
            string queryInsercao = queryBuilder.ToString();
            Console.WriteLine(queryInsercao);

            //Cria e executa comando com uma conexão válida.
            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Cria o comando SQL
                    using (SqlCommand command = connection.CreateCommand(queryInsercao))
                    {
                        // Executa o comando SQL
                        command.ExecuteNonQuery();

                        Console.WriteLine("Inserção bem-sucedida!");
                        MessageBox.Show("Cadastro realizado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                }
            }

            limpaCamposCadastroEntidade();

            comboTipoEntidade.Focus();
        }

        private List<string> verificaCamposEntidade()
        {
            List<string> listaValores = new List<string>();

            TextBox[] textboxes =
            {
                campoNome,campoCNPJ,
                campoCPF, campoRazaoSocial,
                campoCEP, campoTelefone
            };

            ComboBox[] comboBoxes =
            {
                comboSetor, comboEspecialidade

                //NECESSÁRIO AJUSTAR BANCO DE DADOS PARA QUE O CAMPO PRIVILÉGIOS EXISTA
                //comboSetor, comboEspecialidade, comboPrivilegios
            };

            foreach (TextBox campo in textboxes)
            {
                if (campo.Visible && campo.Text != "")
                {
                    listaValores.Add(campo.Text);
                }
                else if (campo.Visible && campo.Text == "")
                {
                    return null;
                }
            }
            foreach (ComboBox combo in comboBoxes)
            {
                if (combo.Visible && combo.Text != "")
                {
                    listaValores.Add(combo.Text);
                }
                else if (combo.Visible && combo.Text == "")
                {
                    return null;
                }
            }

            foreach (string valor in listaValores)
            {
                Console.WriteLine(valor);
            }

            return listaValores;
        }

        private Dictionary<string, string> geraDadosQueryEntidade(string tabela, List<string> listaValores)
        {
            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                connection.Open();

                Console.WriteLine("Abriu com " + tabela);

                // Query para obter os nomes dos campos da tabela
                string query = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tabela}' AND LEFT(COLUMN_NAME, 3) != 'Cod'";

                using (SqlCommand command = connection.CreateCommand(query))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Lista para armazenar os nomes dos campos
                        var nomesCampos = new List<string>();

                        // Lê os nomes dos campos retornados pela consulta
                        while (reader.Read())
                        {
                            string nomeCampo = reader.GetString(0);
                            nomesCampos.Add(nomeCampo);

                            Console.WriteLine($"{nomeCampo}");
                        }

                        Dictionary<string, string> dados = new Dictionary<string, string>();

                        // Verifica se as listas têm o mesmo comprimento
                        if (nomesCampos.Count == listaValores.Count)
                        {
                            // Adiciona os valores e nomes de campo ao dicionário
                            for (int i = 0; i < nomesCampos.Count; i++)
                            {
                                dados.Add(nomesCampos[i], listaValores[i]);
                            }

                            // Exibe os dados no dicionário
                            foreach (var kvp in dados)
                            {
                                Console.WriteLine($"Campo: {kvp.Key}, Valor: {kvp.Value}");
                            }

                            return dados;
                        }
                        else
                        {
                            Console.WriteLine("As listas de nomes de campos e valores têm comprimentos diferentes.");
                            Console.WriteLine("Quantidade de campos: " + nomesCampos.Count + " Quantidade de valores: " + listaValores.Count);

                            return null;
                        }
                    }
                }
            }
        }

        //GRAVAR
        private void btnGravarEntidade_Click(object sender, EventArgs e)
        {
            //Vê o índice da Combo Box e atribui o valor a uma string.
            String entidadeTabela = listaTipoEntidade[comboTipoEntidade.SelectedIndex];

            //Inicia a Query SQL
            StringBuilder queryBuilder = new StringBuilder("UPDATE " + entidadeTabela + " SET ");

            Console.WriteLine(entidadeSelecionada);

            //Gera a lista com o valor dos devidos campos
            List<string> listaValores = null;

            while (listaValores == null)
            {
                listaValores = verificaCamposEntidade();
            }

            //Gera automaticamente a estrutura que vincula o campo da tabela ao valor da Text Box
            Dictionary<string, string> dados = geraDadosQueryEntidade(entidadeTabela, listaValores);

            //Insere a atualização de valores na query
            foreach (var kvp in dados)
            {
                var valor = kvp.Value;
                var campo = kvp.Key;

                // Se o valor for uma string, adiciona aspas simples à volta
                if (campo != null)
                {
                    queryBuilder.Append(campo);
                    queryBuilder.Append(" = '");
                    queryBuilder.Append(valor);
                    queryBuilder.Append("'");
                }

                // Adiciona uma vírgula para separar os valores, exceto o último
                if (!valor.Equals(dados.Values.Last()))
                {
                    queryBuilder.Append(",");
                }
            }

            queryBuilder.Append(" WHERE Cod" + entidadeTabela + " = " + campoCodigoEntidade.Text + ";");

            // Query de alteração completa
            string queryInsercao = queryBuilder.ToString();
            Console.WriteLine(queryInsercao);

            //Cria e executa comando com uma conexão válida.
            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Cria o comando SQL
                    using (SqlCommand command = connection.CreateCommand(queryInsercao))
                    {
                        // Executa o comando SQL
                        command.ExecuteNonQuery();

                        Console.WriteLine("Alteração bem-sucedida!");
                        MessageBox.Show("Alteração realizada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao alterar dados: " + ex.Message);
                }
            }
        }

        //EXCLUIR
        private void btnExcluirEntidade_Click(object sender, EventArgs e)
        {
            //Exibe mensagem de confirmação da exclusão
            DialogResult result = MessageBox.Show("Confirma a exclusão do registro?.", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //Vê o índice da Combo Box e atribui o valor a uma string.
            String entidadeTabela = listaTipoEntidade[comboTipoEntidade.SelectedIndex];

            //Verifica o botão que foi clicado e executa de acordo
            if (result == DialogResult.OK)
            {
                string queryExclusao = "DELETE FROM " + entidadeTabela + " WHERE Cod" + entidadeSelecionada + " = " + campoCodigoEntidade.Text;

                //Cria e executa a exclusão com uma conexão válida.
                using (DatabaseConnection connection = new DatabaseConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Cria o comando SQL
                        using (SqlCommand command = connection.CreateCommand(queryExclusao))
                        {
                            // Executa o comando SQL
                            command.ExecuteNonQuery();

                            Console.WriteLine("Exclusão realizada");
                            MessageBox.Show("Exclusão realizada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao excluir registro: " + ex.Message);
                    }
                }
            }
            else
            {
                return;
            }
        }

        //LIMPAR
        private void btnLimparCadastro_Click(object sender, EventArgs e)
        {
            limpaCamposCadastroEntidade();
        }

        private void limpaCamposCadastroEntidade()
        {
            campoCodigoEntidade.Text = "";
            campoNome.Text = "";
            campoRazaoSocial.Text = "";
            campoCPF.Text = "";
            campoCNPJ.Text = "";
            campoTelefone.Text = "";
            campoCEP.Text = "";
            comboSetor.Text = "";
            comboSetor.SelectedIndex = -1;
            comboEspecialidade.Text = "";
            comboEspecialidade.SelectedIndex = -1;
            comboPrivilegios.Text = "";
            comboPrivilegios.SelectedIndex = -1;
        }

        private void escondeTodosCadastroEntidade()
        {
            //Dados Comuns
            campoNome.Visible = false;
            labelNome.Visible = false;
            campoCPF.Visible = false;
            labelCPF.Visible = false;
            campoTelefone.Visible = false;
            labelTelefone.Visible = false;
            comboPrivilegios.Visible = false;
            labelPrivilegios.Visible = false;

            //Dados de ADMINISTRADOR

            //Dados de GERENTE
            comboSetor.Visible = false;
            labelSetor.Visible = false;

            //Dados de TECNICO
            comboEspecialidade.Visible = false;
            labelEspecialidade.Visible = false;

            //Dados de FORNECEDOR
            campoRazaoSocial.Visible = false;
            labelRazaoSocial.Visible = false;
            campoCNPJ.Visible = false;
            labelCNPJ.Visible = false;
            campoCEP.Visible = false;
            labelCEP.Visible = false;
        }

        //CADASTRO DE FAZENDA

        private void comboTipoFazenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verifica o item selecionado, esconde todos os campos e mostra
            //apenas os necessários

            if (comboTipoFazenda.SelectedItem.ToString() == "Lote")
            {
                SuspendLayout();

                escondeTodosCadastroFazenda();

                labelQuantidade_Lote.Visible = true;
                campoQuantidade_Lote.Visible = true;
                campoPesoTotal_Lote.Visible = true;
                campoPesoMedio_Lote.Visible = true;
                labelPesoTotal_Lote.Visible = true;
                labelPesoMedio_Lote.Visible = true;
                labelSituacao_Lote.Visible = true;
                comboSituacao_Lote.Visible = true;
                labelDataAloj_Lote.Visible = true;
                labelEstCarreg_Lote.Visible = true;
                dateTPDataAloj_Lote.Visible = true;
                dateTPEstCarregamento_Lote.Visible = true;
                labelCodigoGerente_Lote.Visible = true;
                labelObservacoes_Lote.Visible = true;
                campoCodGerente_Lote.Visible = true;
                textoObservacoes_Lote.Visible = true;
                labelCodPocilga_Lote.Visible = true;
                campoCodPocilga_Lote.Visible = true;

                ResumeLayout();
            }
            else if (comboTipoFazenda.SelectedItem.ToString() == "Pocilga")
            {
                SuspendLayout();

                escondeTodosCadastroFazenda();

                labelCapacidade_Pocilga.Visible = true;
                campoCapacidade_Pocilga.Visible = true;
                labelDescricao_Pocilga.Visible = true;
                textoDescricao_Pocilga.Visible = true;
                labelCodPropriedade_Pocilga.Visible = true;
                campoCodPropriedade_Pocilga.Visible = true;
                labelLotesAssociados_Pocilga.Visible = true;
                dataGridLotesAssociados_Pocilga.Visible = true;

                ResumeLayout();
            }
            else if (comboTipoFazenda.SelectedItem.ToString() == "Visita")
            {
                SuspendLayout();

                escondeTodosCadastroFazenda();

                labelData_Visita.Visible = true;
                dateTPData_Visita.Visible = true;
                labelFinalidade_Visita.Visible = true;
                campoFinalidade_Visita.Visible = true;
                labelDataUlt_Visita.Visible = true;
                dateTPUlt_Visita.Visible = true;
                labelCodUlt_Visita.Visible = true;
                campoCodUlt_Visita.Visible = true;
                labelObservacoes_Visita.Visible = true;
                textObservacoes_Visita.Visible = true;
                labelCodPessoa_Visita.Visible = true;
                campoCodPessoa_Visita.Visible = true;
                labelCodPocilga_Visita.Visible = true;
                campoCodPocilga_Visita.Visible = true;

                ResumeLayout();
            }
            else if (comboTipoFazenda.SelectedItem.ToString() == "Propriedade")
            {
                SuspendLayout();

                escondeTodosCadastroFazenda();

                labelNome_Propriedade.Visible = true;
                campoNome_Propriedade.Visible = true;
                labelCodProdutor_Propriedade.Visible = true;
                campoCodigoProdutor_Propriedade.Visible = true;

                ResumeLayout();
            }
            else if (comboTipoFazenda.SelectedItem.ToString() == "Produto")
            {
                SuspendLayout();

                escondeTodosCadastroFazenda();

                labelNome_Produto.Visible = true;
                campoNome_Produto.Visible = true;
                labelTipo_Produto.Visible = true;
                comboTipo_Produto.Visible = true;
                labelCategoria_Produto.Visible = true;
                comboCategoria_Produto.Visible = true;
                dateTPValidade_Produto.Visible = true;
                labelValidade_Produto.Visible = true;

                ResumeLayout();
            }
        }

        private void escondeTodosCadastroFazenda()
        {
            //Dados de LOTE
            labelQuantidade_Lote.Visible = false;
            campoQuantidade_Lote.Visible = false;
            campoPesoTotal_Lote.Visible = false;
            campoPesoMedio_Lote.Visible = false;
            labelPesoTotal_Lote.Visible = false;
            labelPesoMedio_Lote.Visible = false;
            labelSituacao_Lote.Visible = false;
            comboSituacao_Lote.Visible = false;
            labelDataAloj_Lote.Visible = false;
            labelEstCarreg_Lote.Visible = false;
            dateTPDataAloj_Lote.Visible = false;
            dateTPEstCarregamento_Lote.Visible = false;
            labelCodigoGerente_Lote.Visible = false;
            labelObservacoes_Lote.Visible = false;
            campoCodGerente_Lote.Visible = false;
            textoObservacoes_Lote.Visible = false;
            labelCodPocilga_Lote.Visible = false;
            campoCodPocilga_Lote.Visible = false;

            //Dados de VISITA
            labelData_Visita.Visible = false;
            dateTPData_Visita.Visible = false;
            labelFinalidade_Visita.Visible = false;
            campoFinalidade_Visita.Visible = false;
            labelDataUlt_Visita.Visible = false;
            dateTPUlt_Visita.Visible = false;
            labelCodUlt_Visita.Visible = false;
            campoCodUlt_Visita.Visible = false;
            labelObservacoes_Visita.Visible = false;
            textObservacoes_Visita.Visible = false;
            labelCodPessoa_Visita.Visible = false;
            campoCodPessoa_Visita.Visible = false;
            labelCodPocilga_Visita.Visible = false;
            campoCodPocilga_Visita.Visible = false;

            //Dados de POCILGA
            campoCapacidade_Pocilga.Visible = false;
            labelCapacidade_Pocilga.Visible = false;
            labelDescricao_Pocilga.Visible = false;
            textoDescricao_Pocilga.Visible = false;
            labelCodPropriedade_Pocilga.Visible = false;
            campoCodPropriedade_Pocilga.Visible = false;
            labelLotesAssociados_Pocilga.Visible = false;
            dataGridLotesAssociados_Pocilga.Visible = false;

            //Dados de PROPRIEDADE
            labelNome_Propriedade.Visible = false;
            campoNome_Propriedade.Visible = false;
            labelCodProdutor_Propriedade.Visible = false;
            campoCodigoProdutor_Propriedade.Visible = false;

            //Dados de PRODUTO
            labelNome_Produto.Visible = false;
            campoNome_Produto.Visible = false;
            labelTipo_Produto.Visible = false;
            comboTipo_Produto.Visible = false;
            labelCategoria_Produto.Visible = false;
            comboCategoria_Produto.Visible = false;
            dateTPValidade_Produto.Visible = false;
            labelValidade_Produto.Visible = false;

        }     

        //DATA GRIDS FILTRO

        private void dataGridEntidade_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Renomeia a coluna de acordo com o nome desejado
            dataGridEntidade.Columns[0].HeaderText = "Código";

            if (dataGridEntidade.Columns["Razao_Social"] != null)
            {
                dataGridEntidade.Columns["Razao_Social"].HeaderText = "Razão Social";
            }

            // Define o tamanho das colunas
            dataGridEntidade.Columns[0].Width = 80;
            if (dataGridEntidade.Columns["CPF"] != null)
            {
                dataGridEntidade.Columns["CPF"].Width = 140;
            }
            if (dataGridEntidade.Columns["CNPJ"] != null)
            {
                dataGridEntidade.Columns["CNPJ"].Width = 180;
            }
            if (dataGridEntidade.Columns["Telefone"] != null)
            {
                dataGridEntidade.Columns["Telefone"].Width = 140;
            }
            if (dataGridEntidade.Columns["CEP"] != null)
            {
                dataGridEntidade.Columns["CEP"].Width = 100;
            }
            if (dataGridEntidade.Columns["Setor"] != null)
            {
                dataGridEntidade.Columns["Setor"].Width = 200;
            }
            if (dataGridEntidade.Columns["Especialidade"] != null)
            {
                dataGridEntidade.Columns["Especialidade"].Width = 200;
            }
        }

        private void dataGridEntidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SuspendLayout();
            // Verifica se o clique foi em uma célula válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (entidadeSelecionada == "Tecnico")
                {
                    comboTipoEntidade.Text = "Técnico";
                }
                else
                {
                    comboTipoEntidade.Text = entidadeSelecionada;
                }
            }

            preencherCamposEntidade(entidadeSelecionada, e);

            ResumeLayout();
        }

        private void preencherCamposEntidade(string entidadeSelecionada, DataGridViewCellEventArgs e)
        {
            if (entidadeSelecionada == "Administrador" || entidadeSelecionada == "Visitante" || entidadeSelecionada == "Gerente" || entidadeSelecionada == "Produtor" || entidadeSelecionada == "Tecnico")
            {
                object codigo = dataGridEntidade.Rows[e.RowIndex].Cells[0].Value;
                campoCodigoEntidade.Text = codigo.ToString();

                object nome = dataGridEntidade.Rows[e.RowIndex].Cells[dataGridEntidade.Columns["Nome"].Index].Value;
                campoNome.Text = nome.ToString();

                object cpf = dataGridEntidade.Rows[e.RowIndex].Cells[dataGridEntidade.Columns["CPF"].Index].Value;
                campoCPF.Text = cpf.ToString();

                object telefone = dataGridEntidade.Rows[e.RowIndex].Cells[dataGridEntidade.Columns["Telefone"].Index].Value;
                campoTelefone.Text = telefone.ToString();
            }
            if (entidadeSelecionada == "Fornecedor")
            {
                object codigo = dataGridEntidade.Rows[e.RowIndex].Cells[0].Value;
                campoCodigoEntidade.Text = codigo.ToString();

                object razaoSocial = dataGridEntidade.Rows[e.RowIndex].Cells[dataGridEntidade.Columns["Razao_Social"].Index].Value;
                campoRazaoSocial.Text = razaoSocial.ToString();

                object cnpj = dataGridEntidade.Rows[e.RowIndex].Cells[dataGridEntidade.Columns["CNPJ"].Index].Value;
                campoCNPJ.Text = cnpj.ToString();

                object telefone = dataGridEntidade.Rows[e.RowIndex].Cells[dataGridEntidade.Columns["Telefone"].Index].Value;
                campoTelefone.Text = telefone.ToString();
            }
            if (entidadeSelecionada == "Fornecedor" || entidadeSelecionada == "Produtor")
            {
                object cep = dataGridEntidade.Rows[e.RowIndex].Cells[dataGridEntidade.Columns["CEP"].Index].Value;
                campoCEP.Text = cep.ToString();
            }
            if (entidadeSelecionada == "Gerente")
            {
                object setor = dataGridEntidade.Rows[e.RowIndex].Cells[dataGridEntidade.Columns["Setor"].Index].Value;
                comboSetor.Text = setor.ToString();
            }
            if (entidadeSelecionada == "Tecnico")
            {
                object especialidade = dataGridEntidade.Rows[e.RowIndex].Cells[dataGridEntidade.Columns["Especialidade"].Index].Value;
                comboEspecialidade.Text = especialidade.ToString();
            }
        }

        private void dataGridFazenda_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridFazenda.Columns["CodProdutor"] != null)
            {
                dataGridFazenda.Columns["CodProdutor"].HeaderText = "Código do Produtor";
            }
            if (dataGridFazenda.Columns["CodPropriedade"] != null)
            {
                dataGridFazenda.Columns["CodPropriedade"].HeaderText = "Código da Propr.";
            }
            if (dataGridFazenda.Columns["Quantidade"] != null)
            {
                dataGridFazenda.Columns["Quantidade"].HeaderText = "Quant.";
            }
            if (dataGridFazenda.Columns["Peso_Total"] != null)
            {
                dataGridFazenda.Columns["Peso_Total"].HeaderText = "Peso Total";
            }
            if (dataGridFazenda.Columns["Peso_Medio"] != null)
            {
                dataGridFazenda.Columns["Peso_Medio"].HeaderText = "Peso Medio";
            }
            if (dataGridFazenda.Columns["Observacoes"] != null)
            {
                dataGridFazenda.Columns["Observacoes"].HeaderText = "Obs.";
            }
            if (dataGridFazenda.Columns["Situacao"] != null)
            {
                dataGridFazenda.Columns["Situacao"].HeaderText = "Situação";
            }
            if (dataGridFazenda.Columns["Data_Alojamento"] != null)
            {
                dataGridFazenda.Columns["Data_Alojamento"].HeaderText = "Data de Aloj.";
            }
            if (dataGridFazenda.Columns["Estimativa_Carregamento"] != null)
            {
                dataGridFazenda.Columns["Estimativa_Carregamento"].HeaderText = "Est. Carreg.";
            }
            if (dataGridFazenda.Columns["CodGerente"] != null)
            {
                dataGridFazenda.Columns["CodGerente"].HeaderText = "Código do Gerente";
            }
            if (dataGridFazenda.Columns["Data_Ult"] != null)
            {
                dataGridFazenda.Columns["Data_Ult"].HeaderText = "Data Últ. Visita";
            }
            if (dataGridFazenda.Columns["Cod_Ult"] != null)
            {
                dataGridFazenda.Columns["Cod_Ult"].HeaderText = "Código Últ. Visita";
            }
            if (dataGridFazenda.Columns["CodVisitante"] != null)
            {
                dataGridFazenda.Columns["CodVisitante"].HeaderText = "Código do Visitante";
            }
            if (dataGridFazenda.Columns["CodPocilga"] != null)
            {
                dataGridFazenda.Columns["CodPocilga"].HeaderText = "Código da Pocilga";
            }

            // Renomeia a coluna de acordo com o nome desejado
            dataGridFazenda.Columns[0].HeaderText = "Código";

            // Define o tamanho das colunas
            dataGridFazenda.Columns[0].Width = 80;

        }


    }
}
