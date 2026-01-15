using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod10_Ex1MatVet
{
    public partial class Form1 : Form
    {
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];
        int Posicao1, Posicao2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPosicao1.Text = Posicao1.ToString();
            lblPosicao2.Text = Posicao2.ToString();
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text != "")
            {
                vetor1[Posicao1] = int.Parse(txtValor1.Text);
                Posicao1++;
                lblPosicao1.Text = Posicao1.ToString();
                txtValor1.ResetText();
                txtValor1.Focus();

                if (Posicao1 > 9)
                {
                    btnInserir1.Enabled = false;
                    txtValor1.Enabled = false;
                }
            }
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            if (txtValor2.Text != "")
            {
                vetor2[Posicao2] = int.Parse(txtValor2.Text);
                Posicao2++;
                lblPosicao2.Text = Posicao2.ToString();
                txtValor2.ResetText();
                txtValor2.Focus();

                if (Posicao2 > 9)
                {
                    btnInserir2.Enabled = false;
                    txtValor2.Enabled = false;
                }
            }
        }

        private void btnApresentar_Click(object sender, EventArgs e)
        {
            if (Posicao1 > 9 && Posicao2 > 9)
            {
                lstVetor1.Items.Clear();
                lstVetor2.Items.Clear();

                for (int ctd = 0; ctd <= 9; ctd++)
                    lstVetor1.Items.Add(vetor1[ctd]);

                for (int ctd = 0; ctd <= 9; ctd++)
                    lstVetor2.Items.Add(vetor2[ctd]);
            }
            else
            {
                MessageBox.Show("os vetores não estão preenchidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (Posicao1 > 9 && Posicao2 > 9)
            {
                lstSoma.Items.Clear();

                for (int ctd = 0; ctd <= 9; ctd++)
                    lstSoma.Items.Add(vetor1[ctd] + vetor2[ctd]);
            }
            else
            {
                MessageBox.Show("os vetores não estão preenchidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstVetor1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
