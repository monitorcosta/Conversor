using System;

namespace Conversor
{
    public class Algarismo
    {
        public static string Converter(string numero)
        {
            try
            {
                string retorno = string.Empty;
                int algarismoArabico = 0;
                string algarismoRomano = string.Empty;

                if (AlgarismoArabico.ValidarStringParaConversao(numero))
                {
                    retorno = AlgarismoArabico.ConverterParaAlgarismoRomano(numero);
                    algarismoArabico = Convert.ToInt32(numero);
                    algarismoRomano = retorno;
                }

                if (AlgarismoRomano.ValidarStringParaConversao(numero))
                {
                    retorno = AlgarismoRomano.ConverterParaAlgarismoArabico(numero);
                    algarismoArabico = Convert.ToInt32(retorno);
                    algarismoRomano = numero;
                }

                if (!string.IsNullOrWhiteSpace(retorno))
                    Persistencia.Gravar(algarismoArabico, algarismoRomano);

                return retorno;
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }
    }
}
