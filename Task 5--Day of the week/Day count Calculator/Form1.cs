using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int day,month,year;

            // Mar = 1 Apr = 2 May = 3 Jun = 4 Jul = 5 Aug = 6 Sep = 7 Oct = 8 Nov = 9 Dec = 10 Jan = 11 Feb = 12
            // day = 1 - 31
            day = Convert.ToInt32(textBox1.Text);
            month = Convert.ToInt32(textBox2.Text);
            year = Convert.ToInt32(textBox3.Text);

            DateTime Value = new DateTime(year, month, day);

            textBox4.Text = Convert.ToString(Value.DayOfWeek);
            
        }


        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
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
        }
    }
}
