using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab241230_ADO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xa = this.textBox1.Text;
            Console.WriteLine(xa);

            //add combox option

            //#1
            this.comboBox1.Items.Add(xa);


            //this.comboBox1.Items.Add(123);
            //this.comboBox1.Items.Add(true);
            //this.comboBox1.Items.Add(5.12);

            //#2
            string[] xb = new string[] { "aaa" };
            this.comboBox1.Items.AddRange(xb);

            //#3  
            this.comboBox1.Items.AddRange(new string[] { "a", "b" });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Controls;
            foreach (Control item in this.Controls)
            {
                //Console.WriteLine(item.Name);
                this.listBox1.Items.Add(item.Name);
            }

        }
    }
}
