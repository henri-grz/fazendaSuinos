using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace fazendaSuinos
{
    public partial class FormCadastros : Form
    {
        // Lista para armazenar os filtros
        private List<string[]> filtrosEnt = new List<string[]>();
        private List<string[]> filtrosFaz = new List<string[]>();
        private List<string[]> filtrosAco = new List<string[]>();

        private List<IconButton> tagsFiltrosEnt = new List<IconButton>();
        private List<IconButton> tagsFiltrosFaz = new List<IconButton>();
        private List<IconButton> tagsFiltrosAco = new List<IconButton>();



        public FormCadastros()
        {
            InitializeComponent();

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
            ResumeLayout();
        }

        private void comboTipoEntidade_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboTipoEntidade.SelectedItem.ToString() == "Fornecedor")
            {
                campoNome.Visible = false;
                labelNome.Visible = false;
                campoCPF.Visible = false;
                labelCPF.Visible = false;
                comboSetor.Visible = false;
                labelSetor.Visible = false;
                comboEspecialidade.Visible = false;
                labelEspecialidade.Visible = false;

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
            else
            {
                campoRazaoSocial.Visible = false;
                labelRazaoSocial.Visible = false;
                campoCNPJ.Visible = false;
                labelCNPJ.Visible = false;
                campoCEP.Visible = false;
                labelCEP.Visible = false;

                campoNome.Visible = true;
                labelNome.Visible = true;
                campoCPF.Visible = true;
                labelCPF.Visible = true;
                comboSetor.Visible = true;
                labelSetor.Visible = true;
                comboEspecialidade.Visible = true;
                labelEspecialidade.Visible = true;
                campoTelefone.Visible = true;
                labelTelefone.Visible = true;
                comboPrivilegios.Visible = true;
                labelPrivilegios.Visible = true;
            }
        }

        private void btnLimparCadastro_Click(object sender, EventArgs e)
        {
            limpaCamposCadastro();
        }

        private void limpaCamposCadastro()
        {
            campoCodigo.Text = "";
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

        private void btnAdicionarFiltroEntidade_Click(object sender, EventArgs e)
        {
            // Verifica se já existem 3 filtrosEnt adicionados
            if (filtrosEnt.Count >= 3)
            {
                MessageBox.Show("Você já adicionou o máximo de 3 filtros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Verifica se o campo Valor não está vazio
            if(campoValorEntidade.Text == "" || comboAtributoEntidade.SelectedItem == null)
            {
                MessageBox.Show("O valor do atributo e do filtro não podem ser nulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtém os valores selecionados na ComboBox e no TextBox
            string atributo = comboAtributoEntidade.SelectedItem.ToString();
            string valor = campoValorEntidade.Text;

            // Adiciona o filtro à lista de filtrosEnt
            filtrosEnt.Add(new string[] { atributo, valor });

            //Mostra tag correspondente
            tagsFiltrosEnt[0].Text = atributo;
            tagsFiltrosEnt[0].Visible = true;
            tagsFiltrosEnt.RemoveAt(0);

            // Limpa os controles após adicionar o filtro
            comboAtributoEntidade.SelectedIndex = -1;
            campoValorEntidade.Clear();

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

        private void comboTipoFazenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipoFazenda.SelectedItem.ToString() == "Lote")
            {
                SuspendLayout();

                escondeTodosCadastroFazenda();

                label12.Visible = true;
                campoQuantidadeLote.Visible = true;
                campoPesoTotal.Visible = true;
                campoPesoMedio.Visible = true;
                label18.Visible = true;
                label11.Visible = true;
                label16.Visible = true;
                comboSituacaoFazenda.Visible = true;
                label10.Visible = true;
                label14.Visible = true;
                dateTPDataAlojamento.Visible = true;
                dateTPEstimativaCarregamento.Visible = true;
                label13.Visible = true;
                label17.Visible = true;
                campoCodGerente.Visible = true;
                textoObservacoes.Visible = true;

                ResumeLayout();
            }
            else if(comboTipoFazenda.SelectedItem.ToString() == "Pocilga")
            {
                SuspendLayout();

                escondeTodosCadastroFazenda();

                label22.Visible = true;
                campoCapacidadePocilga.Visible = true;
                label23.Visible = true;
                textoDescricaoPocilga.Visible = true;

                ResumeLayout();
            }
            else if (comboTipoFazenda.SelectedItem.ToString() == "Visita")
            {
                SuspendLayout();

                escondeTodosCadastroFazenda();

                labelDataVisita.Visible = true;
                dateTPDataVisita.Visible = true;
                labelFinalidadeVisita.Visible = true;
                campoFinalidadeVisita.Visible = true;
                labelDataUltVisita.Visible = true;
                dateTiPUltimaVisita.Visible = true;
                labelCodUltVisita.Visible = true;
                campoCodUltimaVisita.Visible = true;
                labelObservacoesVisita.Visible = true;
                textObservacoesVisita.Visible = true;
                labelCodPessoaVisita.Visible = true;
                campoCodigoPessoaVisita.Visible = true;
                labelCodPocilgaVisita.Visible = true;
                campoCodPocilgaVisita.Visible = true;

                ResumeLayout();
            }
        }

        private void escondeTodosCadastroFazenda()
        {
            label12.Visible = false;
            campoQuantidadeLote.Visible = false;
            campoPesoTotal.Visible = false;
            campoPesoMedio.Visible = false;
            label18.Visible = false;
            label11.Visible = false;
            label16.Visible = false;
            comboSituacaoFazenda.Visible = false;
            label10.Visible = false;
            label14.Visible = false;
            dateTPDataAlojamento.Visible = false;
            dateTPEstimativaCarregamento.Visible = false;
            label13.Visible = false;
            label17.Visible = false;
            campoCodGerente.Visible = false;
            textoObservacoes.Visible = false;
            labelDataVisita.Visible = false;
            dateTPDataVisita.Visible = false;
            labelFinalidadeVisita.Visible = false;
            campoFinalidadeVisita.Visible = false;
            labelDataUltVisita.Visible = false;
            dateTiPUltimaVisita.Visible = false;
            labelCodUltVisita.Visible = false;
            campoCodUltimaVisita.Visible = false;
            labelObservacoesVisita.Visible = false;
            textObservacoesVisita.Visible = false;
            labelCodPessoaVisita.Visible = false;
            campoCodigoPessoaVisita.Visible = false;
            labelCodPocilgaVisita.Visible = false;
            campoCodPocilgaVisita.Visible = false;
        }
    }
}
