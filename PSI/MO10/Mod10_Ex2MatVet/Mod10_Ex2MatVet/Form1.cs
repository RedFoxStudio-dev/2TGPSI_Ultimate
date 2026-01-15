using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod10_Ex2MatVet
{
    public partial class Form1 : Form
    {

        //Declaração e criação da matriz
        int[,] matriz = new int[3, 3];

        //Variáveis globais para controlar as posições da linha e coluna
        int coluna, linha;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionar 3 linhas ao controlo DataGridView
            dgvGrelha.Rows.Add(3);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Verificar se atingiu o limite da dimensão da matriz
            if (linha <= 2)
            {
                //Guardar os valores no array
                matriz[linha, coluna] = int.Parse(txtTexto.Text);

                //Escrever o valor do array na grelha
                dgvGrelha[coluna, linha].Value = matriz[linha, coluna];

                //Atualizar valor da coluna
                coluna += 1;

                //Mudança de linha
                if(coluna > 2)
                {
                    coluna = 0;
                    linha += 1;

                    //critérios de paragem
                    if (linha == 3)
                    {
                        linha = 2;
                        btnOk.Enabled = false;
                    }
                }

                //Atualizar valores de controlo
                lblColuna.Text = coluna.ToString();
                lblLinha.Text = linha.ToString();
                //Selecionar a célula da grelha
                dgvGrelha[coluna, linha].Selected = true;
            }
            //Apagar o valor inserido e posicionar o cursor no controlo
            txtTexto.ResetText();
            txtTexto.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaração e inicialização das variáveis para o cálculo
            int par, impar, diagonal;
            par = impar = diagonal = 0;

            //percorrer todos os valores da matriz
            for(int linha = 0;linha<=2;linha++)
            {
                for(int coluna=0;coluna<=2;coluna++)
                {
                    //Verificar se é par ou ímpar
                    if (matriz[linha, coluna] % 2 == 0) par += matriz[linha, coluna];
                    else impar += matriz[linha, coluna];
                    //Verificar se é diagonal
                    if(linha==coluna) diagonal += matriz[linha, coluna];
                }
            }
            //Escrever os resultados
            lblPares.Text = par.ToString();
            lblImpares.Text = impar.ToString();
            lblDiagonal.Text = diagonal.ToString();
        }
    }
}
