using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_CacaPalavra.Model;

namespace Trabalho_CacaPalavra.Controller
{
    class ControllerForm1
    {
        public static void GerarBotoes()
        {
            Gerador.GetBotoes();
        }
        public static void GerarPontuacao(List<string> lista)
        {
            Verificacoes.ContarAcertos(lista);
        }
        public static int VerificarPalavra(string palavra, List<string> lista)
        {
            if (!string.IsNullOrEmpty(palavra))
            {
                if (!Verificacoes.LetraRepetida(palavra))
                {
                    if (!Verificacoes.ListaPalavraRepetida(palavra, lista))
                    {
                        if (!Verificacoes.PosicaoPalava(palavra))
                        {
                            if (!Verificacoes.PalavraValida(palavra))
                            {
                                return 0;
                            }
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                    else
                    {
                        return 3;
                    }
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }
    }
}
