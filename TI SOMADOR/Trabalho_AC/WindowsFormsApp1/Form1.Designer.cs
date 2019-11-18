namespace WindowsFormsApp1
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
            this.btnEntrada = new System.Windows.Forms.Button();
            this.listBox0 = new System.Windows.Forms.ListBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lst_mantissa2 = new System.Windows.Forms.ListBox();
            this.lst_expoente2 = new System.Windows.Forms.ListBox();
            this.lst_hexa2 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.lst_sinal2 = new System.Windows.Forms.ListBox();
            this.lst_sinal1 = new System.Windows.Forms.ListBox();
            this.lst_expoente1 = new System.Windows.Forms.ListBox();
            this.lst_mantissa1 = new System.Windows.Forms.ListBox();
            this.lst_hexa1 = new System.Windows.Forms.ListBox();
            this.lst_num1 = new System.Windows.Forms.ListBox();
            this.lst_num2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_resutadosomadecimal = new System.Windows.Forms.ListBox();
            this.lst_resultadosinal = new System.Windows.Forms.ListBox();
            this.lst_resultadoexpoente = new System.Windows.Forms.ListBox();
            this.lst_resultadoMantissa = new System.Windows.Forms.ListBox();
            this.lst_resultadoHexa = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_num2binario = new System.Windows.Forms.ListBox();
            this.lst_num1binario = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEntrada.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrada.Location = new System.Drawing.Point(202, 40);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(172, 38);
            this.btnEntrada.TabIndex = 6;
            this.btnEntrada.Text = "Converter";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // listBox0
            // 
            this.listBox0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox0.DisplayMember = "(nenshum)";
            this.listBox0.FormattingEnabled = true;
            this.listBox0.Location = new System.Drawing.Point(11, 448);
            this.listBox0.Margin = new System.Windows.Forms.Padding(2);
            this.listBox0.Name = "listBox0";
            this.listBox0.Size = new System.Drawing.Size(211, 30);
            this.listBox0.TabIndex = 9;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(407, 40);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(118, 20);
            this.txt_num2.TabIndex = 10;
            this.txt_num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "N° 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 11);
            this.label4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 11);
            this.label6.TabIndex = 16;
            this.label6.Text = "Andre Diniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(512, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 11);
            this.label7.TabIndex = 17;
            this.label7.Text = "Bryan Fernandes";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Alunos:";
            // 
            // lst_mantissa2
            // 
            this.lst_mantissa2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_mantissa2.DisplayMember = "(nenshum)";
            this.lst_mantissa2.FormattingEnabled = true;
            this.lst_mantissa2.Items.AddRange(new object[] {
            "Mantissa"});
            this.lst_mantissa2.Location = new System.Drawing.Point(440, 128);
            this.lst_mantissa2.Margin = new System.Windows.Forms.Padding(2);
            this.lst_mantissa2.Name = "lst_mantissa2";
            this.lst_mantissa2.Size = new System.Drawing.Size(144, 17);
            this.lst_mantissa2.TabIndex = 21;
            // 
            // lst_expoente2
            // 
            this.lst_expoente2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_expoente2.DisplayMember = "(nenshum)";
            this.lst_expoente2.FormattingEnabled = true;
            this.lst_expoente2.Items.AddRange(new object[] {
            "Expoente"});
            this.lst_expoente2.Location = new System.Drawing.Point(378, 128);
            this.lst_expoente2.Margin = new System.Windows.Forms.Padding(2);
            this.lst_expoente2.Name = "lst_expoente2";
            this.lst_expoente2.Size = new System.Drawing.Size(58, 17);
            this.lst_expoente2.TabIndex = 22;
            // 
            // lst_hexa2
            // 
            this.lst_hexa2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_hexa2.DisplayMember = "(nenshum)";
            this.lst_hexa2.FormattingEnabled = true;
            this.lst_hexa2.Items.AddRange(new object[] {
            "IEEE 754 Hexadecimal"});
            this.lst_hexa2.Location = new System.Drawing.Point(408, 161);
            this.lst_hexa2.Margin = new System.Windows.Forms.Padding(2);
            this.lst_hexa2.Name = "lst_hexa2";
            this.lst_hexa2.Size = new System.Drawing.Size(117, 17);
            this.lst_hexa2.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(78, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "N° 1 :";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(44, 40);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(118, 20);
            this.txt_num1.TabIndex = 26;
            this.txt_num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lst_sinal2
            // 
            this.lst_sinal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_sinal2.DisplayMember = "(nenshum)";
            this.lst_sinal2.FormattingEnabled = true;
            this.lst_sinal2.Items.AddRange(new object[] {
            "Sinal"});
            this.lst_sinal2.Location = new System.Drawing.Point(342, 128);
            this.lst_sinal2.Margin = new System.Windows.Forms.Padding(2);
            this.lst_sinal2.Name = "lst_sinal2";
            this.lst_sinal2.Size = new System.Drawing.Size(32, 17);
            this.lst_sinal2.TabIndex = 23;
            // 
            // lst_sinal1
            // 
            this.lst_sinal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_sinal1.DisplayMember = "(nenshum)";
            this.lst_sinal1.FormattingEnabled = true;
            this.lst_sinal1.Items.AddRange(new object[] {
            "Sinal"});
            this.lst_sinal1.Location = new System.Drawing.Point(11, 128);
            this.lst_sinal1.Margin = new System.Windows.Forms.Padding(2);
            this.lst_sinal1.Name = "lst_sinal1";
            this.lst_sinal1.Size = new System.Drawing.Size(32, 17);
            this.lst_sinal1.TabIndex = 27;
            // 
            // lst_expoente1
            // 
            this.lst_expoente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_expoente1.DisplayMember = "(nenshum)";
            this.lst_expoente1.FormattingEnabled = true;
            this.lst_expoente1.Items.AddRange(new object[] {
            "Expoente"});
            this.lst_expoente1.Location = new System.Drawing.Point(47, 128);
            this.lst_expoente1.Margin = new System.Windows.Forms.Padding(2);
            this.lst_expoente1.Name = "lst_expoente1";
            this.lst_expoente1.Size = new System.Drawing.Size(58, 17);
            this.lst_expoente1.TabIndex = 28;
            // 
            // lst_mantissa1
            // 
            this.lst_mantissa1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_mantissa1.DisplayMember = "(nenshum)";
            this.lst_mantissa1.FormattingEnabled = true;
            this.lst_mantissa1.Items.AddRange(new object[] {
            "Mantissa"});
            this.lst_mantissa1.Location = new System.Drawing.Point(109, 128);
            this.lst_mantissa1.Margin = new System.Windows.Forms.Padding(2);
            this.lst_mantissa1.Name = "lst_mantissa1";
            this.lst_mantissa1.Size = new System.Drawing.Size(175, 17);
            this.lst_mantissa1.TabIndex = 29;
            // 
            // lst_hexa1
            // 
            this.lst_hexa1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_hexa1.DisplayMember = "(nenshum)";
            this.lst_hexa1.FormattingEnabled = true;
            this.lst_hexa1.Items.AddRange(new object[] {
            "IEEE 754 Hexadecimal"});
            this.lst_hexa1.Location = new System.Drawing.Point(44, 161);
            this.lst_hexa1.Margin = new System.Windows.Forms.Padding(2);
            this.lst_hexa1.Name = "lst_hexa1";
            this.lst_hexa1.Size = new System.Drawing.Size(117, 17);
            this.lst_hexa1.TabIndex = 30;
            // 
            // lst_num1
            // 
            this.lst_num1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_num1.DisplayMember = "(nenshum)";
            this.lst_num1.FormattingEnabled = true;
            this.lst_num1.Items.AddRange(new object[] {
            "Numero"});
            this.lst_num1.Location = new System.Drawing.Point(64, 88);
            this.lst_num1.Margin = new System.Windows.Forms.Padding(2);
            this.lst_num1.Name = "lst_num1";
            this.lst_num1.Size = new System.Drawing.Size(86, 17);
            this.lst_num1.TabIndex = 31;
            // 
            // lst_num2
            // 
            this.lst_num2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_num2.DisplayMember = "(nenshum)";
            this.lst_num2.FormattingEnabled = true;
            this.lst_num2.Items.AddRange(new object[] {
            "Numero"});
            this.lst_num2.Location = new System.Drawing.Point(425, 88);
            this.lst_num2.Margin = new System.Windows.Forms.Padding(2);
            this.lst_num2.Name = "lst_num2";
            this.lst_num2.Size = new System.Drawing.Size(86, 17);
            this.lst_num2.TabIndex = 32;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(303, 225);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 38);
            this.button4.TabIndex = 36;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_soma.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soma.ForeColor = System.Drawing.Color.White;
            this.btn_soma.Location = new System.Drawing.Point(226, 225);
            this.btn_soma.Margin = new System.Windows.Forms.Padding(2);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(51, 38);
            this.btn_soma.TabIndex = 37;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = false;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Resultado:";
            // 
            // lst_resutadosomadecimal
            // 
            this.lst_resutadosomadecimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_resutadosomadecimal.DisplayMember = "(nenshum)";
            this.lst_resutadosomadecimal.FormattingEnabled = true;
            this.lst_resutadosomadecimal.Items.AddRange(new object[] {
            "Numero"});
            this.lst_resutadosomadecimal.Location = new System.Drawing.Point(252, 316);
            this.lst_resutadosomadecimal.Margin = new System.Windows.Forms.Padding(2);
            this.lst_resutadosomadecimal.Name = "lst_resutadosomadecimal";
            this.lst_resutadosomadecimal.Size = new System.Drawing.Size(81, 17);
            this.lst_resutadosomadecimal.TabIndex = 42;
            // 
            // lst_resultadosinal
            // 
            this.lst_resultadosinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_resultadosinal.DisplayMember = "(nenshum)";
            this.lst_resultadosinal.FormattingEnabled = true;
            this.lst_resultadosinal.Items.AddRange(new object[] {
            "Sinal"});
            this.lst_resultadosinal.Location = new System.Drawing.Point(190, 355);
            this.lst_resultadosinal.Margin = new System.Windows.Forms.Padding(2);
            this.lst_resultadosinal.Name = "lst_resultadosinal";
            this.lst_resultadosinal.Size = new System.Drawing.Size(32, 17);
            this.lst_resultadosinal.TabIndex = 43;
            // 
            // lst_resultadoexpoente
            // 
            this.lst_resultadoexpoente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_resultadoexpoente.DisplayMember = "(nenshum)";
            this.lst_resultadoexpoente.FormattingEnabled = true;
            this.lst_resultadoexpoente.Items.AddRange(new object[] {
            "Expoente"});
            this.lst_resultadoexpoente.Location = new System.Drawing.Point(226, 355);
            this.lst_resultadoexpoente.Margin = new System.Windows.Forms.Padding(2);
            this.lst_resultadoexpoente.Name = "lst_resultadoexpoente";
            this.lst_resultadoexpoente.Size = new System.Drawing.Size(58, 17);
            this.lst_resultadoexpoente.TabIndex = 44;
            // 
            // lst_resultadoMantissa
            // 
            this.lst_resultadoMantissa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_resultadoMantissa.DisplayMember = "(nenshum)";
            this.lst_resultadoMantissa.FormattingEnabled = true;
            this.lst_resultadoMantissa.Items.AddRange(new object[] {
            "Mantissa"});
            this.lst_resultadoMantissa.Location = new System.Drawing.Point(288, 355);
            this.lst_resultadoMantissa.Margin = new System.Windows.Forms.Padding(2);
            this.lst_resultadoMantissa.Name = "lst_resultadoMantissa";
            this.lst_resultadoMantissa.Size = new System.Drawing.Size(144, 17);
            this.lst_resultadoMantissa.TabIndex = 45;
            // 
            // lst_resultadoHexa
            // 
            this.lst_resultadoHexa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_resultadoHexa.DisplayMember = "(nenshum)";
            this.lst_resultadoHexa.FormattingEnabled = true;
            this.lst_resultadoHexa.Items.AddRange(new object[] {
            "IEEE 754 Hexadecimal"});
            this.lst_resultadoHexa.Location = new System.Drawing.Point(237, 385);
            this.lst_resultadoHexa.Margin = new System.Windows.Forms.Padding(2);
            this.lst_resultadoHexa.Name = "lst_resultadoHexa";
            this.lst_resultadoHexa.Size = new System.Drawing.Size(117, 17);
            this.lst_resultadoHexa.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(511, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Gustavo Hoffman";
            // 
            // lst_num2binario
            // 
            this.lst_num2binario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_num2binario.DisplayMember = "(nenshum)";
            this.lst_num2binario.FormattingEnabled = true;
            this.lst_num2binario.Items.AddRange(new object[] {
            "Número em binário"});
            this.lst_num2binario.Location = new System.Drawing.Point(399, 192);
            this.lst_num2binario.Margin = new System.Windows.Forms.Padding(2);
            this.lst_num2binario.Name = "lst_num2binario";
            this.lst_num2binario.Size = new System.Drawing.Size(126, 17);
            this.lst_num2binario.TabIndex = 51;
            // 
            // lst_num1binario
            // 
            this.lst_num1binario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_num1binario.DisplayMember = "(nenshum)";
            this.lst_num1binario.FormattingEnabled = true;
            this.lst_num1binario.Items.AddRange(new object[] {
            "Número em binário"});
            this.lst_num1binario.Location = new System.Drawing.Point(44, 192);
            this.lst_num1binario.Margin = new System.Windows.Forms.Padding(2);
            this.lst_num1binario.Name = "lst_num1binario";
            this.lst_num1binario.Size = new System.Drawing.Size(125, 17);
            this.lst_num1binario.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.gray_painted_background_53876_94041;
            this.ClientSize = new System.Drawing.Size(597, 481);
            this.Controls.Add(this.lst_num1binario);
            this.Controls.Add(this.lst_num2binario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst_resultadoHexa);
            this.Controls.Add(this.lst_resultadoMantissa);
            this.Controls.Add(this.lst_resultadoexpoente);
            this.Controls.Add(this.lst_resultadosinal);
            this.Controls.Add(this.lst_resutadosomadecimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lst_num2);
            this.Controls.Add(this.lst_num1);
            this.Controls.Add(this.lst_hexa1);
            this.Controls.Add(this.lst_mantissa1);
            this.Controls.Add(this.lst_expoente1);
            this.Controls.Add(this.lst_sinal1);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lst_hexa2);
            this.Controls.Add(this.lst_sinal2);
            this.Controls.Add(this.lst_expoente2);
            this.Controls.Add(this.lst_mantissa2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.listBox0);
            this.Controls.Add(this.btnEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.ListBox listBox0;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lst_mantissa2;
        private System.Windows.Forms.ListBox lst_expoente2;
        private System.Windows.Forms.ListBox lst_hexa2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.ListBox lst_sinal2;
        private System.Windows.Forms.ListBox lst_sinal1;
        private System.Windows.Forms.ListBox lst_expoente1;
        private System.Windows.Forms.ListBox lst_mantissa1;
        private System.Windows.Forms.ListBox lst_hexa1;
        private System.Windows.Forms.ListBox lst_num1;
        private System.Windows.Forms.ListBox lst_num2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_resutadosomadecimal;
        private System.Windows.Forms.ListBox lst_resultadosinal;
        private System.Windows.Forms.ListBox lst_resultadoexpoente;
        private System.Windows.Forms.ListBox lst_resultadoMantissa;
        private System.Windows.Forms.ListBox lst_resultadoHexa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_num2binario;
        private System.Windows.Forms.ListBox lst_num1binario;
    }
}

