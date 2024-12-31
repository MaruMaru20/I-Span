using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    internal class Program
    {
        static void Game()
        {
            Console.Clear();
            Random a = new Random();
            int ans = a.Next(1, 101);
            int left = 1;
            int right = 100;
            Console.WriteLine($"答案為:{ans}");
            Console.WriteLine($"遊戲開始，請輸入{left} ~ {right}之間的數值");
            Console.WriteLine("-------------------------------------------------------------------");
            int x = 0;
            int total = 0;
            do
            {
                Console.Write("請輸入數值：");
                x = Convert.ToInt32(Console.ReadLine());

                if (x > right || x < left)
                {
                    Console.WriteLine($"請輸入{left} ~ {right}之間的數值");
                }
                else if (x < ans && x > left)
                {
                    left = (x < ans) ? x : left;
                    Console.WriteLine($"介於{left}~{right}之間");
                    total += 1;
                }
                else if (x > ans && x > left)
                {
                    right = (x > ans) ? x : right;//如果x > ans right = x    如果x != ans  right=right
                    Console.WriteLine($"介於{left}~{right}之間");
                    total += 1;
                }
                else
                {
                    Console.WriteLine($"答案為{ans} 恭喜答對(猜了{total}次)");
                    Console.WriteLine("\n");
                }
            }
            while (x != ans);
            //return Console.ReadLine().ToUpper() == "y";
        }

        static void Main(string[] args) 
        {
            ////初學
            //string again;
            //do
            //{
            //    Game();
            //    Console.WriteLine("您要繼續玩嗎? (Y/N)");
            //    again = Console.ReadLine().ToLower();
            //}
            //while (again == "y");

            //進階
            while (  true  ) 
            {
                Console.WriteLine("是否要開始遊戲? (Y/N)");
                string play = Console.ReadLine();
                if (play?.ToUpper() != "Y") 
                {
                    Console.WriteLine("結束!");
                    break;
                }
                Console.Clear();
                Game();
            }
        }
    }
}
