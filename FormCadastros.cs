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
            panelCadastroFazenda.Visible = false;
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
            else if(comboTipoFazenda.SelectedItem.ToString() == "Pocilga")
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
    }
}
