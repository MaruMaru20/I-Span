using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab250107_LINQ
{
    public partial class Form7LINQ_where : Form
    {
        public Form7LINQ_where()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //from in where selecrt
            int[] xa = { 333, 444, 555, 666, 777, 887, 999 };

            var xb = from abc in xa
                     where abc == 777
                     select abc;
            textBox1.Text = string.Join(",", xb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] xa = { 222, 333, 444, 555, 666, 777, 887, 999 };

            var xb = from abc in xa where abc == 777 || abc == 887 select abc;
            textBox2.Text += string.Join(",", xb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] xa = { 222, 333, 444, 555, 666, 777, 887, 999 };

            var xb = from abc in xa where abc > 444 where abc < 999 select abc;
            textBox3.Text += string.Join(",", xb);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] xa = { 222, 333, 444, 555, 666, 777, 887, 999 };

            var xb = from abc in xa where abc > 444 && abc < 999 select abc;
            textBox4.Text += string.Join(",", xb);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] xa = { 222, 333, 444, 555, 666, 777, 887, 999 };

            var xb = from abc in xa where true select abc;
            textBox5.Text += string.Join(",", xb);
        }

        public bool Myfun(int dog) { return !(dog % 2 == 0); }


        private void button6_Click(object sender, EventArgs e)
        {

            int[] xa = { 222, 333, 444, 555, 666, 777, 887, 999 };
            var xb = from abc in xa where Myfun(abc) select abc;
            textBox6.Text += string.Join(",", xb);
        }

        private void Form7LINQ_where_Load(object sender, EventArgs e)
        {

        }
    }
}
