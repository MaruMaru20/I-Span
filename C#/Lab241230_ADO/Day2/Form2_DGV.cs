using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2
{
    public partial class Form2_DGV : Form
    {
        public Form2_DGV()
        {
            InitializeComponent();
        }

        private void Form2_DGV_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'adventureWorksDW2022DataSet.DimCurrency' 資料表。您可以視需要進行移動或移除。
            this.dimCurrencyTableAdapter.Fill(this.adventureWorksDW2022DataSet.DimCurrency);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //#1 用集合[]
            //this.dataGridView1.Columns[0].HeaderText = "Ban";
            //this.dataGridView1.Columns[1].HeaderText = "縮";
            //this.dataGridView1.Columns[2].HeaderText = "念";

            //#2 資料行名稱設定
            //this.currencyKeyDataGridViewTextBoxColumn.HeaderText = "ban";
            //this.currencyAlternateKeyDataGridViewTextBoxColumn.HeaderText = "縮";
            //this.currencyNameDataGridViewTextBoxColumn.HeaderText = "念";


            //#3 老師不愛
            //this.dataGridView1.Columns["currencyKeyDataGridViewTextBoxColumn"].HeaderText = "Ban";


            //List<>   arrayList  dtring[]
            string[] xa = { "Ban~", "縮~", "念~" };
            for (int a = 0; a < xa.Length; a++)
            {
                this.dataGridView1.Columns[a].HeaderText = xa[a];
            }

            //SqlConnection




            button1.Text = "你按";
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            textBox1.Text = "歐    買    嘎";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
