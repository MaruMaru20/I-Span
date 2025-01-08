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
    public partial class Form5_interface : Form
    {
        public Form5_interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //介面的實作
            Student S1 = new Student();
            S1.SName = "哭啊";
            textBox1.Text = S1.HowToRead("齁\r\n");
            textBox1.Text += S1.restaurant("\r\n");
            Teacher T1 = new Teacher();
            T1.TName = "Jeff";
            textBox1.Text += T1.HowToRead("去路易莎睡");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car MyCar = new Car();
            textBox2.Text = MyCar.Start() + "\r\n";
            textBox2.Text += MyCar.Stop() + "\r\n";

            Mini_cooper MyCar2 = new Mini_cooper();
            textBox2.Text += MyCar2.Start() + "\r\n";
            textBox2.Text += MyCar2.Stop() + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Volvo ddd = new Volvo();
            textBox3.Text = ddd.Start() + "\r\n";
            textBox3.Text += ddd.Stop();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Car ddd = new Volvo();
            Volvo volvoCar = ddd as Volvo;
            string customMessage = "Hello, user!";
            textBox4.Text += volvoCar.Start(customMessage) + "\r\n";
            textBox4.Text += ddd.Stop();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Car aa = new Mini_cooper();

            //textBox4.Text = aa.Start() + "\r\n";
            //textBox4.Text += aa.Stop();
        }

        private void Form5_interface_Load(object sender, EventArgs e)
        {

        }
    }

}
