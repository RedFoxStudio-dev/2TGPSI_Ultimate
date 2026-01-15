using System.CodeDom;

namespace Odernacao_do_Vetor_M10
{
    public partial class Form1 : Form
    {
        int[] vetor = new int[10];
        //Variavel que define a posição do Vetor
        int posicao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int numero;
            //Verificar se o número é numérico
            bool verifyNumber = int.TryParse(txtNumero.Text, out numero);
            if (verifyNumber == true)
            {
                //Guardar o valor na posição do Vetor
                vetor[posicao] = numero;
                posicao++;

                if (posicao > 9)
                {
                    btnInserir.Enabled = false;
                    txtNumero.Enabled = false;
                }

                //Repor o ambiente de inserção
                txtNumero.ResetText();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("Insira um número: ", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApresentar_Click(object sender, EventArgs e)
        {
            //Limpar a lista
            lstApresentar.Items.Clear();

            for(int ctd=0; ctd<=posicao-1; ctd++)
            {
                lstApresentar.Items.Add(vetor[ctd]);
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (posicao > 9)
            {
                //Limpar a lista
                lstOrdenar.Items.Clear();

                for (int ctd = 0; ctd <= 9; ctd++)
                {
                    for (int ctd2 = ctd; ctd2 <= 9; ctd2++)
                    {
                        if (vetor[ctd] > vetor[ctd2])
                        {
                            int aux = vetor[ctd];
                            vetor[ctd] = vetor[ctd2];
                            vetor[ctd2] = aux;
                        }
                    }
                    //Escrever no controlo o valor
                    lstOrdenar.Items.Add(vetor[ctd]);
                }   
            }
            else
            {
                MessageBox.Show($"Preencha os {posicao} valores restantes.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
