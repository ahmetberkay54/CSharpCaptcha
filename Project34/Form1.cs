using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", };
            string[] s2 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", };
            int[] s3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] s4 = { "+", "-", "*", "/", "%", "#", "?", "@", "!" };
            int[] s5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Random rnd = new Random();
            int x1, x2, x3, x4, x5;

            x1 = rnd.Next(0, s1.Length);
            x2 = rnd.Next(0, s2.Length);
            x3 = rnd.Next(0, s3.Length);
            x4 = rnd.Next(0, s4.Length);
            x5 = rnd.Next(0, s5.Length);

            label1.Text = s1[x1].ToString() + s2[x2].ToString() + s3[x3].ToString() + s4[x4].ToString() + s5[x5].ToString();

            string user1 = textBox1.Text;
            string computer1 = s1[x1] + s2[x2]+ s3[x3]+ s4[x4] + s5[x5].ToString();

                  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == label1.Text)
            {
                MessageBox.Show("Sen Robot Değilsin o.O");
            }
            else
            {
                MessageBox.Show("Sen Robotsun !?");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
