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
    public partial class Form4_first_SelectData : Form
    {
        public Form4_first_SelectData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] xx = new int[] { 5, 6, 7, 8 };
            int xy = xx.First();

            textBox1.Text = xy.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] xx = new int[] { 5, 6, 7, 8 };

            //products
            //products[] aaa = new products[] {{},{},{}}

            bool MyFunc(int yy)
            {
                if (yy > 6)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            int xy = xx.First(MyFunc);
            textBox2.Text = xy.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] xx = new int[] { 5, 6, 888, 999 };

            Func<int, bool> Top1 = (int yy) => { return yy > 10; };

            //int xy = xx.First(Top1);
            //textBox3.Text = xy.ToString();
            textBox3.Text = xx.First(Top1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] xx = new int[] { 5, 6, 666, 777 };

            Func<int, bool> Top1 = yy => yy > 10;

            textBox4.Text = xx.First(Top1).ToString();
        }
        //代理人 lambda
        private void button5_Click(object sender, EventArgs e)
        {
            int[] xx = new int[] { 5, 6, 11, 12 };

            textBox5.Text = xx.First(yy => yy == 12).ToString();
        }
    }
}
