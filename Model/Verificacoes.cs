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
        public static bool PosicaoPalava(string palavra) //Verifica se a proxima letra da palavra esta em uma posicao valida
        {
            for (int i = 0; i < palavra.Length - 1; i++) //-1 pra nao cair fora da palavra
            {
                if(palavra[i] == 'A' || palavra[i] == 'D') //Botao00
                {
                    List<char> letrasEnum = new List<char>();
                    var valores02 = Enum.GetValues(typeof(Botao02));
                    var valores12 = Enum.GetValues(typeof(Botao12));
                    var valores22 = Enum.GetValues(typeof(Botao22));
                    var valores21 = Enum.GetValues(typeof(Botao21));
                    var valores20 = Enum.GetValues(typeof(Botao20));
                    letrasEnum.AddRange((IEnumerable<char>)valores02);
                    letrasEnum.AddRange((IEnumerable<char>)valores12);
                    letrasEnum.AddRange((IEnumerable<char>)valores22);
                    letrasEnum.AddRange((IEnumerable<char>)valores21);
                    letrasEnum.AddRange((IEnumerable<char>)valores20);
                    foreach (var item in letrasEnum)
                    {
                        if(palavra[i+1] == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'E' || palavra[i] == 'F') //Botao01
                {
                    List<char> letrasEnum = new List<char>();
                    var valores22 = Enum.GetValues(typeof(Botao22));
                    var valores21 = Enum.GetValues(typeof(Botao21));
                    var valores20 = Enum.GetValues(typeof(Botao20));
                    letrasEnum.AddRange((IEnumerable<char>)valores22);
                    letrasEnum.AddRange((IEnumerable<char>)valores21);
                    letrasEnum.AddRange((IEnumerable<char>)valores20);
                    foreach (var item in letrasEnum)
                    {
                        if (palavra[i + 1] == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'B' || palavra[i] == 'C') //Botao02
                {
                    List<char> letrasEnum = new List<char>();
                    var valores22 = Enum.GetValues(typeof(Botao22));
                    letrasEnum.AddRange((IEnumerable<char>)valores22); 
                    var valores12 = Enum.GetValues(typeof(Botao12));
                    letrasEnum.AddRange((IEnumerable<char>)valores12);
                    var valores02 = Enum.GetValues(typeof(Botao02));
                    letrasEnum.AddRange((IEnumerable<char>)valores02);
                    foreach (var item in letrasEnum)
                    {
                        if (palavra[i + 1] == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'G' || palavra[i] == 'I' || palavra[i] == 'U') //Botao10
                {
                    List<char> letrasEnum = new List<char>();
                    var valores02 = Enum.GetValues(typeof(Botao02));
                    var valores12 = Enum.GetValues(typeof(Botao12));
                    var valores22 = Enum.GetValues(typeof(Botao22));
                    letrasEnum.AddRange((IEnumerable<char>)valores02);
                    letrasEnum.AddRange((IEnumerable<char>)valores12);
                    letrasEnum.AddRange((IEnumerable<char>)valores22);
                    foreach (var item in letrasEnum)
                    {
                        if (palavra[i + 1] == item)
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
                    List<char> letrasEnum = new List<char>();
                    var valores00 = Enum.GetValues(typeof(Botao00));
                    var valores01 = Enum.GetValues(typeof(Botao01));
                    var valores02 = Enum.GetValues(typeof(Botao02));
                    letrasEnum.AddRange((IEnumerable<char>)valores00);
                    letrasEnum.AddRange((IEnumerable<char>)valores01);
                    letrasEnum.AddRange((IEnumerable<char>)valores02);
                    foreach (var item in letrasEnum)
                    {
                        if (palavra[i + 1] == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'E' || palavra[i] == 'F') //Botao20
                {
                    List<char> letrasEnum = new List<char>();
                    var valores00 = Enum.GetValues(typeof(Botao00));
                    var valores01 = Enum.GetValues(typeof(Botao01));
                    var valores02 = Enum.GetValues(typeof(Botao02));
                    var valores12 = Enum.GetValues(typeof(Botao12));
                    var valores22 = Enum.GetValues(typeof(Botao22));
                    letrasEnum.AddRange((IEnumerable<char>)valores00);
                    letrasEnum.AddRange((IEnumerable<char>)valores01);
                    letrasEnum.AddRange((IEnumerable<char>)valores02);
                    letrasEnum.AddRange((IEnumerable<char>)valores12);
                    letrasEnum.AddRange((IEnumerable<char>)valores22);
                    foreach (var item in letrasEnum)
                    {
                        if (palavra[i + 1] == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'E' || palavra[i] == 'F') //Botao21
                {
                    List<char> letrasEnum = new List<char>();
                    var valores00 = Enum.GetValues(typeof(Botao00));
                    var valores01 = Enum.GetValues(typeof(Botao01));
                    var valores02 = Enum.GetValues(typeof(Botao02));
                    letrasEnum.AddRange((IEnumerable<char>)valores00);
                    letrasEnum.AddRange((IEnumerable<char>)valores01);
                    letrasEnum.AddRange((IEnumerable<char>)valores02);
                    foreach (var item in letrasEnum)
                    {
                        if (palavra[i + 1] == item)
                        {
                            return true;
                        }
                    }
                }
                else if (palavra[i] == 'E' || palavra[i] == 'F') //Botao22
                {
                    List<char> letrasEnum = new List<char>();
                    var valores00 = Enum.GetValues(typeof(Botao00));
                    var valores01 = Enum.GetValues(typeof(Botao01));
                    var valores02 = Enum.GetValues(typeof(Botao02));
                    var valores10 = Enum.GetValues(typeof(Botao10));
                    var valores20 = Enum.GetValues(typeof(Botao20));
                    letrasEnum.AddRange((IEnumerable<char>)valores00);
                    letrasEnum.AddRange((IEnumerable<char>)valores01);
                    letrasEnum.AddRange((IEnumerable<char>)valores02);
                    letrasEnum.AddRange((IEnumerable<char>)valores02);
                    letrasEnum.AddRange((IEnumerable<char>)valores02);
                    foreach (var item in letrasEnum)
                    {
                        if (palavra[i + 1] == item)
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
                if(item == palavra)
                {
                    repetida = true;
                }
            }
            return repetida;
        }
    }
}
