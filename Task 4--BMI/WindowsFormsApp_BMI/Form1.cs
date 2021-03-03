using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtResult.Text = "";

            radKg.Checked = false;
            radLbs.Checked = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double result = 0.0;

            string result2 = "";

            if (radKg.Checked)
            {
                result = weight / (height * height);
            }
            else 
                if (radLbs.Checked)
            {
                weight = weight / 2.205;
                result = weight / (height * height);
            }

            if (result < 18.5)
            {
                result2 = "You are Underweight.";
            }
            else
                if (result < 25)
            {
                result2 = "You have a Normal Weight.";
            }
            else
                if (result < 30)
            {
                result2 = "You are Overweight.";
            }
            else
                if (result >= 30)
            {
                result2 = "You are Obese.";
            }

            

                txtResult.Text = "Your BMI is: " + result.ToString("#.#") + "\r\n" + result2;

            /*
             * Underweight = <18.5
             * Normal weight = 18.5 - 24.9
             * Overweight = 25-29.9
             * Obesity = BMI of 30 or greater
            */
        }

        private void TxtWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
