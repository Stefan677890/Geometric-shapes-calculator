using System.Reflection.Metadata;

namespace Geometric_shapes_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> Shapes = ["Square", "Rectangle", "Triangle", "Circle", "Trapezoid", "Parallelogram", "rhombus"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
