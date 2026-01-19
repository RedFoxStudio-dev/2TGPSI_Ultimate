namespace Contadores
{
    partial class FrmListar
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
            dgvRegistos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRegistos).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistos
            // 
            dgvRegistos.AllowUserToDeleteRows = false;
            dgvRegistos.AllowUserToResizeColumns = false;
            dgvRegistos.AllowUserToResizeRows = false;
            dgvRegistos.BackgroundColor = SystemColors.ButtonFace;
            dgvRegistos.BorderStyle = BorderStyle.None;
            dgvRegistos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvRegistos.Dock = DockStyle.Fill;
            dgvRegistos.Location = new Point(0, 0);
            dgvRegistos.Name = "dgvRegistos";
            dgvRegistos.RowHeadersVisible = false;
            dgvRegistos.Size = new Size(800, 450);
            dgvRegistos.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mês";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 50F;
            Column2.HeaderText = "Ano";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "Data";
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Gás";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Eletricidade";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Água";
            Column6.Name = "Column6";
            // 
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRegistos);
            Name = "FrmListar";
            Text = "FrmListar";
            ((System.ComponentModel.ISupportInitialize)dgvRegistos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvRegistos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}