using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_CacaPalavra.Model
{
    class Verificacoes
    {
        public static bool PalavraRepetida(string palavra, List<string> palavras)
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
        public static void AdicionarPalavraLista()
        {

        }
    }
}
