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
    public partial class Form10_review : Form
    {
        public Form10_review()
        {
            InitializeComponent();
        }

        private void Form10_review_Load(object sender, EventArgs e)
        {
            // Q：大於8的有幾個？

            

            // 解法A: foreach

            // 解法B: LINQ 查詢語法

            // 解法C: LINQ 方法語法

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 6, 23, 17, 4, 10, 19, 13, 25, 28, 3 };
            //foreach (int i in numbers)
            //{
            //    if (i > 8)
            //    {
            //        textBox1.Text = i.ToString();
            //    }
            //}

            //結果為type?
            foreach (var item in numbers)
                if (item > 8)
                    textBox1.Text += item + ",\r\n"  ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = { 6, 23, 17, 4, 10, 19, 13, 25, 28, 3 };
           IEnumerable<int> xa = from abc in numbers where abc > 8 select abc;
            //var xa = from abc in numbers where abc > 8 select abc;
            textBox2.Text = string.Join(",", xa)+$"  Total: {xa.Count()}";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] numbers = { 6, 23, 17, 4, 10, 19, 13, 25, 28, 3 };
            //var xa = numbers.Where((x) => { return x > 8; });
            var xa = numbers.Where(x => x > 8);
            textBox3.Text = string.Join(",", xa) + $"  Total: {xa.Count()}";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] numbers = { 6, 23, 17, 4, 10, 19, 13, 25, 28, 3 };
             //numbers.Count(x => x > 8);
            textBox4.Text = numbers.Count(x => x > 8).ToString() ;
        }
    }
}
