using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex40_Freguesias
{
    public partial class Form1 : Form
    {
        string caminhoDistrito = "Distritos.txt";
        string caminhoConcelho = "Concelhos.txt";
        string caminhoFreguesias = "Freguesias.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Definição das instâncias para manuseamento dos ficheiros de texto
            FileStream FSficheiro = new FileStream(caminhoDistrito, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FSficheiro, System.Text.Encoding.UTF7);

            //Definição da variavel que guardará uma linha do ficheiro
            string lerlinha;  
           
            /*ciclo de repetição que irá ler linha a linha 
             * até encontrar o fim do ficheiro*/
            while (SR.Peek()!= -1)
            {
                //leitura de uma linha
                lerlinha = SR.ReadLine();
                //Escrevero seu conteúdo no controlo
                cboDistrito.Items.Add(lerlinha);
            }
            //Fechar o ficheiro e libertar os recursos
            SR.Close();

        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Definição das instâncias para manuseamento dos ficheiros de texto
            FileStream FSficheiro = new FileStream(caminhoConcelho, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FSficheiro, System.Text.Encoding.UTF7);

            //Definição da variavel que guardará uma linha do ficheiro
            string lerlinha;  
            //Variáveis que iram guardar o conteúdo dos conteúdos
            string Distrito, Concelho;
            //Variável que irá guardar a posição do delimitador
            int p1;

            //limpar o conteúdos os controlos Concelho e freguesias
            cboConcelho.Items.Clear();
            lstFreguesias.Items.Clear();

            /*ciclo de repetição que irá ler linha a linha 
            * até encontrar o fim do ficheiro*/
            while (SR.Peek() != -1)
            {
                //Ler uma linha
                lerlinha = SR.ReadLine();
                
                //Guardar a posição do delimitador            
                p1 = lerlinha.IndexOf(";")+1;
                //Separar o conteúdo da linha pelos campos
                Distrito = lerlinha.Substring(0, p1 - 1);
                Concelho = lerlinha.Substring(p1);

                /*Verificar se o distrito lido coincide com o selecionado
                 * e, em caso afirmativo, adiciona ao controlo Concelho*/
                if(Distrito==cboDistrito.Text)
                cboConcelho.Items.Add(Concelho);
            }

            //Fecha o ficheiro e liberta os recursos
            SR.Close();

        }

        private void cboConcelho_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Definição das instâncias para manuseamento dos ficheiros de texto
            FileStream FSficheiro = new FileStream(caminhoFreguesias, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FSficheiro, System.Text.Encoding.UTF7);
            
            //Definição da variavel que guardará uma linha do ficheiro
            string lerlinha;
            //Variáveis que iram guardar o conteúdo dos conteúdos
            string Concelho, Freguesia;
            //Variável que irá guardar a posição do delimitador
            int p1;
            
            //limpar o conteúdo o controlo freguesias
            lstFreguesias.Items.Clear();
            /*ciclo de repetição que irá ler linha a linha 
             * até encontrar o fim do ficheiro*/
            while (SR.Peek() != -1)
            {
                //Ler uma linha
                lerlinha = SR.ReadLine();
                
                //Guardar a posição do delimitador 
                p1 = lerlinha.IndexOf(";") + 1;
                //Separar o conteúdo da linha pelos campos
                Concelho = lerlinha.Substring(0, p1 - 1);
                Freguesia = lerlinha.Substring(p1);
                /*Verificar se o concelho lido coincide com o selecionado
                 * e, em caso afirmativo, adiciona ao controlo freguesias*/
                if (Concelho == cboConcelho.Text)
                    lstFreguesias.Items.Add(Freguesia);
            }
            //Fecha o ficheiro e liberta os recursos
            SR.Close();
        }
    }
}
