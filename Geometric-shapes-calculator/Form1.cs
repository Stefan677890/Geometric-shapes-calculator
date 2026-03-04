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


            List<string> shapes = new List<string> { "Square", "Rectangle", "Triangle", "Circle", "Rhombus", "Parallelogram" };
            comboBox1.DataSource = shapes;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shape = comboBox1.Text;


            textBox2.Visible = false; label1.Visible = false;
            textBox3.Visible = false; label2.Visible = false;
            textBox4.Visible = false; label4.Visible = false;


            if (shape == "Square" || shape == "Rhombus")
            {
                Bok1.Text = "Side a";
            }
            else if (shape == "Circle")
            {
                Bok1.Text = "Radius r";
            }
            else if (shape == "Rectangle" || shape == "Parallelogram")
            {
                Bok1.Text = "Side a";
                label1.Text = "Side b";
                textBox2.Visible = true; label1.Visible = true;
            }
            else if (shape == "Triangle")
            {
                Bok1.Text = "Side a";
                label1.Text = "Side b";
                label2.Text = "Side c";
                textBox2.Visible = true; label1.Visible = true;
                textBox3.Visible = true; label2.Visible = true;
            }
        }


        private void btn_Wynik_Click(object sender, EventArgs e)
        {
            string shape = comboBox1.Text;
            double perimeter = 0;

            double.TryParse(textBox1.Text, out double a);
            double.TryParse(textBox2.Text, out double b);
            double.TryParse(textBox3.Text, out double c);

            switch (shape)
            {
                case "Square":
                case "Rhombus":
                    perimeter = 4 * a;
                    break;
                case "Circle":
                    perimeter = 2 * Math.PI * a;
                    break;
                case "Rectangle":
                case "Parallelogram":
                    perimeter = 2 * a + 2 * b;
                    break;
                case "Triangle":
                    perimeter = a + b + c;
                    break;
            }


            Wynik.Text = perimeter.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}