using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab250107_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void swap1(ref int x, ref int y)
        {
            //textBox1.Text = $"交換前x:{x},y:{y}\r\n";
            int temp;
            temp = x;
            x = y;
            y = temp;
            //textBox1.Text += $"交換後x:{x},y:{y}";
        }

        private void swap10(ref double x, ref double y)
        {
            //textBox1.Text = $"交換前x:{x},y:{y}\r\n";
            double temp;
            temp = x;
            x = y;
            y = temp;
            //textBox1.Text += $"交換後x:{x},y:{y}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = 10;
            int y = 20;
            textBox1.Text = $"交換前x:{x},y:{y}\r\n";


            swap1(ref x, ref y); //傳入 X Y

            textBox1.Text += $"交換後x:{x},y:{y}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = 4.02;
            double y = 5.98;
            textBox2.Text = $"交換前x:{x},y:{y}\r\n";
            swap10(ref x, ref y);

            textBox2.Text += $"交換後x:{x},y:{y}";
        }

        //泛型 generic

        private void swap100<User>(ref User x, ref User y)
        {
            User temp;
            temp = x;
            x = y;
            y = temp;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            bool x = true;
            bool y = false;
            textBox3.Text = $"交換前x:{x},y:{y}\r\n";
            swap100<bool>(ref x, ref y);

            textBox3.Text += $"交換後x:{x},y:{y}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Master One = new Master();
            One.Name = "KuKu";
            Master Two = new Master();
            Two.Name = "DoDo";
            textBox4.Text = $"交換前x:{One.Name},y:{Two.Name}\r\n";
            swap100<Master>(ref One, ref Two);
            textBox4.Text += $"交換後x:{One.Name},y:{Two.Name}";
            textBox4.Text += $"\r\n現在{One.Name} 是 {Two.Name}";
            textBox4.Text += $"\r\n現在{Two.Name} 是 {One.Name}";
        }
    }

    class Master
        {
            public string Name { get; set; }
            
        }

}
