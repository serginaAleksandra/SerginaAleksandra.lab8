using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double p = 0.4;
            double a = rnd.NextDouble();
            if (a <= p)
            {
                label2.Text = "YES";
            }
            else
            {
                label2.Text = "NO";
            }
            textBox1.Clear();
        }
    }
}
