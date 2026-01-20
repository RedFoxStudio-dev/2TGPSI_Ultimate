namespace Ex43_Temperaturas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstacao = new System.Windows.Forms.ComboBox();
            this.dgvTemperaturas = new System.Windows.Forms.DataGridView();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemperaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estações Meteorológicas";
            // 
            // cboEstacao
            // 
            this.cboEstacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstacao.FormattingEnabled = true;
            this.cboEstacao.Location = new System.Drawing.Point(30, 41);
            this.cboEstacao.Name = "cboEstacao";
            this.cboEstacao.Size = new System.Drawing.Size(180, 21);
            this.cboEstacao.TabIndex = 1;
            this.cboEstacao.SelectedIndexChanged += new System.EventHandler(this.cboCidade_SelectedIndexChanged);
            // 
            // dgvTemperaturas
            // 
            this.dgvTemperaturas.AllowUserToAddRows = false;
            this.dgvTemperaturas.AllowUserToDeleteRows = false;
            this.dgvTemperaturas.AllowUserToResizeColumns = false;
            this.dgvTemperaturas.AllowUserToResizeRows = false;
            this.dgvTemperaturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTemperaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemperaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ano,
            this.Temp});
            this.dgvTemperaturas.Location = new System.Drawing.Point(30, 87);
            this.dgvTemperaturas.Name = "dgvTemperaturas";
            this.dgvTemperaturas.ReadOnly = true;
            this.dgvTemperaturas.RowHeadersVisible = false;
            this.dgvTemperaturas.Size = new System.Drawing.Size(180, 240);
            this.dgvTemperaturas.TabIndex = 2;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            this.Ano.Width = 75;
            // 
            // Temp
            // 
            this.Temp.HeaderText = "Temp";
            this.Temp.Name = "Temp";
            this.Temp.ReadOnly = true;
            this.Temp.Width = 75;
            // 
            // chtGrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea1);
            this.chtGrafico.Location = new System.Drawing.Point(216, 87);
            this.chtGrafico.Name = "chtGrafico";
            this.chtGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Name = "Series1";
            this.chtGrafico.Series.Add(series1);
            this.chtGrafico.Size = new System.Drawing.Size(438, 240);
            this.chtGrafico.TabIndex = 3;
            this.chtGrafico.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dados registados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gráfico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chtGrafico);
            this.Controls.Add(this.dgvTemperaturas);
            this.Controls.Add(this.cboEstacao);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Temperatura Média Anual";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemperaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstacao;
        private System.Windows.Forms.DataGridView dgvTemperaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

