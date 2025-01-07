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
    public partial class Form3arror_fuction : Form
    {
        public Form3arror_fuction()
        {
            InitializeComponent();



        }

        string Passport(string Photo, string data, int fee)
        {
            return "OK Give me the money!";
        }

        //自己辦
        private void button1_Click(object sender, EventArgs e)
        {
            string tmp = Passport("ME","data",90000);

            textBox1.Text = tmp;
        }
        //旅行社
        public delegate string 旅行社(string Photo, string data, int fee);
        private void button2_Click(object sender, EventArgs e)
        {
            旅行社 A = Passport;
            string xx =    A("Photo", "data", 9568000+50000);
            textBox2.Text = xx;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            旅行社 B =  //???;
        }
    }
}
