using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registos_de_Visitas_Ex2
{
    public partial class Form1 : Form
    {

        struct info
        {
            public string Nome, Documento, Tipo, Visitado;
            public double Numero;
            public DateTime Data, Hora;
        }

        info Visitas;

        LinkedList<info> Lista = new LinkedList<info>();
        LinkedListNode<info> Nolista;

        string procura;

        private void Ativar(bool estado)
        {
            txtNome.Enabled = estado;
            cboDocumento.Enabled = estado;
            txtNumero.Enabled = estado;
            txtVisitado.Enabled = estado;
            mtxHora.Enabled = estado;
            tsbNovo.Enabled = estado;
            tsbAnular.Enabled = estado;
            tsbGuardar.Enabled = estado;
        }

        private void Limpar()
        {
            foreach (Object controlo in this.Controls)
            {
                if (controlo is TextBox) ((TextBox)controlo).ResetText();
                if (controlo is ComboBox) ((ComboBox)controlo).ResetText();
                if (controlo is MaskedTextBox) ((MaskedTextBox)controlo).ResetText();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ativar(false);
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            Ativar(false);
            Limpar();
            tsbNovo.Checked = false;
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            Ativar(false);
            Limpar();
            tsbNovo.Checked=false;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (tsbNovo.Checked)
            {
                if (txtNome.Text != "" && mtxHora.MaskCompleted == true)
                {
                    Visitas.Nome = txtNome.Text;
                    Visitas.Documento = cboDocumento.Text;

                    double numero;
                    bool validar = double.TryParse(txtNumero.Text, out numero);
                    if (validar == true)
                        Visitas.Numero = Double.Parse(txtNumero.Text);
                    else
                        Visitas.Numero = numero;

                    Visitas.Tipo = cboTipo.Text;
                    Visitas.Visitado = txtVisitado.Text;
                    Visitas.Data = DateTime.Parse(dtpData.Text);
                    Visitas.Hora = DateTime.Parse(mtxHora.Text);

                    Lista.AddLast(Visitas);

                    dgvGrelha1.Rows.Add(txtNome.Text, mtxHora.Text);

                    tsbAnular.PerformClick();
                }
                else
                {
                    MessageBox.Show("Os campos Nome e Hora São de preechimento obrigatoria", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {
            int linha = dgvGrelha1.CurrentRow.Index;
            procura = dgvGrelha1[0, linha].Value.ToString();

            frmConsulta formulario = new frmConsulta();
            formulario.lblNome.Text = procura;


        }


        private void tsbAtualizar_Click(object sender, EventArgs e)
        {
            dgvGrelha1.Rows.Clear();

            foreach (info Visitas in Lista)
            {
                dgvGrelha1.Rows.Add(Visitas.Nome, Visitas.Hora);
            }
        }


        private void btnProcuraTipo_Click(object sender, EventArgs e)
        {
            if(cboTipo.Text != "")
            {
                dgvGrelha1.Rows.Clear();

                foreach (info Visitas in Lista)
                {
                    if (Visitas.Tipo == cboTipo.Text)
                        dgvGrelha1.Rows.Add(Visitas.Nome, Visitas.Hora);
                }
            }
        }

        private void btnProcuraData_Click(object sender, EventArgs e)
        {
            dgvGrelha1.Rows.Clear();

            foreach(info Visitas in Lista)
            {
                if (Visitas.Data == DateTime.Parse(dtpData.Text))
                    dgvGrelha1.Rows.Add(Visitas.Nome, Visitas.Hora);
            }
        }

        
    }
}
