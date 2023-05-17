using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurnal_mod12_1302213108
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CariNilaiPangkat(int a, int b)
        {
            int hasil = 0;
            if(b == 0)
            {
                return 1;

            }else if(b < 0)
            {
                return -1;
                
            }else if(a > 100 || b > 10 ) {
                return -2;

            }else if(checked(a * b > int.MaxValue))
            {
                return -3;

            }
            else
            {
                for(int i = 0; i < b; i++)
                {
                    hasil = a * b;
                }
                return hasil;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int OUTPUT = CariNilaiPangkat(a,b);
            label1.Text = Convert.ToString(OUTPUT);
        }
    }
}