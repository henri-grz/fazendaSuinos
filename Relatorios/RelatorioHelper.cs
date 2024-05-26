using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazendaSuinos.Relatorios
{
    public static class RelatorioHelper
    {
        private static readonly string pastaRelatorios = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Rodolfo Relatorios");

        public static void VerificarOuCriarPasta()
        {
            if (!Directory.Exists(pastaRelatorios))
            {
                Directory.CreateDirectory(pastaRelatorios);
            }
        }

        public static string ObterCaminhoRelatorio(string nomeRelatorio)
        {
            return Path.Combine(pastaRelatorios, nomeRelatorio);
        }
    }
}
