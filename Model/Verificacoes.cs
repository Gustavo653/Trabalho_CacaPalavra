using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_CacaPalavra.Model.Enums;

namespace Trabalho_CacaPalavra.Model
{
    class Verificacoes
    {
        public static void ContarAcertos(List<string> lista) //Verifica quantos acertos foram feitos
        {
            int pontos = 0;
            foreach (var item in lista)
            {
                pontos += item.Length;
            }
            if (pontos % 2 != 0) //Se a pontuacao for impar, tira um ponto
            {
                pontos--;
            }
            pontos /= 2; //Divide os acertos por 2 para gerar os pontos
            Jogador.Acertos = pontos;
        }
        public static bool PosicaoPalava(string palavra) //Verifica se a proxima letra da palavra esta em uma posicao valida
        {
            char[] lista = palavra.ToCharArray();

            for (int i = 0; i < palavra.Length - 1; i++) //-1 pra nao cair fora da palavra
            {
                if (palavra[i] == 'A' || palavra[i] == 'D') //Botao00
                {
                    List<string> letrasEnum = new List<string>();
                    for (int j = 0; j < 2; j++)
                    {
                        letrasEnum.Add(((Botao02)j).ToString());
                        letrasEnum.Add(((Botao12)j).ToString());
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        letrasEnum.Add(((Botao20)j).ToString());
                        letrasEnum.Add(((Botao21)j).ToString());
                        letrasEnum.Add(((Botao22)j).ToString());
                    }
                    foreach (var item in letrasEnum)
                    {
                        if (Convert.ToString(lista[i + 1]) == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'E' || palavra[i] == 'F') //Botao01
                {
                    List<string> letrasEnum = new List<string>();
                    for (int j = 0; j < 3; j++)
                    {
                        letrasEnum.Add(((Botao20)j).ToString());
                        letrasEnum.Add(((Botao21)j).ToString());
                        letrasEnum.Add(((Botao22)j).ToString());
                    }
                    foreach (var item in letrasEnum)
                    {
                        if (Convert.ToString(lista[i + 1]) == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'B' || palavra[i] == 'C') //Botao02
                {
                    List<string> letrasEnum = new List<string>();

                    for (int j = 0; j < 2; j++)
                    {
                        letrasEnum.Add(((Botao00)j).ToString());
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        letrasEnum.Add(((Botao20)j).ToString());
                        letrasEnum.Add(((Botao21)j).ToString());
                        letrasEnum.Add(((Botao22)j).ToString());
                        letrasEnum.Add(((Botao10)j).ToString());
                    }
                    foreach (var item in letrasEnum)
                    {
                        if (Convert.ToString(lista[i + 1]) == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'G' || palavra[i] == 'I' || palavra[i] == 'U') //Botao10
                {
                    List<string> letrasEnum = new List<string>();

                    for (int j = 0; j < 2; j++)
                    {
                        letrasEnum.Add(((Botao02)j).ToString());
                        letrasEnum.Add(((Botao12)j).ToString());
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        letrasEnum.Add(((Botao22)j).ToString());
                    }
                    foreach (var item in letrasEnum)
                    {
                        if (Convert.ToString(lista[i + 1]) == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'H' || palavra[i] == 'J' || palavra[i] == 'V') //Botao11
                {
                    //Pode todas as posicoes
                }
                else if (palavra[i] == 'K' || palavra[i] == 'L') //Botao12
                {
                    List<string> letrasEnum = new List<string>();

                    for (int j = 0; j < 2; j++)
                    {
                        letrasEnum.Add(((Botao00)j).ToString());
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        letrasEnum.Add(((Botao01)j).ToString());
                        letrasEnum.Add(((Botao02)j).ToString());
                    }
                    foreach (var item in letrasEnum)
                    {
                        if (Convert.ToString(lista[i + 1]) == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'M' || palavra[i] == 'O' || palavra[i] == 'Q') //Botao20
                {
                    List<string> letrasEnum = new List<string>();

                    for (int j = 0; j < 2; j++)
                    {
                        letrasEnum.Add(((Botao00)j).ToString());
                        letrasEnum.Add(((Botao01)j).ToString());
                        letrasEnum.Add(((Botao02)j).ToString());
                        letrasEnum.Add(((Botao12)j).ToString());
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        letrasEnum.Add(((Botao22)j).ToString());
                    }
                    foreach (var item in letrasEnum)
                    {
                        if (Convert.ToString(lista[i + 1]) == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'N' || palavra[i] == 'T' || palavra[i] == 'P') //Botao21
                {
                    List<string> letrasEnum = new List<string>();

                    for (int j = 0; j < 2; j++)
                    {
                        letrasEnum.Add(((Botao00)j).ToString());
                        letrasEnum.Add(((Botao01)j).ToString());
                        letrasEnum.Add(((Botao02)j).ToString());
                    }
                    foreach (var item in letrasEnum)
                    {
                        if (Convert.ToString(lista[i + 1]) == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'R' || palavra[i] == 'S' || palavra[i] == 'Z') //Botao22
                {
                    List<string> letrasEnum = new List<string>();

                    for (int j = 0; j < 2; j++)
                    {
                        letrasEnum.Add(((Botao00)j).ToString());
                        letrasEnum.Add(((Botao01)j).ToString());
                        letrasEnum.Add(((Botao02)j).ToString());
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        letrasEnum.Add(((Botao10)j).ToString());
                        letrasEnum.Add(((Botao20)j).ToString());
                    }
                    foreach (var item in letrasEnum)
                    {
                        if (Convert.ToString(lista[i + 1]) == item)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static bool LetraRepetida(string palavra) //Verifica se tem letra repetida na palavra do usuario
        {
            List<char> letras = new List<char>();
            foreach (var item in palavra)
            {
                if (!letras.Contains(item))
                {
                    letras.Add(item);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ListaPalavraRepetida(string palavra, List<string> palavras) //Verifica se a palavra ja nao foi inserida pelo usuario
        {
            bool repetida = false;
            foreach (var item in palavras)
            {
                if (item == palavra)
                {
                    repetida = true;
                }
            }
            return repetida;
        }
    }
}
