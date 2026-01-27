namespace Registos_de_Visitas_Ex2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsbBarra = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbAtualizar = new System.Windows.Forms.ToolStripButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVisitado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnProcuraData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxHora = new System.Windows.Forms.MaskedTextBox();
            this.dgvGrelha1 = new System.Windows.Forms.DataGridView();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnProcuraTipo = new System.Windows.Forms.Button();
            this.tsbBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbBarra
            // 
            this.tsbBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbAnular,
            this.tsbGuardar,
            this.btnConsultar,
            this.tsbAtualizar});
            this.tsbBarra.Location = new System.Drawing.Point(0, 0);
            this.tsbBarra.Name = "tsbBarra";
            this.tsbBarra.Size = new System.Drawing.Size(800, 25);
            this.tsbBarra.TabIndex = 0;
            this.tsbBarra.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(56, 22);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbAnular
            // 
            this.tsbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnular.Image")));
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(62, 22);
            this.tsbAnular.Text = "Anular";
            this.tsbAnular.Click += new System.EventHandler(this.tsbAnular_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.tsbConsultar_Click);
            // 
            // tsbAtualizar
            // 
            this.tsbAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAtualizar.Image")));
            this.tsbAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtualizar.Name = "tsbAtualizar";
            this.tsbAtualizar.Size = new System.Drawing.Size(73, 22);
            this.tsbAtualizar.Text = "Atualizar";
            this.tsbAtualizar.Click += new System.EventHandler(this.tsbAtualizar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(128, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Documento";
            // 
            // cboDocumento
            // 
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Items.AddRange(new object[] {
            "Cartão de cidadão",
            "Passaporte",
            "Bilhete de identidade",
            "Carta de condução",
            "Outro..."});
            this.cboDocumento.Location = new System.Drawing.Point(66, 113);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(133, 21);
            this.cboDocumento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(284, 110);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(101, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vistado";
            // 
            // txtVisitado
            // 
            this.txtVisitado.Location = new System.Drawing.Point(67, 237);
            this.txtVisitado.Name = "txtVisitado";
            this.txtVisitado.Size = new System.Drawing.Size(132, 20);
            this.txtVisitado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(52, 299);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(142, 20);
            this.dtpData.TabIndex = 13;
            // 
            // btnProcuraData
            // 
            this.btnProcuraData.Image = global::Registos_de_Visitas_Ex2.Properties.Resources.lupa;
            this.btnProcuraData.Location = new System.Drawing.Point(215, 289);
            this.btnProcuraData.Name = "btnProcuraData";
            this.btnProcuraData.Size = new System.Drawing.Size(36, 33);
            this.btnProcuraData.TabIndex = 15;
            this.btnProcuraData.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hora";
            // 
            // mtxHora
            // 
            this.mtxHora.Location = new System.Drawing.Point(317, 305);
            this.mtxHora.Mask = "00:00";
            this.mtxHora.Name = "mtxHora";
            this.mtxHora.Size = new System.Drawing.Size(57, 20);
            this.mtxHora.TabIndex = 17;
            // 
            // dgvGrelha1
            // 
            this.dgvGrelha1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrelha1.Location = new System.Drawing.Point(477, 179);
            this.dgvGrelha1.Name = "dgvGrelha1";
            this.dgvGrelha1.Size = new System.Drawing.Size(268, 197);
            this.dgvGrelha1.TabIndex = 18;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Particular",
            "Empresa:Comercial",
            "Técnica/Assistência",
            "Vista de Estudo",
            "Outra..."});
            this.cboTipo.Location = new System.Drawing.Point(67, 177);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(133, 21);
            this.cboTipo.TabIndex = 19;
            // 
            // btnProcuraTipo
            // 
            this.btnProcuraTipo.Image = global::Registos_de_Visitas_Ex2.Properties.Resources.lupa;
            this.btnProcuraTipo.Location = new System.Drawing.Point(206, 177);
            this.btnProcuraTipo.Name = "btnProcuraTipo";
            this.btnProcuraTipo.Size = new System.Drawing.Size(31, 28);
            this.btnProcuraTipo.TabIndex = 20;
            this.btnProcuraTipo.UseVisualStyleBackColor = true;
            this.btnProcuraTipo.Click += new System.EventHandler(this.btnProcuraTipo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcuraTipo);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.dgvGrelha1);
            this.Controls.Add(this.mtxHora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnProcuraData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVisitado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.tsbBarra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tsbBarra.ResumeLayout(false);
            this.tsbBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsbBarra;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVisitado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnProcuraData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxHora;
        private System.Windows.Forms.DataGridView dgvGrelha1;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnProcuraTipo;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripButton tsbAtualizar;
    }
}

