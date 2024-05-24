using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazendaSuinos
{
    public static class Validador
    {
        public static bool ValidarTelefone(string telefone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(telefone, @"^\d{7}-\d{4}$");
        }

        public static bool ValidarCPF(string cpf)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(cpf, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
            {
                return false;
            }

            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
                return false;

            for (int t = 9; t < 11; t++)
            {
                int d = 0;
                for (int i = 0; i < t; i++)
                    d += int.Parse(cpf[i].ToString()) * ((t + 1) - i);

                d = (d * 10) % 11;
                if (d == 10) d = 0;
                if (d != int.Parse(cpf[t].ToString()))
                    return false;
            }
            return true;
        }

        public static bool ValidarCNPJ(string cnpj)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(cnpj, @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$"))
            {
                return false;
            }

            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            if (cnpj.Length != 14 || cnpj.All(c => c == cnpj[0]))
                return false;

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public static bool ValidarNome(string nome)
        {
            // Verifica se o nome está vazio ou nulo
            if (string.IsNullOrWhiteSpace(nome))
            {
                return false;
            }

            if(!nome.Contains(' '))
            {
                return false;
            }

            // Define o comprimento mínimo e máximo permitido para o nome
            int comprimentoMinimo = 2;
            int comprimentoMaximo = 50;

            if (nome.Length < comprimentoMinimo || nome.Length > comprimentoMaximo)
            {
                return false;
            }

            // Verifica se o nome contém apenas letras, espaços, apóstrofos e hifens
            if (!System.Text.RegularExpressions.Regex.IsMatch(nome, @"^[a-zA-Zà-úÀ-Ú\s'-]+$"))
            {
                return false;
            }

            // Verifica se cada palavra começa com uma letra maiúscula
            string[] palavras = nome.Split(' ');
            foreach (string palavra in palavras)
            {
                if (char.IsLower(palavra[0]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ValidarCEP(string cep)
        {
            // Verifica se o CEP está no formato 00000-000
            return System.Text.RegularExpressions.Regex.IsMatch(cep, @"^\d{5}-\d{3}$");
        }
    }
}
