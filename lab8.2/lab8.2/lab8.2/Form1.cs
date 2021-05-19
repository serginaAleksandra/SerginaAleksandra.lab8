using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double[] p = new double[10];
            int i = 0;
            p[0] = 0;
            for (; i < 9; i++)
            {
                p[i] = p[i] + 0.1;
            }
            double a = rnd.NextDouble();
            double A = a;
            int k = 0;
            for (i = 0; i < 9; i++)
            {
                A = A - p[i];
                k++;
                if (A <= 0)
                {
                    break;
                }
            }
            switch (k)
            {
                case 1:
                    label2.Text = "It is certain";
                    break;
                case 2:
                    label2.Text = "Outlook good";
                    break;
                case 3:
                    label2.Text = "Yes definitely";
                    break;
                case 4:
                    label2.Text = "As I see it, yes";
                    break;
                case 5:
                    label2.Text = "Replay hazy, try again";
                    break;
                case 6:
                    label2.Text = " Ask again later";
                    break;
                case 7:
                    label2.Text = "My reply is no";
                    break;
                case 8:
                    label2.Text = "Most likely";
                    break;
                case 9:
                    label2.Text = "Don't count on it";
                    break;
                case 10:
                    label2.Text = "Better not tell you now";
                    break;
            }
        }
    }
}
