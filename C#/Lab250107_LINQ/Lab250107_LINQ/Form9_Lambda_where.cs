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
    }
}
