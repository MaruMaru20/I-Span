using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4
{
    public partial class Form3_updates : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        private BindingSource GOGO = new BindingSource();
        private int page = 1;
        private int pageSize = 105;
        private int total = 0;
        public Form3_updates()
        {
            InitializeComponent();
        }

        private void Form3_updates_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Day4.Properties.Settings.Default.DW2022);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
            GOGO.DataSource = ds.Tables["MyViewer"];
            dataGridView1.DataSource = GOGO;
            UPDATE.Enabled = false;
        }
        private void SetdataGridView1(string sql)
        {
            adapter.SelectCommand = new SqlCommand(sql, conn);
            adapter.Fill(ds, "MyViewer");
            GOGO.DataSource = ds.Tables["MyViewer"]; 

            dataGridView1.Columns[0].HeaderText = "ban";
            dataGridView1.Columns[1].HeaderText = "縮";
            dataGridView1.Columns[2].HeaderText = "念~~";
            
        }


        private void countpage()
        {

            
            string selectfrom = "DimCurrency"; 
            string keyzone = "CurrencyKey";   
            //SQL_select_from.Text = 
            //SQL_Key.Text =
            //SQL_Name.DataBindings.Add("Text", ds.Tables["MyViewer"], "currencyName");
            string countSql = $"SELECT COUNT(*) FROM {selectfrom}";
            SqlCommand sqldata = new SqlCommand(countSql, conn);
            conn.Open(); 
            total = (int)sqldata.ExecuteScalar(); 
            conn.Close();


         
            string sql = $"SELECT * FROM {selectfrom} ORDER BY {keyzone} OFFSET {(page - 1) * pageSize} ROWS FETCH NEXT {pageSize} ROWS ONLY";
            
            
            SetdataGridView1(sql);

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            
            countpage();
            UPDATE.Enabled = true;
        }

        private void SQL_select_from_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            builder.GetUpdateCommand().ToString();
            SqlCommand xx = builder.GetUpdateCommand();
            //Ans.Text = xx.CommandText; //偷看指令
            adapter.UpdateCommand = xx;
            int xxx = adapter.Update(ds,"MyViewer");
            Ans.Text = xxx.ToString();

        }

        private void PgDn_Click(object sender, EventArgs e)
        {
            Ans.Text = string.Empty;
            foreach (DataRow item in ds.Tables["MyViewer"].Rows)
            {
                //1,AFA,Axxxxx,Unchanged
                
                
                
                    Ans.Text += item[0].ToString() + " , ";
                    Ans.Text += item[1].ToString() + " , ";
                    Ans.Text += item[2].ToString() + " , ";
                    Ans.Text += item.RowState + "\r\n";
                    
                

                    //MessageBox.Show($"");


                //Ans.Text += string.Join(",", item.ItemArray) + " , " + (item.RowState) + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ans.Text = string.Empty;
            foreach (DataRow item in ds.Tables["MyViewer"].Rows)
            {
                //1,AFA,Axxxxx,Unchanged

                if (item.RowState != DataRowState.Unchanged)
                {
                    Ans.Text += item[0].ToString() + " , ";
                    Ans.Text += item[1].ToString() + " , ";
                    Ans.Text += item[2].ToString() + " , ";
                    Ans.Text += item.RowState + "\r\n";

                }
            }
        }
    }
}
