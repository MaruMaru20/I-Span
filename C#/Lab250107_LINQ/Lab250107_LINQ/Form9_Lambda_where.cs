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
    public partial class Form9_Lambda_where : Form
    {
        public Form9_Lambda_where()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int[] xa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool apple(int x) { return x > 5; }
            var xb = xa.Where(apple);

            textBox1.Text = string.Join(",", xb);
        }

        private void Form9_Lambda_where_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] xa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Func<int, bool> bee = (xdog) =>
            {
                if (xdog > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            //;            bool apple(int x) { return x > 5; }
            var xb = xa.Where(bee);

            textBox2.Text = string.Join(",", xb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] xa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            var xb = xa.Where((x) => { return x > 5; });

            textBox3.Text = string.Join(",", xb);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
