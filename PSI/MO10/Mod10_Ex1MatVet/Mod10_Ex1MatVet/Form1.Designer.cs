namespace Mod10_Ex1MatVet
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbVetor1 = new System.Windows.Forms.GroupBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.btnInserir1 = new System.Windows.Forms.Button();
            this.lblPosicao1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbVetor2 = new System.Windows.Forms.GroupBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPosicao2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnApresentar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lstVetor1 = new System.Windows.Forms.ListBox();
            this.lstVetor2 = new System.Windows.Forms.ListBox();
            this.lstSoma = new System.Windows.Forms.ListBox();
            this.grbVetor1.SuspendLayout();
            this.grbVetor2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbVetor1
            // 
            this.grbVetor1.Controls.Add(this.txtValor1);
            this.grbVetor1.Controls.Add(this.btnInserir1);
            this.grbVetor1.Controls.Add(this.lblPosicao1);
            this.grbVetor1.Controls.Add(this.label2);
            this.grbVetor1.Controls.Add(this.label1);
            this.grbVetor1.Location = new System.Drawing.Point(35, 26);
            this.grbVetor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbVetor1.Name = "grbVetor1";
            this.grbVetor1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbVetor1.Size = new System.Drawing.Size(279, 166);
            this.grbVetor1.TabIndex = 0;
            this.grbVetor1.TabStop = false;
            this.grbVetor1.Text = "Vetor 1";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(108, 82);
            this.txtValor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(51, 22);
            this.txtValor1.TabIndex = 4;
            // 
            // btnInserir1
            // 
            this.btnInserir1.Location = new System.Drawing.Point(179, 52);
            this.btnInserir1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserir1.Name = "btnInserir1";
            this.btnInserir1.Size = new System.Drawing.Size(69, 53);
            this.btnInserir1.TabIndex = 3;
            this.btnInserir1.Text = "Inserir";
            this.btnInserir1.UseVisualStyleBackColor = true;
            this.btnInserir1.Click += new System.EventHandler(this.btnInserir1_Click);
            // 
            // lblPosicao1
            // 
            this.lblPosicao1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPosicao1.Location = new System.Drawing.Point(113, 52);
            this.lblPosicao1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosicao1.Name = "lblPosicao1";
            this.lblPosicao1.Size = new System.Drawing.Size(49, 24);
            this.lblPosicao1.TabIndex = 2;
            this.lblPosicao1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posição";
            // 
            // grbVetor2
            // 
            this.grbVetor2.Controls.Add(this.txtValor2);
            this.grbVetor2.Controls.Add(this.btnInserir2);
            this.grbVetor2.Controls.Add(this.label6);
            this.grbVetor2.Controls.Add(this.lblPosicao2);
            this.grbVetor2.Controls.Add(this.label5);
            this.grbVetor2.Location = new System.Drawing.Point(369, 26);
            this.grbVetor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbVetor2.Name = "grbVetor2";
            this.grbVetor2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbVetor2.Size = new System.Drawing.Size(279, 166);
            this.grbVetor2.TabIndex = 1;
            this.grbVetor2.TabStop = false;
            this.grbVetor2.Text = "Vetor 2";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(108, 82);
            this.txtValor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(56, 22);
            this.txtValor2.TabIndex = 9;
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(173, 52);
            this.btnInserir2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(69, 53);
            this.btnInserir2.TabIndex = 8;
            this.btnInserir2.Text = "Inserir";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Posição";
            // 
            // lblPosicao2
            // 
            this.lblPosicao2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPosicao2.Location = new System.Drawing.Point(108, 52);
            this.lblPosicao2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosicao2.Name = "lblPosicao2";
            this.lblPosicao2.Size = new System.Drawing.Size(49, 24);
            this.lblPosicao2.TabIndex = 7;
            this.lblPosicao2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor";
            // 
            // btnApresentar
            // 
            this.btnApresentar.Location = new System.Drawing.Point(101, 218);
            this.btnApresentar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApresentar.Name = "btnApresentar";
            this.btnApresentar.Size = new System.Drawing.Size(232, 42);
            this.btnApresentar.TabIndex = 2;
            this.btnApresentar.Text = "Apresentar Valores";
            this.btnApresentar.UseVisualStyleBackColor = true;
            this.btnApresentar.Click += new System.EventHandler(this.btnApresentar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(396, 218);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(104, 42);
            this.btnSomar.TabIndex = 3;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lstVetor1
            // 
            this.lstVetor1.FormattingEnabled = true;
            this.lstVetor1.ItemHeight = 16;
            this.lstVetor1.Location = new System.Drawing.Point(109, 273);
            this.lstVetor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVetor1.Name = "lstVetor1";
            this.lstVetor1.Size = new System.Drawing.Size(103, 164);
            this.lstVetor1.TabIndex = 4;
            this.lstVetor1.SelectedIndexChanged += new System.EventHandler(this.lstVetor1_SelectedIndexChanged);
            // 
            // lstVetor2
            // 
            this.lstVetor2.FormattingEnabled = true;
            this.lstVetor2.ItemHeight = 16;
            this.lstVetor2.Location = new System.Drawing.Point(221, 273);
            this.lstVetor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVetor2.Name = "lstVetor2";
            this.lstVetor2.Size = new System.Drawing.Size(103, 164);
            this.lstVetor2.TabIndex = 5;
            // 
            // lstSoma
            // 
            this.lstSoma.FormattingEnabled = true;
            this.lstSoma.ItemHeight = 16;
            this.lstSoma.Location = new System.Drawing.Point(396, 267);
            this.lstSoma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSoma.Name = "lstSoma";
            this.lstSoma.Size = new System.Drawing.Size(103, 164);
            this.lstSoma.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lstSoma);
            this.Controls.Add(this.lstVetor2);
            this.Controls.Add(this.lstVetor1);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnApresentar);
            this.Controls.Add(this.grbVetor2);
            this.Controls.Add(this.grbVetor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soma de vetores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbVetor1.ResumeLayout(false);
            this.grbVetor1.PerformLayout();
            this.grbVetor2.ResumeLayout(false);
            this.grbVetor2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbVetor1;
        private System.Windows.Forms.Button btnInserir1;
        private System.Windows.Forms.Label lblPosicao1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbVetor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnInserir2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPosicao2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApresentar;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.ListBox lstVetor1;
        private System.Windows.Forms.ListBox lstVetor2;
        private System.Windows.Forms.ListBox lstSoma;
    }
}

