namespace PrimeiroAplicativo
{
    partial class frmPropriedadesCheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropriedadesCheckBox));
            pnlPessoaFisica = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pnlPessoaJuridica = new Panel();
            chkPessoaFisica = new CheckBox();
            chkPessoaJuridica = new CheckBox();
            pnlPessoaFisica.SuspendLayout();
            pnlPessoaJuridica.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPessoaFisica
            // 
            pnlPessoaFisica.BorderStyle = BorderStyle.FixedSingle;
            pnlPessoaFisica.Controls.Add(textBox2);
            pnlPessoaFisica.Controls.Add(textBox1);
            pnlPessoaFisica.Controls.Add(label1);
            pnlPessoaFisica.Controls.Add(label2);
            pnlPessoaFisica.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pnlPessoaFisica.Location = new Point(229, 30);
            pnlPessoaFisica.Name = "pnlPessoaFisica";
            pnlPessoaFisica.Size = new Size(200, 93);
            pnlPessoaFisica.TabIndex = 1;
            pnlPessoaFisica.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(78, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(78, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 0;
            label2.Text = "CPF: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 15);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 0;
            label3.Text = "Nome:";
            label3.Click += ko_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 58);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 0;
            label4.Text = "CNPJ: ";
            label4.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(78, 7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox4_TextChanged_1;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(78, 50);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 25);
            textBox4.TabIndex = 2;
            textBox4.TextChanged += textBox3_TextChanged_1;
            // 
            // pnlPessoaJuridica
            // 
            pnlPessoaJuridica.BorderStyle = BorderStyle.FixedSingle;
            pnlPessoaJuridica.Controls.Add(textBox4);
            pnlPessoaJuridica.Controls.Add(textBox3);
            pnlPessoaJuridica.Controls.Add(label4);
            pnlPessoaJuridica.Controls.Add(label3);
            pnlPessoaJuridica.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pnlPessoaJuridica.Location = new Point(229, 230);
            pnlPessoaJuridica.Name = "pnlPessoaJuridica";
            pnlPessoaJuridica.Size = new Size(200, 93);
            pnlPessoaJuridica.TabIndex = 4;
            pnlPessoaJuridica.Paint += pnlPessoaJuridica_Paint_1;
            // 
            // chkPessoaFisica
            // 
            chkPessoaFisica.AutoSize = true;
            chkPessoaFisica.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkPessoaFisica.Location = new Point(19, 148);
            chkPessoaFisica.Name = "chkPessoaFisica";
            chkPessoaFisica.Size = new Size(120, 21);
            chkPessoaFisica.TabIndex = 0;
            chkPessoaFisica.Text = "Pessoa Física";
            chkPessoaFisica.UseVisualStyleBackColor = true;
            chkPessoaFisica.CheckedChanged += chkPessoaFisica_CheckedChanged_1;
            // 
            // chkPessoaJuridica
            // 
            chkPessoaJuridica.AutoSize = true;
            chkPessoaJuridica.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkPessoaJuridica.Location = new Point(19, 182);
            chkPessoaJuridica.Name = "chkPessoaJuridica";
            chkPessoaJuridica.Size = new Size(131, 21);
            chkPessoaJuridica.TabIndex = 0;
            chkPessoaJuridica.Text = "Pessoa Jurídica";
            chkPessoaJuridica.UseVisualStyleBackColor = true;
            chkPessoaJuridica.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // frmPropriedadesCheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 416);
            Controls.Add(pnlPessoaJuridica);
            Controls.Add(pnlPessoaFisica);
            Controls.Add(chkPessoaFisica);
            Controls.Add(chkPessoaJuridica);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPropriedadesCheckBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Propriedades do CheckBox";
            Load += Form1_Load;
            pnlPessoaFisica.ResumeLayout(false);
            pnlPessoaFisica.PerformLayout();
            pnlPessoaJuridica.ResumeLayout(false);
            pnlPessoaJuridica.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPessoaFisica;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Panel pnlPessoaJuridica;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private CheckBox chkPessoaFisica;
        private CheckBox chkPessoaJuridica;
    }
}