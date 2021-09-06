using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_CacaPalavra.Model.Enums;

namespace Trabalho_CacaPalavra.Model
{
    class Gerador
    {
        public static int GetAleatorio()
        {
            Random ran = new Random();
            return ran.Next(0, 2);
        }
        public static int GetAleatorio(int a)
        {
            Random ran = new Random();
            return ran.Next(0, 3);
        }
        public static void GetBotoes() //Atribui valores a todos os botoes
        {
            Botoes.B00 = ((Botao00)GetAleatorio()).ToString();
            Botoes.B01 = ((Botao01)GetAleatorio()).ToString();
            Botoes.B02 = ((Botao02)GetAleatorio()).ToString();
            Botoes.B10 = ((Botao10)GetAleatorio(4)).ToString();
            Botoes.B11 = ((Botao11)GetAleatorio(4)).ToString();
            Botoes.B12 = ((Botao12)GetAleatorio()).ToString();
            Botoes.B20 = ((Botao20)GetAleatorio(4)).ToString();
            Botoes.B21 = ((Botao21)GetAleatorio(4)).ToString();
            Botoes.B22 = ((Botao22)GetAleatorio(4)).ToString();
        }
    }
}
