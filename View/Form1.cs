using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_CacaPalavra.Controller;
using Trabalho_CacaPalavra.Model;

namespace Trabalho_CacaPalavra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GeraBotoes();
        }

        private void btnNovoCacaPalavra_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            foreach (var item in lstPalavras.Items)
            {
                lista.Add(item.ToString());
            }
            int pontos = ControllerForm1.GerarPontuacao(lista);
            MessageBox.Show("Sua pontuação foi de: " + pontos);
            GeraBotoes();
            lblPalavraAtual.Text = "";
            lstPalavras.Items.Clear();
        }
        public void GeraBotoes()
        {
            Botoes botoes = ControllerForm1.GerarBotoes();
            btnBotao00.Text = botoes.B00;
            btnBotao01.Text = botoes.B01;
            btnBotao02.Text = botoes.B02;
            btnBotao10.Text = botoes.B10;
            btnBotao11.Text = botoes.B11;
            btnBotao12.Text = botoes.B12;
            btnBotao20.Text = botoes.B20;
            btnBotao21.Text = botoes.B21;
            btnBotao22.Text = botoes.B22;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBotao00_Click(object sender, EventArgs e)
        {
            lblPalavraAtual.Text += btnBotao00.Text;
        }

        private void btnBotao01_Click(object sender, EventArgs e)
        {
            lblPalavraAtual.Text += btnBotao01.Text;
        }

        private void btnBotao02_Click(object sender, EventArgs e)
        {
            lblPalavraAtual.Text += btnBotao02.Text;
        }

        private void btnBotao10_Click(object sender, EventArgs e)
        {
            lblPalavraAtual.Text += btnBotao10.Text;
        }

        private void btnBotao11_Click(object sender, EventArgs e)
        {
            lblPalavraAtual.Text += btnBotao11.Text;
        }

        private void btnBotao12_Click(object sender, EventArgs e)
        {
            lblPalavraAtual.Text += btnBotao12.Text;
        }

        private void btnBotao20_Click(object sender, EventArgs e)
        {
            lblPalavraAtual.Text += btnBotao20.Text;
        }

        private void btnBotao21_Click(object sender, EventArgs e)
        {
            lblPalavraAtual.Text += btnBotao21.Text;
        }

        private void btnBotao22_Click(object sender, EventArgs e)
        {
            lblPalavraAtual.Text += btnBotao22.Text;
        }
    }
}
