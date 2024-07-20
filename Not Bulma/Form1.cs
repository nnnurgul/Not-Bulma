using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Bulma
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

        private void button1_Click(object sender, EventArgs e)
        {
            double v, f, ort, dvm;
            v=Convert.ToDouble(textBox1.Text);
            f=Convert.ToDouble(textBox2.Text);
            dvm=Convert.ToDouble(textBox4.Text);
            ort = (v * 0.4) + (f * 0.6);

            textBox3.Text = ort.ToString();

            if (ort > 50 && dvm < 20)
            {
                MessageBox.Show("Geçtiniz");
            }
            else
            {
                MessageBox.Show("Kaldınız");
            }

        }
    }
}
