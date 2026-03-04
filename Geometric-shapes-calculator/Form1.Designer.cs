namespace Geometric_shapes_calculator
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
            comboBox1 = new ComboBox();
            Rodzajfigury = new Label();
            textBox1 = new TextBox();
            btn_Wynik = new Button();
            Obwod = new Label();
            Wynik = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Bok1 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(553, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 36);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Rodzajfigury
            // 
            Rodzajfigury.AutoSize = true;
            Rodzajfigury.Font = new Font("Segoe UI", 15F);
            Rodzajfigury.Location = new Point(553, 50);
            Rodzajfigury.Name = "Rodzajfigury";
            Rodzajfigury.Size = new Size(123, 28);
            Rodzajfigury.TabIndex = 1;
            Rodzajfigury.Text = "Which shape";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(103, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 34);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn_Wynik
            // 
            btn_Wynik.Location = new Point(553, 200);
            btn_Wynik.Name = "btn_Wynik";
            btn_Wynik.Size = new Size(180, 67);
            btn_Wynik.TabIndex = 3;
            btn_Wynik.Text = "Calculate";
            btn_Wynik.UseVisualStyleBackColor = true;
            btn_Wynik.Click += btn_Wynik_Click;
            // 
            // Obwod
            // 
            Obwod.AutoSize = true;
            Obwod.Font = new Font("Segoe UI", 25F);
            Obwod.Location = new Point(214, 318);
            Obwod.Name = "Obwod";
            Obwod.Size = new Size(250, 46);
            Obwod.TabIndex = 4;
            Obwod.Text = "Perimiter        =";
            // 
            // Wynik
            // 
            Wynik.AutoSize = true;
            Wynik.Font = new Font("Segoe UI", 25F);
            Wynik.Location = new Point(530, 318);
            Wynik.Name = "Wynik";
            Wynik.Size = new Size(38, 46);
            Wynik.TabIndex = 5;
            Wynik.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(318, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 34);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(103, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 34);
            textBox3.TabIndex = 7;
            // 
            // Bok1
            // 
            Bok1.AutoSize = true;
            Bok1.Font = new Font("Segoe UI", 15F);
            Bok1.Location = new Point(103, 63);
            Bok1.Name = "Bok1";
            Bok1.Size = new Size(63, 28);
            Bok1.TabIndex = 8;
            Bok1.Text = "side 1";
            Bok1.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(318, 52);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 9;
            label1.Text = "side 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(103, 192);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 10;
            label2.Text = "side 3";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(318, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 34);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(318, 192);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 12;
            label4.Text = "side 4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Bok1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(Wynik);
            Controls.Add(Obwod);
            Controls.Add(btn_Wynik);
            Controls.Add(textBox1);
            Controls.Add(Rodzajfigury);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label Rodzajfigury;
        private TextBox textBox1;
        private Button btn_Wynik;
        private Label Obwod;
        private Label Wynik;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label Bok1;
        private Label label1;
        private Label label2;
        private TextBox textBox4;
        private Label label4;
    }
}
