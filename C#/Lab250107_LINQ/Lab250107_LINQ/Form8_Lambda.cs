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
    public partial class Form8_Lambda : Form
    {
        public Form8_Lambda()
        {
            InitializeComponent();
        }


        //First  : 挑選符合條件的第一個 -> 不指定 就是位置0
        //select : 將序列的元素規劃成一個新的表單
        private void button1_Click(object sender, EventArgs e)
        {

            int[] xa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Func<int, int> lion = x => 5566;
            var xb = xa.Select(lion);
            textBox1.Text = string.Join(Environment.NewLine, xb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] xa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var xb = xa.Select(x => 5678);
            textBox2.Text = string.Join(Environment.NewLine, xb);

            textBox2.Text = string.Join(Environment.NewLine, xa.Select(x => x));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] xa = { "1", "2", "3", "4", "5" };
            //var xb = xa.Select(x => Convert.ToInt32(x));

            //textBox3.Text = string.Join(Environment.NewLine, xb);

            textBox3.Text = string.Join(Environment.NewLine, xa.Select(x => Convert.ToInt32(x)));

            //
            //int[] xb = new int[xa.Length];  //宣告數字陣列
            //xb[0] = Convert.ToInt32(xa[0]); //取得xa的值(轉整數後)放到xb
            //for (int i = 0; i < xa.Length; i++) 
            //{
            //xb[i] = Convert.ToInt32(xa[i]); 

            //}
            //textBox3.Text = string.Join(Environment.NewLine, xb);







        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
