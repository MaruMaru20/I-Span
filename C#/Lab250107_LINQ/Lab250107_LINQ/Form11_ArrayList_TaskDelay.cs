using System;
using System.Collections;
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
    public partial class Form11_ArrayList_TaskDelay : Form
    {
        public Form11_ArrayList_TaskDelay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ArrayList
            ArrayList xa = new ArrayList();
            xa.Add(123);
            xa.Add(true);
            xa.Add("Cool");
            xa.Add(456);
            xa.Add(false);
            xa.Add("NotCool");
            //只要取出字串
            //方法A: 一個一個拿出來確認 > 把不要der搬到其他地方
            //想一下LINQ

            //xa.OfType<string>().ToArray();
            //textBox1.Text = string.Join(",",xa.ToArray());
            IEnumerable<int> xb = xa.OfType<int>();
            textBox1.Text += string.Join(",", xb);

            //var xb =xa
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList xa = new ArrayList();
            xa.Add("tea");
            xa.Add("blacktea");
            xa.Add("Cooltea");
            xa.Add("bubbletea");
            xa.Add("falseblacktea");
            xa.Add("NotCooltea");
            //*集合*  改變的時候    語法要微調       (tea.indexof("")>=0)
            var xb = from string tea in xa where tea.Contains("blacktea") select tea;
            textBox2.Clear();
            textBox2.Text += string.Join(",\r\n", xb);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList xa = new ArrayList();
            xa.Add("tea");
            xa.Add("blacktea");
            xa.Add("Cooltea");
            xa.Add("bubbletea");
            xa.Add("falseblacktea");
            xa.Add("NotCooltea");
            //*集合*  改變的時候    語法要微調       (tea.indexof("")>=0)
            var xb = from string tea in xa where tea.Contains("blacktea") select tea;

            xa.Add("toffguytea");
            xa.Add("greenblacktea");
            xa.Add("purpleblacktea");

            textBox2.Clear();
            textBox2.Text += string.Join(",\r\n", xb);  //Task,delay
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> xa = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var xb = xa.Skip(3);
            textBox4.Text += $"第一次: " +string.Join(",", xb)+ "\r\n";

            xa.Clear();
            // xa.Clear()執行後會將所有項目移除 所以第2次查詢不會有結果(因為xa的值已被清除)
            //xa.Clear() 執行後，因為 Skip(3) 是延遲執行的，xb 每次取值時都會重新從 xa 中讀取內容。因此，清空 xa 後，xb 的結果為空集合。
            textBox4.Text += $"第二次: " + string.Join(",", xb) + "\r\n"+"123";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> xa = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var xb = xa.Skip(3).ToList();
            textBox5.Text += $"第一次: " + string.Join(",", xb) + "\r\n";

            xa.Clear();
            // 因為 Skip(3).ToList() 是立即執行的，xb 已經存儲了執行結果，與 xa 無關。因此，執行 xa.Clear() 不會影響 xb，第二次查詢的結果與第一次相同。


            textBox5.Text += $"第二次: " + string.Join(",", xb) + "\r\n" + "123";

        }
    }
}
