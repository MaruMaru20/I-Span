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
    public partial class Form6_LINQ_from_select : Form
    {
        public Form6_LINQ_from_select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //JS -> C# ->
            string xa = "test";
            var xb = 123;
            var xc = "000";

            textBox1.Text += xb.ToString() + "\r\n";
            textBox1.Text += xc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> abc = new List<int>();
            abc.Add(1);
            abc.Add(2);
            textBox2.Text += string.Join(",", abc) + "\r\n";

            var xb = new List<int>();
            xb.Add(3);
            xb.Add(4);
            xb.Add(5);
            textBox2.Text += string.Join(",", xb) + "\r\n";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //LINQ : from 變數 in 集合 select 變數
            //SQL  : select 資料行 from 資料表
            int[] xa = new int[] { 333, 444, 555 };
            //var xb = from abc in xa select abc;  
            IEnumerable<int> xb = from abc in xa select abc;

            //foreach (int x in xb)
            //{
            //    textBox3.Text += x;

            //}
            textBox3.Text += string.Join(",", xb);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int[] xa = new int[] { 333, 444, 555 ,666};
            var xb = from abc in xa select abc;

            textBox4.Text += string.Join(",", xb);
        }
    }
}
