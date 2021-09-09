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
        public static bool PalavraValida(string palavra) //Verifica se a palavra inserida possui todas as letras iguais aos botoes
        {
            bool palavraValida = false;
            List<string> botoes = new List<string>();
            botoes.Add(Botoes.B00);
            botoes.Add(Botoes.B01);
            botoes.Add(Botoes.B02);
            botoes.Add(Botoes.B10);
            botoes.Add(Botoes.B11);
            botoes.Add(Botoes.B12);
            botoes.Add(Botoes.B20);
            botoes.Add(Botoes.B21);
            botoes.Add(Botoes.B22);
            foreach (var item in palavra)
            {
                if (!botoes.Contains(Convert.ToString(item))) //Se algum caractere nao estiver na lista de botoes, retorna erro
                {
                    palavraValida = true;
                }
            }
            return palavraValida;
        }
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
            Jogador.Acertos = pontos; //Os acertos são cumulativos
        }
        public static bool PosicaoPalava(string palavra) //Verifica se a proxima letra da palavra esta em uma posicao valida
        {
            int indice = 0;
            bool posicaoPalavra = false;
            char[] lista = palavra.ToCharArray();

            for (int i = 0; i < palavra.Length - 1; i++) //-1 pra nao cair fora da palavra
            {
                if (palavra[i] == 'A' || palavra[i] == 'D') //Botao00
                {
                    List<string> letrasEnum = new List<string>(); //Blacklist
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
                        if (Convert.ToString(lista[i + 1]) == item) //Se algum caractere for igual ao da black list, retornar erro
                        {
                            indice = i;
                            i = 200;
                            posicaoPalavra = true;
                            break;
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
                            indice = i;
                            i = 200;
                            posicaoPalavra = true;
                            break;
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
                            indice = i;
                            i = 200;
                            posicaoPalavra = true;
                            break;
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
                            indice = i;
                            i = 200;
                            posicaoPalavra = true;
                            break;
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
                        letrasEnum.Add(((Botao10)j).ToString());
                        letrasEnum.Add(((Botao20)j).ToString());
                    }
                    foreach (var item in letrasEnum)
                    {
                        if (Convert.ToString(lista[i + 1]) == item)
                        {
                            indice = i;
                            i = 200;
                            posicaoPalavra = true;
                            break;
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
                            indice = i;
                            i = 200;
                            posicaoPalavra = true;
                            break;
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
                            indice = i;
                            i = 200;
                            posicaoPalavra = true;
                            break;
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
                            indice = i;
                            i = 200;
                            posicaoPalavra = true;
                            break;
                        }
                    }
                }
            }
            if (posicaoPalavra)
            {
                Jogador.ProximaPalavra = palavra.Substring(0, indice + 1);
                posicaoPalavra = false;
            }
            return posicaoPalavra;
        }
        public static int LetraRepetida(string palavra) //Verifica se tem letra repetida na palavra do usuario
        {
            bool letra = false;
            int indice = -1;
            List<char> letras = new List<char>();
            for (int i = 0; i < palavra.Length; i++)
            {
                if (!letras.Contains(palavra[i]))
                {
                    letras.Add(palavra[i]);
                }
                else //Caso uma letra seja repetida, retornar erro
                {
                    indice = i;
                    letra = true;
                    Jogador.ProximaPalavra = palavra.Substring(0, indice);
                    break;
                }
            }


            if (letra)
            {
                return indice;
            }
            return -1;
            //List<char> letras = new List<char>();
            //foreach (var item in palavra)
            //{
            //    if (!letras.Contains(item))
            //    {
            //        letras.Add(item);
            //    }
            //    else //Caso uma letra seja repetida, retornar erro
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }
        public static bool ListaPalavraRepetida(string palavra, List<string> palavras) //Verifica se a palavra ja nao foi inserida pelo usuario
        {
            bool repetida = false;
            foreach (var item in palavras) //Caso a palavra ja esteja na lista, retornar erro
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
