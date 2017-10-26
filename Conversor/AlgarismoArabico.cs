using System;
using System.Text;

namespace Conversor
{
    public class AlgarismoArabico
    {
        public static bool ValidarStringParaConversao(string numero)
        {
            try
            {
                int numeroRetorno;
                return Int32.TryParse(numero, out numeroRetorno) && numeroRetorno > 0 && numeroRetorno <= 3000; ;
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }

        public static string ConverterParaAlgarismoRomano(string numero)
        {
            try
            {
                int numeroDecimal = Convert.ToInt32(numero);

                string[] algarismosRomanos = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
                int[] algarismosArabicos = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

                var resultado = new StringBuilder();

                for (int i = 12; i > 0; i--)
                {
                    while (numeroDecimal >= algarismosArabicos[i])
                    {
                        numeroDecimal = numeroDecimal - algarismosArabicos[i];
                        resultado.Append(algarismosRomanos[i]);
                    }

                }

                for (int i = numeroDecimal - 1; i >= 0; i--)
                {
                    while (numeroDecimal >= algarismosArabicos[i])
                    {
                        numeroDecimal = numeroDecimal - algarismosArabicos[i];
                        resultado.Append(algarismosRomanos[i]);
                    }

                }

                return resultado.ToString();
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }
    }
}
