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
            ControllerForm1.GerarPontuacao(lista);
            MessageBox.Show("Sua pontuação foi de: " + Jogador.Acertos, "Pontuação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GeraBotoes();
            txtPalavraAtual.Text = "";
            lstPalavras.Items.Clear();
        }
        public void GeraBotoes()
        {
            ControllerForm1.GerarBotoes();
            btnBotao00.Text = Botoes.B00;
            btnBotao01.Text = Botoes.B01;
            btnBotao02.Text = Botoes.B02;
            btnBotao10.Text = Botoes.B10;
            btnBotao11.Text = Botoes.B11;
            btnBotao12.Text = Botoes.B12;
            btnBotao20.Text = Botoes.B20;
            btnBotao21.Text = Botoes.B21;
            btnBotao22.Text = Botoes.B22;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }



        private void btnTentarPalavra_Click(object sender, EventArgs e)
        {
            InserirPalavra();
        }
        private void InserirPalavra()
        {
            List<string> lista = new List<string>();
            foreach (var item in lstPalavras.Items)
            {
                lista.Add(item.ToString());
            }
            int resultado = ControllerForm1.VerificarPalavra(txtPalavraAtual.Text.ToUpper(), lista);
            if (resultado == 0)
            {
                lstPalavras.Items.Add(txtPalavraAtual.Text.ToUpper());
                txtPalavraAtual.Text = "";
            }
            else if (resultado == 1)
            {
                txtPalavraAtual.Text = "";
                MessageBox.Show("Você deve inserir uma palavra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultado == 2)
            {
                txtPalavraAtual.Text = "";
                MessageBox.Show("Há uma letra repetida na palavra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultado == 3)
            {
                txtPalavraAtual.Text = "";
                MessageBox.Show("Você já inseriu esta palavra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultado == 4)
            {
                txtPalavraAtual.Text = "";
                MessageBox.Show("A posição desta palavra é inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultado == 5)
            {
                txtPalavraAtual.Text = "";
                MessageBox.Show("Digite qualquer letra que esteja no layout!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       
        private void txtPalavraAtual_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                InserirPalavra();
            }

        }
    }
}
