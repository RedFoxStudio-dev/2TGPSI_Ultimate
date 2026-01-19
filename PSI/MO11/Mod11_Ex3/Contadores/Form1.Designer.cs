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
            cboMes.Items.AddRange(new object[] { "Janeiro", "Febereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" });
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
            cboAno.Items.AddRange(new object[] { "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050" });
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
