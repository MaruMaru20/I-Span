using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2
{
    public partial class Form1 : Form
    {
        //Shark shark = new Shark();
        //string shark = "3333333";
        //List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
            //Console.WriteLine("0000000");
            textBox1.Text = "00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("1111111");
            textBox1.Text += "11";

        }
    }

    class Shark
    {
        public Shark()
        {
            Console.WriteLine("123123");
        }
    }
}
