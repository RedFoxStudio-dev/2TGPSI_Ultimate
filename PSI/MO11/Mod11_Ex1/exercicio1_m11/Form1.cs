using System.IO;

namespace exercicio1_m11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void mtxtTexto_TextChanged(object sender, EventArgs e)
        {
            string CP, morada, morada2, locaalidade;

            label2.ResetText();
            label7.ResetText();
            label8.ResetText();
            if (mtxtTexto.MaskCompleted == true)
            {
                FileStream ficheiro = new FileStream(@"C:\Users\espec\source\repos\exercicio1_m11\exercicio1_m11\bin\Debug\FicheiroCP.txt", FileMode.Open, FileAccess.Read);
                BinaryReader BR = new BinaryReader(ficheiro);

                while (BR.PeekChar() != -1)
                {
                    CP = BR.ReadString();
                    morada = BR.ReadString();
                    morada2 = BR.ReadString();
                    locaalidade = BR.ReadString();

                    if (CP == mtxtTexto.Text)
                    {
                        label2.Text = morada.ToUpper();
                        label7.Text = morada2.ToUpper();
                        label8.Text = morada2.ToUpper();
                    }
                }
                BR.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
