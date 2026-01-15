namespace Odernacao_do_Vetor_M10
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
            txtNumero = new TextBox();
            btnInserir = new Button();
            btnApresentar = new Button();
            btnOrdenar = new Button();
            lstApresentar = new ListBox();
            lstOrdenar = new ListBox();
            grbInsercao = new GroupBox();
            label1 = new Label();
            grbInsercao.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(75, 39);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 0;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(225, 41);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 25);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnApresentar
            // 
            btnApresentar.Location = new Point(29, 160);
            btnApresentar.Name = "btnApresentar";
            btnApresentar.Size = new Size(150, 29);
            btnApresentar.TabIndex = 2;
            btnApresentar.Text = "Apresentar Valores";
            btnApresentar.UseVisualStyleBackColor = true;
            btnApresentar.Click += btnApresentar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(194, 160);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(150, 29);
            btnOrdenar.TabIndex = 3;
            btnOrdenar.Text = "Ordenar Valores";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lstApresentar
            // 
            lstApresentar.FormattingEnabled = true;
            lstApresentar.Location = new Point(29, 208);
            lstApresentar.Name = "lstApresentar";
            lstApresentar.Size = new Size(150, 204);
            lstApresentar.TabIndex = 4;
            // 
            // lstOrdenar
            // 
            lstOrdenar.FormattingEnabled = true;
            lstOrdenar.Location = new Point(194, 208);
            lstOrdenar.Name = "lstOrdenar";
            lstOrdenar.Size = new Size(150, 204);
            lstOrdenar.TabIndex = 5;
            // 
            // grbInsercao
            // 
            grbInsercao.Controls.Add(label1);
            grbInsercao.Controls.Add(txtNumero);
            grbInsercao.Controls.Add(btnInserir);
            grbInsercao.Location = new Point(12, 12);
            grbInsercao.Name = "grbInsercao";
            grbInsercao.Size = new Size(479, 125);
            grbInsercao.TabIndex = 6;
            grbInsercao.TabStop = false;
            grbInsercao.Text = "Inserção de Valores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Número";
            // 
            // Form1
            // 
            AcceptButton = btnInserir;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 450);
            Controls.Add(grbInsercao);
            Controls.Add(lstOrdenar);
            Controls.Add(lstApresentar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnApresentar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordenação de Vetor";
            Load += Form1_Load;
            grbInsercao.ResumeLayout(false);
            grbInsercao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNumero;
        private Button btnInserir;
        private Button btnApresentar;
        private Button btnOrdenar;
        private ListBox lstApresentar;
        private ListBox lstOrdenar;
        private GroupBox grbInsercao;
        private Label label1;
    }
}
