using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private double CalculateArea (double length, double width)
        {
            return length * width;
        }

        private double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        private double CalculateArea(double baseLength, double height, bool isTriangle)
        {
            if (isTriangle)
            
                return 0.5 * baseLength * height;
                return 0;

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double length) && double.TryParse(textBox2.Text, out double width))
            { 
                double area = CalculateArea(length, width);
                listBox1.Items.Add($"Rectangle: Length = {length}, Width ={width}, Area = {area}");
                textBox6.Text = $"Most Recent Result{area}";
            }

            else
            {
                MessageBox.Show("Enter the numbers of length and width");
            }
        }

        private void btn2CalculateCircle_Click(object sender, EventArgs e)
        {
           if (double.TryParse(textBox3.Text, out double radius))
            {
                double area = CalculateArea(radius);
                listBox1.Items.Add($"Circle: Radius = {radius}, Area = {area}");
                textBox6.Text = $"Most Recent Result{area}";
            }

            else
            {
                MessageBox.Show("Enter the number of radius");
            }
        }

        private void btn3CalculateTriangle_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox4.Text, out double baseLength) && double.TryParse(textBox5.Text, out double height))
            {
                double area = CalculateArea(baseLength, height, true);
                listBox1.Items.Add($"Triangle: base = {baseLength}, Height = {height}, Area = {area}");
                textBox6.Text = $"Most Recent Result";
            }
            else
            {
                MessageBox.Show("Enter the numbers of base and height");
            }
        }
    }
}
