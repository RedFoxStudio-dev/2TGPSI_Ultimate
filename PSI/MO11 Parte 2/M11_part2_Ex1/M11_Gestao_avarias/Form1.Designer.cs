namespace M11_Gestao_avarias
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnReparado = new Button();
            btnInserir = new Button();
            dgvGrelha = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Avaria = new DataGridViewTextBoxColumn();
            txtAvaria = new TextBox();
            txtModelo = new TextBox();
            dtpData = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvGrelha).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 22);
            label1.TabIndex = 0;
            label1.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(24, 121);
            label3.Name = "label3";
            label3.Size = new Size(56, 22);
            label3.TabIndex = 2;
            label3.Text = "Avaria:";
            // 
            // btnReparado
            // 
            btnReparado.Location = new Point(355, 247);
            btnReparado.Name = "btnReparado";
            btnReparado.Size = new Size(94, 29);
            btnReparado.TabIndex = 3;
            btnReparado.Text = "Reparado";
            btnReparado.UseVisualStyleBackColor = true;
            btnReparado.Click += btnReparado_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(245, 247);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 29);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dgvGrelha
            // 
            dgvGrelha.AllowUserToAddRows = false;
            dgvGrelha.AllowUserToDeleteRows = false;
            dgvGrelha.AllowUserToResizeColumns = false;
            dgvGrelha.AllowUserToResizeRows = false;
            dgvGrelha.BackgroundColor = SystemColors.ButtonFace;
            dgvGrelha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrelha.Columns.AddRange(new DataGridViewColumn[] { Data, Modelo, Avaria });
            dgvGrelha.Location = new Point(40, 282);
            dgvGrelha.Name = "dgvGrelha";
            dgvGrelha.RowHeadersVisible = false;
            dgvGrelha.RowHeadersWidth = 51;
            dgvGrelha.Size = new Size(379, 156);
            dgvGrelha.TabIndex = 5;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            Data.Width = 125;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.MinimumWidth = 6;
            Modelo.Name = "Modelo";
            Modelo.Width = 125;
            // 
            // Avaria
            // 
            Avaria.HeaderText = "Avaria";
            Avaria.MinimumWidth = 6;
            Avaria.Name = "Avaria";
            Avaria.Width = 125;
            // 
            // txtAvaria
            // 
            txtAvaria.Location = new Point(96, 121);
            txtAvaria.Multiline = true;
            txtAvaria.Name = "txtAvaria";
            txtAvaria.ScrollBars = ScrollBars.Vertical;
            txtAvaria.Size = new Size(250, 120);
            txtAvaria.TabIndex = 6;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(96, 72);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(250, 27);
            txtModelo.TabIndex = 7;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(96, 18);
            dtpData.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpData.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(250, 27);
            dtpData.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(dtpData);
            Controls.Add(txtModelo);
            Controls.Add(txtAvaria);
            Controls.Add(dgvGrelha);
            Controls.Add(btnInserir);
            Controls.Add(btnReparado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Avarias";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrelha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnReparado;
        private Button btnInserir;
        private DataGridView dgvGrelha;
        private TextBox txtAvaria;
        private TextBox txtModelo;
        private DateTimePicker dtpData;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Avaria;
    }
}
