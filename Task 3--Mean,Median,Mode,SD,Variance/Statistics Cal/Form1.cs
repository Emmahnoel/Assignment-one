using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            numbers.Add(Convert.ToInt32(textBox1.Text));
            numbers.Add(Convert.ToInt32(textBox2.Text));
            numbers.Add(Convert.ToInt32(textBox3.Text));
            numbers.Add(Convert.ToInt32(textBox4.Text));
            numbers.Add(Convert.ToInt32(textBox5.Text));
            numbers.Add(Convert.ToInt32(textBox6.Text));
            numbers.Add(Convert.ToInt32(textBox7.Text));
            numbers.Add(Convert.ToInt32(textBox8.Text));
            numbers.Add(Convert.ToInt32(textBox9.Text));
            numbers.Add(Convert.ToInt32(textBox10.Text));

            textBox11.Text = Convert.ToString(Mean(numbers));
            textBox12.Text = Convert.ToString(Mean(numbers));
            textBox13.Text = Convert.ToString(Variance(numbers));
            textBox14.Text = Convert.ToString(StandardDeviation(numbers));
            textBox15.Text = Convert.ToString(median(numbers));
        }
        private double Mean(List<int> numbers)
        {
            return numbers.Average();

        }
        private double StandardDeviation(List<int> numbers)
        {
            var meanOfNumbers = numbers.Average();
            var squaredDifferences = new List<double>(numbers.Count);
            foreach (var number in numbers)
            {
                var difference = number - meanOfNumbers;
                var squaredDifference = Math.Pow(difference, 2);
                squaredDifferences.Add(squaredDifference);

            }
            var meanOfSquaredDifferences = squaredDifferences.Average();

            var standardDeviation = Math.Sqrt(meanOfSquaredDifferences);
            return standardDeviation;
        }
        private double Variance(List<int> numbers)
        {
            var meanOfNumbers = numbers.Average();
            var squaredDifferences = new List<double>(numbers.Count);
            foreach (var number in numbers)
            {
                var difference = number - meanOfNumbers;
                var squaredDifference = Math.Pow(difference, 2);
                squaredDifferences.Add(squaredDifference);

            }
            var variance = squaredDifferences.Average();

            return variance;
        }
        private double median(List<int> numbers)
        {
            double median;
            numbers.Sort();

            // Find out if the list is odd
            if ((numbers.Count % 2) == 0)
            {
                double midIndex = numbers.Count / 2;
                median = (numbers[(int)(midIndex - 0.5)] +
                     numbers[(int)(midIndex + 0.5)]) / 2;
            }
            else
                median = numbers[numbers.Count / 2];
            return median;
        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}


