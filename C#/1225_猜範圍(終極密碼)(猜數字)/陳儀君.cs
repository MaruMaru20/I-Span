using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20241225_game
{
    internal class Program
    {
        static void p6_猜數字()
        {
            Console.WriteLine("p6");

            //規劃
            //1.取亂數 --> 遊戲開始都是一個亂數 1~100
            //2.範圍提示 -->介於min和max之間
            //3.使用者要猜到幾次才會成功
            //4.詢問要不要重新開始(Y/N)


            //設定範圍
            int left = 1;
            int right = 100;

            //取得亂數

            Random xa = new Random();
            int ans = xa.Next(left, right + 1);
            Console.WriteLine($"答案為: {ans} \n");//先測試，要把答案輸出
            Console.WriteLine("遊戲開始，請輸入1 ~ 100之間的數值\t");
            Console.WriteLine("------------------------------------");

            int userInput = 0; //使用者輸入的數值，放到while會讀不到
            int total = 0;     //使用者猜了幾次，放到while會一直重置

            //讀取數值，判斷大小，給予提示
            while (userInput != ans)
            {
                Console.Write("請輸入數值:");
                userInput = Convert.ToInt32(Console.ReadLine());
                total++;

                if (userInput == ans)
                {
                    Console.WriteLine($"答案為: {ans}，恭喜答對(猜了 {total} 次)\n");
                }

                else if (left < userInput && userInput < right)
                {
                    left = (ans - userInput > 0) ? userInput : left;
                    right = (ans - userInput < 0) ? userInput : right;
                    Console.WriteLine($"請輸入 {left} 和 {right} 之間的數值\n");
                }

                else
                {
                    string memo = (userInput > right) ? "大" : "小";
                    Console.WriteLine($"輸入太 {memo} ，請介於 {left} 和 {right} 之間的數值\n");
                }
            }

            //詢問是否重新開始
            Console.WriteLine("是否要重新開始(Y/N)?");
            string startOver = Console.ReadLine();

            if (startOver == "Y" || startOver == "y")
            {
                p6_猜數字();
            }
            else if (startOver == "N" || startOver == "n")
            {
                Console.WriteLine("遊戲結束");
            }
        }

        
            
        static void Main(string[] args)
        {
            p6_猜數字();
        }
    }
}
