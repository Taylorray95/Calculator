using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit_to_Celsius
{
    public partial class Form1 : Form
    {
       

        public void returncels(int f)
        {
            // int f = Convert.ToInt32(textBox1.Text);
           // int c = (5 / 9) * (f - 32);
          //  label3.Text = c.ToString();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // returncels(Convert.ToInt32(textBox1.Text));
            //int f = Convert.ToInt32(textBox1.Text);
            // int cel;
            object f = textBox1.Text;
            object c = (Convert.ToInt32(f) - 32) * (5/9);
            label4.Text = c.ToString();
           
            // label3.Text = 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

         //   int f = Convert.ToInt32(textBox1.Text);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           // int f = Convert.ToInt32(textBox1.Text);
           // int cel;
           // cel = (f - 32) * (5 / 9);

          //  label4.Text = Convert.ToString(cel);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
