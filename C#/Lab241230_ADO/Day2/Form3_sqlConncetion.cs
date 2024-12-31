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
    public partial class Form3_sqlConncetion : Form
    {
        public Form3_sqlConncetion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            button1.Location = new Point(328, 24);
            button1.Width = 134;
            button1.Height = 59;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button2.Text = "按鈕";
            button2_Click(sender, e);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Before U Get data : Check it first!
            string sql = "select * from DimCurrency";

            //sever
            string conn = "Data Source=DESKTOP-AVM54SB\\SQLEXPRESS;Initial Catalog=AdventureWorksDW2022;Integrated Security=True;TrustServerCertificate=True\r\n";
            //connection setting
            SqlConnection shark = new SqlConnection(conn);

            // new
            SqlDataAdapter jeff = new SqlDataAdapter(sql, shark);

            //background setting : Done
            DataSet newset01 = new DataSet();
            jeff.Fill(newset01);

            // show
            this.dataGridView1.DataSource = newset01.Tables[0];

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Day2.Properties.Settings.Default.AdventureWorksDW2022ConnectionString;
            SqlConnection sqlstring = new SqlConnection(textBox1.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            
            //SqlDataAdapter sqlcomm = new SqlDataAdapter("select * from DimCurrency");
            //DataSet newset01 = new DataSet();
            //sqlcomm.Fill(newset01, "bbaann2");

            //dataGridView2.DataSource = newset01.Tables["bbaann2"];

        }

        private void Form3_sqlConncetion_Load(object sender, EventArgs e)
        {

        }
    }
}
