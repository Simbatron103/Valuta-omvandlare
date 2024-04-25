using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valuta_omvandlare
{
    public partial class Form1 : Form
    {
        Double Kronor = 0;
        Double Dollars = 0;
        Double Euro = 0;
        Double Pund = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (double.TryParse(textBox1.Text, out double kronor))
            {
                Kronor = kronor;
            }
            else
            {
                Kronor = 0;
            }

            Euro = Kronor / 11.63;
            Pund = Kronor / 13.55;
            Dollars = Kronor / 10.85;

            textBox2.Text = Euro.ToString();
            textBox3.Text = Dollars.ToString();
            textBox1.Text = Kronor.ToString();
            textBox4.Text = Pund.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double euro))
            {
                Euro = euro;
            }
            else
            {
                Euro = 0;
            }

            Kronor = Euro * 11.63;
            Pund = Euro * 0.86;
            Dollars = Euro * 1.07;

            textBox2.Text = Euro.ToString();
            textBox3.Text = Dollars.ToString();
            textBox1.Text = Kronor.ToString();
            textBox4.Text = Pund.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double dollars))
            {
                Dollars = dollars;
            }
            else
            {
                Dollars = 0;
            }

            Kronor = Dollars * 10.86;
            Pund = Dollars * 0.8;
            Euro = Dollars * 0.93;

            textBox2.Text = Euro.ToString();
            textBox3.Text = Dollars.ToString();
            textBox1.Text = Kronor.ToString();
            textBox4.Text = Pund.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox4.Text, out double pund))
            {
                Pund = pund;
            }
            else
            {
                Pund = 0;
            }

            Kronor = Pund * 13.57;
            Dollars = Pund * 1.25;
            Euro = Pund * 1.17;

            textBox2.Text = Euro.ToString();
            textBox3.Text = Dollars.ToString();
            textBox1.Text = Kronor.ToString();
            textBox4.Text = Pund.ToString();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = 0.ToString();
            textBox3.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            textBox1.Text = 0.ToString();
        }
    }
}
