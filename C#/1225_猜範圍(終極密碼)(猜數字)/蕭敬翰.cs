using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace lab_2024._12._25_game
{
    internal class Program
    {
        public static void a()
        {
            Console.Clear();
            Random r = new Random();
            // 不包含 maxValue
            int result = r.Next(1, 101);
            int min = 1;
            int max = 100;
            bool win = false;
            int i = 0;     // 次數

            
            Console.WriteLine($"輸入{min}~{max}之間的數值");
            Console.WriteLine("--------------------------------------");


            while (!win)
            {
                i++;
                Console.Write("\n請輸入數值 : ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > max || guess < min)
                {
                    Console.WriteLine($"超過範圍，輸入{min} ~ {max} 之間的數");
                    continue;
                }

                if (guess > result)
                {
                    max = guess;
                    Console.WriteLine($"介於 {min} 和 {max} 之間");
                }else if(guess < result)
                {
                    min = guess;
                    Console.WriteLine($"介於 {min} 和 {max} 之間");
                }
                else
                {
                    win = true;
                    Console.WriteLine($"答案:{result}，猜對了 (猜了{i}次)");
                }
              
            }
        }
        static void Main(string[] args)
        {
            First:
            a();

            Next:
            Console.WriteLine("\n是否繼續遊戲(Y/N)");
            string nextGame = Console.ReadLine().ToLower();
            if (nextGame != "y" && nextGame != "n")
            {
                goto Next;
            }
            else if (nextGame == "y")
            {
                
                goto First;
            }

        }
    }
}
