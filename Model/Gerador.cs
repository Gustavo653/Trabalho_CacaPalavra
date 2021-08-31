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
        public static Botoes GetBotoes()
        {
            Botoes botoes = new Botoes();
            botoes.B00 = ((Botao00)GetAleatorio()).ToString();
            botoes.B01 = ((Botao01)GetAleatorio()).ToString();
            botoes.B02 = ((Botao02)GetAleatorio()).ToString();
            botoes.B10 = ((Botao10)GetAleatorio(4)).ToString();
            botoes.B11 = ((Botao11)GetAleatorio(4)).ToString();
            botoes.B12 = ((Botao12)GetAleatorio()).ToString();
            botoes.B20 = ((Botao20)GetAleatorio(4)).ToString();
            botoes.B21 = ((Botao21)GetAleatorio(4)).ToString();
            botoes.B22 = ((Botao22)GetAleatorio(4)).ToString();
            return botoes;
        }
        //public static void Botoes()
        //{
        //    Random ran = new Random();
        //    Form1 form = new Form1();
        //    foreach (Control control in form.Controls)
        //    {
        //        Button button = control as Button;
        //        int aleatorio;
        //        if (button == null) continue;
        //        switch (button.Name)
        //        {
        //            case "btnBotao00":
        //                aleatorio = ran.Next(0, 2);
        //                button.Text = ((Botao00)aleatorio).ToString();
        //                break;
        //            case "btnBotao01":
        //                aleatorio = ran.Next(0, 2);
        //                button.Text = ((Botao01)aleatorio).ToString();
        //                break;
        //            case "btnBotao02":
        //                aleatorio = ran.Next(0, 2);
        //                button.Text = ((Botao02)aleatorio).ToString();
        //                break;
        //            case "btnBotao10":
        //                aleatorio = ran.Next(0, 3);
        //                button.Text = ((Botao10)aleatorio).ToString();
        //                break;
        //            case "btnBotao11":
        //                aleatorio = ran.Next(0, 3);
        //                button.Text = ((Botao11)aleatorio).ToString();
        //                break;
        //            case "btnBotao12":
        //                aleatorio = ran.Next(0, 2);
        //                button.Text = ((Botao12)aleatorio).ToString();
        //                break;
        //            case "btnBotao20":
        //                aleatorio = ran.Next(0, 3);
        //                button.Text = ((Botao20)aleatorio).ToString();
        //                break;
        //            case "btnBotao21":
        //                aleatorio = ran.Next(0, 3);
        //                button.Text = ((Botao21)aleatorio).ToString();
        //                break;
        //            case "btnBotao22":
        //                aleatorio = ran.Next(0, 3);
        //                button.Text = ((Botao22)aleatorio).ToString();
        //                break;
        //        }
        //    }
        //}
    }
}
