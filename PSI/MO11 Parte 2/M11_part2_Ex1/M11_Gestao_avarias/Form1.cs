using System.Windows.Forms;

namespace M11_Gestao_avarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            String data = dtpData.Value.ToString();
            if (txtModelo.Text != "" && txtAvaria.Text != "")
            {
                String modelo = txtModelo.Text;
                String avaria = txtAvaria.Text;
                dgvGrelha.Rows.Add(data, modelo, avaria);
            }
            else
            {
                MessageBox.Show
                 (
                    "Preencha os dados corretamente", "Erro",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                 );
            }
        }

        void remocao(String data, String modelo, String avaria)
        {

        }
        private void btnReparado_Click(object sender, EventArgs e)
        {
            if(dgvGrelha.Rows.Count>0)
            {
                dgvGrelha.Rows.Remove(dgvGrelha.CurrentRow); //Remove a linha selecionada
            }
            else
            {
                MessageBox.Show
                (
                 "Selecione uma linha.", "Sem item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
            }
        }
    }
}
