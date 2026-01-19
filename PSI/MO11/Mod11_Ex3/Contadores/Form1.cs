namespace Contadores
{
    public partial class Form1 : Form
    {
        string caminho = "Leituras.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(caminho) == false)
            {
                FileStream FSFicheiros = new FileStream(caminho, FileMode.Create, FileAccess.Write);
                FSFicheiros.Close();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double gas, eletricidade, agua;

            if (cboMes.SelectedIndex == -1 && cboAno.SelectedIndex != -1)
            {
                bool validar = double.TryParse(txtGas.Text, out gas);
                if (validar == true)
                    gas = double.Parse(txtGas.Text);
                validar = double.TryParse(txtEletricidade.Text, out eletricidade);
                if (validar == true)
                    eletricidade = double.Parse(txtEletricidade.Text);
                validar = double.TryParse(txtAgua.Text, out agua);
                if (validar == true)
                    agua = int.Parse(txtAgua.Text);

                FileStream FSFicheiros = new FileStream(caminho, FileMode.Append, FileAccess.Write);
                BinaryWriter BW = new BinaryWriter(FSFicheiros);

                BW.Write(cboMes.Text);
                BW.Write(cboAno.Text);
                BW.Write(dtpData.Text);
                BW.Write(gas);
                BW.Write(eletricidade);
                BW.Write(agua);
                BW.Close();

                cboMes.SelectedIndex = -1;
                cboAno.SelectedIndex = -1;
                dtpData.Value = DateTime.Today;
                txtGas.ResetText();
                txtEletricidade.ResetText();
                txtAgua.ResetText();
            }

            else
            {
                MessageBox.Show("Preencha os campos Mês e ano", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmListar formulario = new FrmListar();
            FileStream FSFicheiro = new FileStream(caminho, FileMode.Open, FileAccess.Read);
            BinaryReader BR = new BinaryReader(FSFicheiro);

            string mes, ano, data;
            double gas, eletricidade, agua;

            while(BR.PeekChar() != -1)
            {
                mes = BR.ReadString();
                ano = BR.ReadString();
                data = BR.ReadString();
                gas = BR.ReadDouble();
                eletricidade = BR.ReadDouble();
                agua = BR.ReadDouble();

                formulario.dgvRegistos.Rows.Add(mes, ano, data, gas, eletricidade, agua);
            }

            BR.Close();
            formulario.Show();
        }
    }
}
