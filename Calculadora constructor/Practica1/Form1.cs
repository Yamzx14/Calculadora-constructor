using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            elsuma osuma = new elsuma
                 (int.Parse(textBox1.Text),
                 int.Parse(textBox2.Text));
           /* elsuma osuma = new elsuma();
            osuma.N1 = int.Parse(textBox1.Text);
            osuma.N2 = int.Parse(textBox2.Text);*/

            textBox3.Text = osuma.sumar().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
    
            elsuma osuma = new elsuma
                (int.Parse(textBox1.Text),
                int.Parse(textBox2.Text));
            textBox3.Text = osuma.meno().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            elsuma osuma = new elsuma
                (int.Parse(textBox1.Text),
                int.Parse(textBox2.Text));
            textBox3.Text = osuma.dividir().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            elsuma osuma = new elsuma
                (int.Parse(textBox1.Text),
                int.Parse(textBox2.Text));
            textBox3.Text = osuma.multi().ToString();
        }
    }
}
