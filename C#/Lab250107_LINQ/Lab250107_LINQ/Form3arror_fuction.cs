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


        //定義
        public delegate string Travel(string Photo, string data, int fee);

        private void button3_Click(object sender, EventArgs e)
        {

            Travel B = Passport;
            string GOGO = B("photo", "You", 985600000);
            textBox3.Text = GOGO;
     
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            Travel C = (string Photo, string data, int fee) => { return $"OK Give me the money!!!!!!!"; };
            string GOGO = C("photo", "Me", 985600000);
            textBox4.Text = GOGO;
        }
        // if return only   {return }; 
        private void button5_Click(object sender, EventArgs e)
        {
            Travel C = (string Photo, string data, int fee) => $"OK!";
            string GOGO = C("photo", "Me", 985650000);
            textBox5.Text = GOGO;
        }
        //data type gone lambda
        //func<inA,inB,out> name (inA inB) => out;
        private void button6_Click(object sender, EventArgs e)
        {
            Func<string, string, int, string> C = ( photo,  data,  fee) => $"O...K...!";
            string GOGO = C("photo", "Me", 50);
            textBox6.Text = GOGO;
        }
    }


}
