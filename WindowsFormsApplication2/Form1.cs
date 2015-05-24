using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = Convert.ToString(int.Parse(textBox1.Text), 16).ToString();
                textBox3.Text = Convert.ToString(int.Parse(textBox1.Text), 8).ToString();
                textBox4.Text = Convert.ToString(int.Parse(textBox1.Text), 2).ToString(); 

            }
            else
            {


                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = ""; 
            }
          

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Int32 temp = Convert.ToInt32(textBox2.Text, 16);
                textBox1.Text =temp.ToString();
                textBox3.Text = Convert.ToString(temp, 8).ToString();
                textBox4.Text = Convert.ToString(temp, 2).ToString();

            }
            else
            {


                textBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }

          
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                Int32 temp = Convert.ToInt32(textBox3.Text, 8);
                textBox1.Text = temp.ToString();
                textBox2.Text = Convert.ToString(temp, 16).ToString();
                textBox4.Text = Convert.ToString(temp, 2).ToString();

            }
            else
            {


                textBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                Int32 temp = Convert.ToInt32(textBox4.Text, 2);
                textBox1.Text = temp.ToString();
                textBox2.Text = Convert.ToString(temp, 16).ToString();
                textBox3.Text = Convert.ToString(temp, 8).ToString();

            }
            else
            {


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
