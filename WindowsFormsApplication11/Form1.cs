using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = new int[100];
        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(200,450);
                listBox1.Items.Add(sayilar[i]);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = sayilar.Max().ToString();
            label2.Text = sayilar.Min().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {         
                listBox1.Items.Add(sayilar[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    listBox2.Items.Add(sayilar[i]);
                }
                else
                {
                    listBox3.Items.Add(sayilar[i]);
                }

            }
        }
    }
}
