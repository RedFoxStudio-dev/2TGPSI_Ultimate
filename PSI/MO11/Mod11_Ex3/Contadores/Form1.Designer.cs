namespace Contadores
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
            cboMes = new ComboBox();
            label2 = new Label();
            cboAno = new ComboBox();
            label3 = new Label();
            dtpData = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtGas = new TextBox();
            txtEletricidade = new TextBox();
            txtAgua = new TextBox();
            btnInserir = new Button();
            btnListar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 87);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Mês";
            // 
            // cboMes
            // 
            cboMes.FormattingEnabled = true;
            cboMes.Location = new Point(121, 84);
            cboMes.Name = "cboMes";
            cboMes.Size = new Size(121, 23);
            cboMes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 92);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Ano";
            // 
            // cboAno
            // 
            cboAno.FormattingEnabled = true;
            cboAno.Location = new Point(374, 87);
            cboAno.Name = "cboAno";
            cboAno.Size = new Size(121, 23);
            cboAno.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 187);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 4;
            label3.Text = "Data de Medição:";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(195, 187);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 261);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 6;
            label4.Text = "Gás";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 300);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 7;
            label5.Text = "Eletricidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 340);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 8;
            label6.Text = "Água";
            // 
            // txtGas
            // 
            txtGas.Location = new Point(142, 258);
            txtGas.Name = "txtGas";
            txtGas.Size = new Size(100, 23);
            txtGas.TabIndex = 9;
            // 
            // txtEletricidade
            // 
            txtEletricidade.Location = new Point(142, 300);
            txtEletricidade.Name = "txtEletricidade";
            txtEletricidade.Size = new Size(100, 23);
            txtEletricidade.TabIndex = 10;
            // 
            // txtAgua
            // 
            txtAgua.Location = new Point(142, 340);
            txtAgua.Name = "txtAgua";
            txtAgua.Size = new Size(100, 23);
            txtAgua.TabIndex = 11;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(374, 261);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(99, 39);
            btnInserir.TabIndex = 12;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(374, 331);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(99, 39);
            btnListar.TabIndex = 13;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListar);
            Controls.Add(btnInserir);
            Controls.Add(txtAgua);
            Controls.Add(txtEletricidade);
            Controls.Add(txtGas);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpData);
            Controls.Add(label3);
            Controls.Add(cboAno);
            Controls.Add(label2);
            Controls.Add(cboMes);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboMes;
        private Label label2;
        private ComboBox cboAno;
        private Label label3;
        private DateTimePicker dtpData;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtGas;
        private TextBox txtEletricidade;
        private TextBox txtAgua;
        private Button btnInserir;
        private Button btnListar;
    }
}
