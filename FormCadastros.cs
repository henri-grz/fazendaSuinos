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
        private List<string[]> filtros = new List<string[]>();
        private List<IconButton> tagsFiltros = new List<IconButton>();

        public FormCadastros()
        {
            InitializeComponent();

            //Lista das tags disponíveis para uso
            tagsFiltros.Add(btnFiltro1);
            tagsFiltros.Add(btnFiltro2);
            tagsFiltros.Add(btnFiltro3);

        }       

        private void btnEntidades_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            //AJUSTA PANELS DE FILTRO
            panelFiltroFazenda.Visible = false;
            panelFiltroAcoes.Visible = false;
            panelFiltroEntidade.Visible = true;
            //AJUSTA CAMPOS DE CADASTRO
            panelCadastroEntidade.Visible = true;
            ResumeLayout();
        }

        private void btnFazenda_Click(object sender, EventArgs e)
        {
            ResumeLayout();
            //AJUSTA PANELS DE FILTRO
            panelFiltroAcoes.Visible = false;
            panelFiltroEntidade.Visible = false;
            panelFiltroFazenda.Visible = true;
            //AJUSTA CAMPOS DE CADASTRO
            panelCadastroEntidade.Visible = false;
            ResumeLayout();

        }

        private void btnAcoesCorretivas_Click(object sender, EventArgs e)
        {
            ResumeLayout();
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
            // Verifica se já existem 3 filtros adicionados
            if (filtros.Count >= 3)
            {
                MessageBox.Show("Você já adicionou o máximo de 3 filtros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Verifica se o campo Valor não está vazio
            if(campoFiltroValorEntidade.Text == "" || comboAtributoEntidade.SelectedItem == null)
            {
                MessageBox.Show("O valor do atributo e do filtro não podem ser nulos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtém os valores selecionados na ComboBox e no TextBox
            string atributo = comboAtributoEntidade.SelectedItem.ToString();
            string valor = campoFiltroValorEntidade.Text;

            // Adiciona o filtro à lista de filtros
            filtros.Add(new string[] { atributo, valor });

            //Mostra tag correspondente
            tagsFiltros[0].Text = atributo;
            tagsFiltros[0].Visible = true;
            tagsFiltros.RemoveAt(0);

            // Limpa os controles após adicionar o filtro
            comboAtributoEntidade.SelectedIndex = -1;
            campoFiltroValorEntidade.Clear();

        }

        private void btnFiltro1_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltro1.Text;

            btnFiltro1.Visible = false;
            btnFiltro1.Text = "";
            tagsFiltros.Add(btnFiltro1);

            // Itera pela lista de filtros para encontrar o item a ser removido
            for (int i = 0; i < filtros.Count; i++)
            {
                string[] filtro = filtros[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtros.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnFiltro2_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltro2.Text;

            btnFiltro2.Visible = false;
            btnFiltro2.Text = "";
            tagsFiltros.Add(btnFiltro2);        

            // Itera pela lista de filtros para encontrar o item a ser removido
            for (int i = 0; i < filtros.Count; i++)
            {
                string[] filtro = filtros[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtros.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnFiltro3_Click(object sender, EventArgs e)
        {
            string atributoParaRemover = btnFiltro3.Text;

            btnFiltro3.Visible = false;
            btnFiltro3.Text = "";
            tagsFiltros.Add(btnFiltro3);

            // Itera pela lista de filtros para encontrar o item a ser removido
            for (int i = 0; i < filtros.Count; i++)
            {
                string[] filtro = filtros[i];
                string atributo = filtro[0];

                // Se o atributo corresponder ao texto da tag clicada, remova o item da lista
                if (atributo == atributoParaRemover)
                {
                    filtros.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
