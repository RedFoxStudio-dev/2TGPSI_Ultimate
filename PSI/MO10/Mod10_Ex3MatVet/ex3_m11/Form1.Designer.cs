namespace ex3_m11
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
            label4 = new Label();
            txtNome = new TextBox();
            nudPortugues = new NumericUpDown();
            btnInserir = new Button();
            btnLimpar = new Button();
            btnConsultar = new Button();
            nudMatematica = new NumericUpDown();
            nudTIC = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPortugues).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMatematica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTIC).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 57);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 188);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Matematica";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 139);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Portugues";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 237);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 3;
            label4.Text = "Tic";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 4;
            // 
            // nudPortugues
            // 
            nudPortugues.Location = new Point(155, 137);
            nudPortugues.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPortugues.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPortugues.Name = "nudPortugues";
            nudPortugues.Size = new Size(68, 27);
            nudPortugues.TabIndex = 5;
            nudPortugues.TextAlign = HorizontalAlignment.Center;
            nudPortugues.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(271, 137);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 29);
            btnInserir.TabIndex = 8;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(271, 186);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(271, 237);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // nudMatematica
            // 
            nudMatematica.Location = new Point(155, 188);
            nudMatematica.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudMatematica.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMatematica.Name = "nudMatematica";
            nudMatematica.Size = new Size(68, 27);
            nudMatematica.TabIndex = 11;
            nudMatematica.TextAlign = HorizontalAlignment.Center;
            nudMatematica.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nudTIC
            // 
            nudTIC.Location = new Point(155, 239);
            nudTIC.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudTIC.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTIC.Name = "nudTIC";
            nudTIC.Size = new Size(68, 27);
            nudTIC.TabIndex = 12;
            nudTIC.TextAlign = HorizontalAlignment.Center;
            nudTIC.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudTIC);
            Controls.Add(nudMatematica);
            Controls.Add(btnConsultar);
            Controls.Add(btnLimpar);
            Controls.Add(btnInserir);
            Controls.Add(nudPortugues);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registo de avaliaçao";
            ((System.ComponentModel.ISupportInitialize)nudPortugues).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMatematica).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTIC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private NumericUpDown nudPortugues;
        private Button btnInserir;
        private Button btnLimpar;
        private Button btnConsultar;
        private NumericUpDown nudMatematica;
        private NumericUpDown nudTIC;
    }
}
