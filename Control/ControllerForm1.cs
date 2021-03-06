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
        public static void GerarBotoes()     //Gera botões.
        {
            Gerador.GetBotoes();
        }
        public static void GerarPontuacao(List<string> lista)       //Gera pontuação.
        {
            Verificacoes.ContarAcertos(lista);
        }
        public static int VerificarPalavra(string palavra, List<string> lista)      //Verifica os possíveis erros e retorna.
        {
            while (true)
            {
                if (!string.IsNullOrEmpty(palavra))
                {
                    if (Verificacoes.LetraRepetida(palavra) == -1)
                    {
                        if (!Verificacoes.PosicaoPalava(palavra))
                        {
                            if (!string.IsNullOrEmpty(Jogador.ProximaPalavra))
                            {
                                palavra = Jogador.ProximaPalavra;
                            }
                            if (!Verificacoes.ListaPalavraRepetida(palavra, lista))
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
                        palavra = Jogador.ProximaPalavra;
                    }
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
