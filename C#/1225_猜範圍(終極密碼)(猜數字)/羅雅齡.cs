using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20241225_3
{
    internal class Program
    {
        static void 終極密碼()
        {
            
            Random r = new Random();
            int ra = r.Next(1, 100);
            int tt = 1; //猜幾次
            int hn = 100; //最大值
            int ln = 1; //最小值

            Console.WriteLine("答案為:{0}", ra);
            Console.WriteLine("遊戲開始，請輸入{0}~{1}之間的數值",ln,hn);
            Console.WriteLine("-------------------------------------");

            for (; ; )
            {
                Console.Write("請輸入數值：");
                int r1 = Convert.ToInt32(Console.ReadLine());

                if (r1 == ra)
                {
                    Console.Write("\n答案為{0}，恭喜答對（猜了{1}次）", r1, tt);
                    break;
                }
                else if (r1 > 100 || r1 < 1)
                {
                    tt++;
                    Console.Write("\n數字太大，請介於{0}和{1}之間\n", ln, hn);
                }
                else if (r1 > ra || r1 == hn)
                {
                    tt++;
                    hn = r1;
                    Console.Write("\n數字太大，請介於{0}和{1}之間\n", ln, hn);
                }
                else
                {
                    tt++;
                    ln = r1;
                    Console.Write("\n數字太小，請介於{0}和{1}之間\n", ln, hn);
                }

            }
        }
        static void Main(string[] args)
        {
            終極密碼();

            while (true) {
            Console.WriteLine("\n要再玩一次嗎？(y/n)");
            string r2 = Console.ReadLine();
            if (r2 == "y")
            {
               Console.WriteLine("-------------------------------------");
               終極密碼();
            }
            else { break; }}
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
        }
    }
}
