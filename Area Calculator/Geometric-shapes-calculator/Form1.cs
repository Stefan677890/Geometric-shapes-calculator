using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Geometric_shapes_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List.Items.Clear();
            List.Items.AddRange(new string[] {
                "Square", "Rectangle", "Triangle", "Circle", "Trapezoid", "Parallelogram", "Rhombus"
            });

            ukryjpola();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List.SelectedItem == null) return;

            string selectedshape = List.SelectedItem.ToString();
            ukryjpola();

            switch (selectedshape)
            {
                case "Square":
                    Bok1.Text = "Side a";
                    Bok1.Visible = text_box1.Visible = true;
                    break;
                case "Rectangle":
                    Bok1.Text = "Side a";
                    Bok2.Text = "Side b";
                    pokazdwapola();
                    break;
                case "Triangle":
                    Bok1.Text = "Base (a)";
                    Bok2.Text = "Height (h)";
                    pokazdwapola();
                    break;
                case "Circle":
                    Bok1.Text = "Radius (r)";
                    Bok1.Visible = text_box1.Visible = true;
                    break;
                case "Parallelogram":
                    Bok1.Text = "Base (a)";
                    Bok2.Text = "Height (h)";
                    pokazdwapola();
                    break;
                case "Rhombus":
                    Bok1.Text = "Diagonal 1";
                    Bok2.Text = "Diagonal 2";
                    pokazdwapola();
                    break;
                case "Trapezoid":
                    Bok1.Text = "Base a:";
                    Bok2.Text = "Base b:";
                    height.Text = "Height (h)";
                    pokaztrzypola();
                    break;
            }
        }

        private void btn_Oblicz_Click(object sender, EventArgs e)
        {
            if (List.SelectedItem == null) return;

            double.TryParse(text_box1.Text, out double A);
            double.TryParse(text_box2.Text, out double B);
            double.TryParse(textBox1.Text, out double h);

            string wybranyksz = List.SelectedItem.ToString();
            double result = 0;

            switch (wybranyksz)
            {
                case "Square": 
                    result = A * A; 
                    break;
                case "Rectangle": 
                    result = A * B; 
                    break;
                case "Triangle": 
                    result = 0.5 * A * B; 
                    break;
                case "Circle": 
                    result = Math.PI * A * A; 
                    break;
                case "Parallelogram": 
                    result = A * B;
                    break;
                case "Rhombus": 
                    result = 0.5 * A * B; 
                    break;
                case "Trapezoid": 
                    result = 0.5 * (A + B) * h;
                    break;
            }


            Wynik.Text = result.ToString();
        }

        private void ukryjpola()
        {
            Bok1.Visible = Bok2.Visible = height.Visible = false;
            text_box1.Visible = text_box2.Visible = textBox1.Visible = false;
            text_box1.Text = text_box2.Text = textBox1.Text = "";
        }

        private void pokazdwapola()
        {
            Bok1.Visible = Bok2.Visible = text_box1.Visible = text_box2.Visible = true;
        }

        private void pokaztrzypola()
        {
            pokazdwapola();
            height.Visible = textBox1.Visible = true;
        }


        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}