namespace ex3_m11
{
    partial class Frmconsulta
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvGrelha = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Port = new DataGridViewTextBoxColumn();
            Mat = new DataGridViewTextBoxColumn();
            TIC = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvGrelha).BeginInit();
            SuspendLayout();
            // 
            // dgvGrelha
            // 
            dgvGrelha.AllowUserToAddRows = false;
            dgvGrelha.AllowUserToDeleteRows = false;
            dgvGrelha.AllowUserToResizeColumns = false;
            dgvGrelha.AllowUserToResizeRows = false;
            dgvGrelha.BackgroundColor = SystemColors.ButtonFace;
            dgvGrelha.BorderStyle = BorderStyle.None;
            dgvGrelha.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvGrelha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrelha.ColumnHeadersVisible = false;
            dgvGrelha.Columns.AddRange(new DataGridViewColumn[] { Nome, Port, Mat, TIC, Column5, Situacao });
            dgvGrelha.GridColor = Color.Black;
            dgvGrelha.Location = new Point(99, 68);
            dgvGrelha.Name = "dgvGrelha";
            dgvGrelha.RowHeadersVisible = false;
            dgvGrelha.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.Cyan;
            dgvGrelha.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGrelha.Size = new Size(300, 188);
            dgvGrelha.TabIndex = 0;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 150;
            // 
            // Port
            // 
            Port.HeaderText = "Port";
            Port.MinimumWidth = 6;
            Port.Name = "Port";
            Port.Width = 50;
            // 
            // Mat
            // 
            Mat.HeaderText = "Mat";
            Mat.MinimumWidth = 6;
            Mat.Name = "Mat";
            Mat.Width = 50;
            // 
            // TIC
            // 
            TIC.HeaderText = "TIC";
            TIC.MinimumWidth = 6;
            TIC.Name = "TIC";
            TIC.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "Média";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 70;
            // 
            // Situacao
            // 
            Situacao.HeaderText = "Situação";
            Situacao.MinimumWidth = 6;
            Situacao.Name = "Situacao";
            // 
            // Frmconsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvGrelha);
            Name = "Frmconsulta";
            Text = "Frmconsulta";
            ((System.ComponentModel.ISupportInitialize)dgvGrelha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvGrelha;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Port;
        private DataGridViewTextBoxColumn Mat;
        private DataGridViewTextBoxColumn TIC;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Situacao;
    }
}