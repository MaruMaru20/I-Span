using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab241230_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.label1.Text = "登登登";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Console.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = textBox2.Text.Length;

            if (textBox2.Text != string.Empty)
            {
                label1.Text = "8877";

            }
            else 
            {
                label1.Text = "歡迎加入 ";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
