using System;
using System.Collections;

namespace Conversor
{
    public class AlgarismoRomano
    {
        private enum DigitosRomanos
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }

        public static bool ValidarStringParaConversao(string numero)
        {
            try
            {
                numero = numero.ToUpper().Trim();
                if (numero.Equals("N"))
                    return false;

                if (numero.Split('V').Length > 2 || numero.Split('L').Length > 2 || numero.Split('D').Length > 2)
                    return false;

                int contador = 1;
                char ultimo = 'Z';
                foreach (char numeral in numero)
                {
                    if (("IVXLCDM").IndexOf(numeral).Equals(-1))
                        return false;

                    if (numeral.Equals(ultimo))
                    {
                        contador += 1;
                        if (contador.Equals(4))
                            return false;
                    }
                    else
                    {
                        contador = 1;
                        ultimo = numeral;
                    }
                }

                return true;
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }

        public static string ConverterParaAlgarismoArabico(string numeroRomano)
        {
            try
            {
                numeroRomano = numeroRomano.ToUpper().Trim();

                int ptr = 0;
                ArrayList valores = new ArrayList();
                int digitoMaximo = 1000;
                while (ptr < numeroRomano.Length)
                {
                    char numeral = Convert.ToChar(numeroRomano.Substring(ptr, 1));
                    int digito = (int)Enum.Parse(typeof(DigitosRomanos), numeral.ToString());

                    if (digito > digitoMaximo)
                        return null;

                    int proximoDigito = 0;
                    if (ptr < numeroRomano.Length - 1)
                    {
                        char proximoNumeral = Convert.ToChar(numeroRomano.Substring(ptr + 1, 1));
                        proximoDigito = (int)Enum.Parse(typeof(DigitosRomanos), proximoNumeral.ToString());

                        if (proximoDigito > digito)
                        {
                            if ("IXC".IndexOf(numeral).Equals(-1) || proximoDigito > (digito * 10) || numeroRomano.Split(numeral).Length > 3)
                                return null;

                            digitoMaximo = digito - 1;
                            digito = proximoDigito - digito;
                            ptr += 1;
                        }
                    }
                    valores.Add(digito);

                    ptr += 1;
                }

                for (int i = 0; i < valores.Count - 2; i++)
                {
                    if (Convert.ToInt32(valores[i]) < Convert.ToInt32(valores[i + 1]))
                        return null;
                }

                int total = 0;
                foreach (int digito in valores)
                    total += digito;

                return Convert.ToString(total);
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }
    }
}
