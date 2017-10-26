using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public static class Persistencia
    {
        private static Dictionary<int, string> banco = new Dictionary<int, string>();

        public static Dictionary<int, string> Banco { get => banco; }

        public static void Gravar(int algarismoArabico, string algarismoRomano)
        {
            try
            {
                if (!banco.ContainsKey(algarismoArabico))
                    banco.Add(algarismoArabico, algarismoRomano);
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }

        public static string PesquisarAlgarismoRomanoPeloArabico(int algarismoArabico)
        {
            try
            {
                return banco.ContainsKey(algarismoArabico) ? banco[algarismoArabico] : null;
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }

        public static string PesquisarAlgarismoArabicoPeloRomano(string algarismoRomano)
        {
            try
            {
                var relacao = from item in banco
                              where item.Value == algarismoRomano
                              select item;

                return relacao.Any() ? Convert.ToString(relacao.First().Key) : string.Empty;
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }
    }
}
