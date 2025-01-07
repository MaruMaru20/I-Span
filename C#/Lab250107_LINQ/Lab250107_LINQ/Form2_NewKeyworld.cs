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
    public partial class Form2_NewKeyworld : Form
    {
        public Form2_NewKeyworld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //陣列宣告時就給值不需要new
            bool[] xxx = new bool[26];
            bool[] yxx = new bool[] { true, false, true, false };
            bool[] zxx = { true, false, true, false };



            string[] xx = new string[]
            {
                "01","02","03"
            };
            textBox1.Text = xx[0]+"\r\n";
            textBox1.Text += xx[1] + "\r\n";
            textBox1.Text += xx[2] + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XPhone Zero = new XPhone();
            Zero.Phone = "A53";
            XPhone One = new XPhone();
            One.Phone = "Note 9";
            XPhone Two = new XPhone();
            Two.Phone = "iphone 12";
        }
        //匿名類別
        private void button3_Click(object sender, EventArgs e)
        {
            //JS let xa = {key:value,.........}
            //C# let xa = {key=value,.........}
            var xa = new { Cat = "meow", Dog = "None" };
            textBox3.Text += $"{xa.Cat}";
        }
    }

    class XPhone
    {
        public string Phone { get; set; }
    }
}
