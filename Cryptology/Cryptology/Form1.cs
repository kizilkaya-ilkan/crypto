using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptology
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            string sezar = textBox1.Text;
            int key = Convert.ToInt32(textBox2.Text);
            char[] karekterler = sezar.ToCharArray();
            foreach (char eleman in karekterler)
            {
               textBox3.Text += Convert.ToChar(eleman + key).ToString();
          
            }
            MessageBox.Show(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sezar = textBox1.Text;
            int key = Convert.ToInt32(textBox2.Text);
            char[] karekterler = sezar.ToCharArray();
            foreach (char eleman in karekterler)
            {
                textBox3.Text += Convert.ToChar(eleman - key).ToString();
            }
            MessageBox.Show(textBox3.Text);
        }
    }
}
