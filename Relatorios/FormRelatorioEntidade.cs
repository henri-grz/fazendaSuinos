using fazendaSuinos.Relatorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazendaSuinos
{
    public partial class FormRelatorioEntidade : Form
    {
        public FormRelatorioEntidade(Dictionary<string, List<object>> dados)
        {
            InitializeComponent();
            ConfigurarRelatorio(dados);
        }

        private void ConfigurarRelatorio(Dictionary<string, List<object>> dados)
        {
            // Caminho do relatório RDLC
            string caminhoRelatorio = Path.Combine(Application.StartupPath, "Relatorios", "RelatorioEntidades.rdlc");

            // Configurações do Report Viewer
            //reportViewer1.ProcessingMode = ProcessingMode.Local;
            //reportViewer1.LocalReport.ReportPath = caminhoRelatorio;

            // Verifica se o arquivo de relatório existe
            if (!File.Exists(caminhoRelatorio))
            {
                MessageBox.Show("Arquivo de relatório não encontrado: " + caminhoRelatorio, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Adiciona as fontes de dados para cada seleção
            foreach (var key in dados.Keys)
            {
                //var rds = new ReportDataSource(key, dados[key]);
                //reportViewer1.LocalReport.DataSources.Add(rds);
            }

            // Atualiza o relatório
            //reportViewer1.RefreshReport();
        }

        private void FormRelatorioEntidade_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }
    }
}
