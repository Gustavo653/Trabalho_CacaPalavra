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
        public static void Botoes()
        {
            Random ran = new Random();
            Form1 form = new Form1();
            foreach (Control control in form.Controls)
            {
                Button button = control as Button;
                int aleatorio;
                if (button == null) continue;
                switch (button.Name)
                {
                    case "btnBotao00":
                        aleatorio = ran.Next(0, 2);
                        button.Text = ((Botao00)aleatorio).ToString();
                        break;
                    case "btnBotao01":
                        aleatorio = ran.Next(0, 2);
                        button.Text = ((Botao01)aleatorio).ToString();
                        break;
                    case "btnBotao02":
                        aleatorio = ran.Next(0, 2);
                        button.Text = ((Botao02)aleatorio).ToString();
                        break;
                    case "btnBotao10":
                        aleatorio = ran.Next(0, 3);
                        button.Text = ((Botao10)aleatorio).ToString();
                        break;
                    case "btnBotao11":
                        aleatorio = ran.Next(0, 3);
                        button.Text = ((Botao11)aleatorio).ToString();
                        break;
                    case "btnBotao12":
                        aleatorio = ran.Next(0, 2);
                        button.Text = ((Botao12)aleatorio).ToString();
                        break;
                    case "btnBotao20":
                        aleatorio = ran.Next(0, 3);
                        button.Text = ((Botao20)aleatorio).ToString();
                        break;
                    case "btnBotao21":
                        aleatorio = ran.Next(0, 3);
                        button.Text = ((Botao21)aleatorio).ToString();
                        break;
                    case "btnBotao22":
                        aleatorio = ran.Next(0, 3);
                        button.Text = ((Botao22)aleatorio).ToString();
                        break;
                }
            }
            form.Show();
        }
    }
}
