﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_CacaPalavra.Model;

namespace Trabalho_CacaPalavra.Controller
{
    class ControllerForm1
    {
        public static Botoes GerarBotoes()
        {
            Botoes botoes = Gerador.GetBotoes();
            return botoes;
        }
        public static int GerarPontuacao(List<string> lista)
        {
            int acertos = Verificacoes.ContarAcertos(lista);
            return acertos;
        }
        //Load chamar gerador.botoes
        //Load zerar lista
        //Load zerar label

        //Verificacao de palavra repetida -> label da view -> models - verificacoes - palavra repetida
    }
}
