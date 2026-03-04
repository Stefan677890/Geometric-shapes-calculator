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
            List = new ComboBox();
            btn_Oblicz = new Button();
            text_box1 = new TextBox();
            text_box2 = new TextBox();
            Bok1 = new Label();
            Bok2 = new Label();
            Rodzajfigury = new Label();
            Wynik = new Label();
            Labelpole = new Label();
            SuspendLayout();
            // 
            // List
            // 
            List.Font = new Font("Segoe UI", 20F);
            List.FormattingEnabled = true;
            List.Location = new Point(413, 103);
            List.Name = "List";
            List.Size = new Size(209, 45);
            List.TabIndex = 0;
            List.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_Oblicz
            // 
            btn_Oblicz.Location = new Point(413, 227);
            btn_Oblicz.Name = "btn_Oblicz";
            btn_Oblicz.Size = new Size(209, 43);
            btn_Oblicz.TabIndex = 1;
            btn_Oblicz.Text = "Calculate";
            btn_Oblicz.UseVisualStyleBackColor = true;
            // 
            // text_box1
            // 
            text_box1.Font = new Font("Segoe UI", 21F);
            text_box1.Location = new Point(139, 103);
            text_box1.Name = "text_box1";
            text_box1.Size = new Size(209, 45);
            text_box1.TabIndex = 2;
            text_box1.TextChanged += textBox1_TextChanged;
            // 
            // text_box2
            // 
            text_box2.Font = new Font("Segoe UI", 20F);
            text_box2.Location = new Point(139, 227);
            text_box2.Name = "text_box2";
            text_box2.Size = new Size(209, 43);
            text_box2.TabIndex = 3;
            // 
            // Bok1
            // 
            Bok1.Font = new Font("Segoe UI", 15F);
            Bok1.Location = new Point(139, 66);
            Bok1.Name = "Bok1";
            Bok1.Size = new Size(132, 34);
            Bok1.TabIndex = 4;
            Bok1.Text = "side 1";
            Bok1.Click += label1_Click;
            // 
            // Bok2
            // 
            Bok2.AutoSize = true;
            Bok2.Font = new Font("Segoe UI", 15F);
            Bok2.Location = new Point(139, 187);
            Bok2.Name = "Bok2";
            Bok2.Size = new Size(63, 28);
            Bok2.TabIndex = 5;
            Bok2.Text = "side 2";
            // 
            // Rodzajfigury
            // 
            Rodzajfigury.Font = new Font("Segoe UI", 15F);
            Rodzajfigury.Location = new Point(413, 66);
            Rodzajfigury.Name = "Rodzajfigury";
            Rodzajfigury.Size = new Size(209, 34);
            Rodzajfigury.TabIndex = 6;
            Rodzajfigury.Tag = "";
            Rodzajfigury.Text = "Which shape";
            // 
            // Wynik
            // 
            Wynik.Font = new Font("Segoe UI", 24F);
            Wynik.Location = new Point(484, 299);
            Wynik.Name = "Wynik";
            Wynik.Size = new Size(117, 58);
            Wynik.TabIndex = 8;
            Wynik.Text = "0";
            Wynik.Click += label5_Click;
            // 
            // Labelpole
            // 
            Labelpole.Font = new Font("Segoe UI", 24F);
            Labelpole.Location = new Point(200, 299);
            Labelpole.Name = "Labelpole";
            Labelpole.Size = new Size(306, 58);
            Labelpole.TabIndex = 9;
            Labelpole.Text = "Pole           =";
            Labelpole.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Wynik);
            Controls.Add(Rodzajfigury);
            Controls.Add(Bok2);
            Controls.Add(Bok1);
            Controls.Add(text_box2);
            Controls.Add(text_box1);
            Controls.Add(btn_Oblicz);
            Controls.Add(List);
            Controls.Add(Labelpole);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox List;
        private Button btn_Oblicz;
        private TextBox text_box1;
        private TextBox text_box2;
        private Label Bok1;
        private Label Bok2;
        private Label Rodzajfigury;
        private Label Wynik;
        private Label Labelpole;
    }
}
