using Microsoft.Win32;

namespace ex3_m11
{

    public partial class Form1 : Form
    {
        public string[] Nomes = new string[10]; //guarda os nomes
        public int[,] Notas = new int[10, 3];
        public int registo; // controla novos registos 
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //verificar se preeencheu o campo Nome
            if (txtNome.Text != "")
            {
                //verifica se ainda nao atingiu o limite da capacidade do array
                if (registo < 9)
                {
                    //adicionar o registo
                    Nomes[registo] = txtNome.Text;
                    //adicionar as notas
                    Notas[registo, 0] = int.Parse(nudPortugues.Value.ToString());
                    Notas[registo, 1] = int.Parse(nudMatematica.Value.ToString());
                    Notas[registo, 2] = int.Parse(nudTIC.Value.ToString());

                    //atualizar variavel para o proximo registo
                    registo++;

                    //simular o click no botão limpar desta forma evocamos as instrucoes do controlo
                    btnLimpar.PerformClick();
                }

                else
                {
                    MessageBox.Show("Array completo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Indique o nome", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //criar uma instancia do formulario consulta
            Frmconsulta formulario = new Frmconsulta();

            //variaveis necessarias para o calculo
            double Media;
            string Situacao;

            //percorrer todos os registos já inseridos
            for (int linha = 0; linha <= registo - 1; linha++)
            {
                //calcular a media
                Media = (Notas[linha, 0] + Notas[linha, 1] + Notas[linha, 2]) / 3;

                //verificar a situacao
                if (Media >= 10) Situacao = "Aprovado";
                else Situacao = "Reprovado";

                //Adiciona  uma linha ao controlo Datagrd com os valores
                formulario.dgvGrelha.Rows.Add(Nomes[linha].ToString(),
                    Notas[linha, 0].ToString(), Notas[linha, 1].ToString(),
                    Notas[linha, 2].ToString(), Media.ToString("F2"), Situacao);
            }

            //apresentar o formulario
            formulario.Show();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //repor o ambiente
            nudPortugues.Value = 10;
            nudMatematica.Value = 10;
            nudTIC.Value = 10;
            txtNome.ResetText();
            //colocar o curso no controlo TextBox
            txtNome.Focus();
        }
    }
}
