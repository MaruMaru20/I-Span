using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241225_Game_v2
{
    internal class Program
    {
        static bool game_Guess_Num_v2()
        {
            Console.Clear();
            bool gameStatus = true;
            int times = 0;
            int guess = 0;
            int min = 1;
            int max = 100;
            int down = min;
            int up = max;
            Random rnd = new Random();
            int ans = rnd.Next(min, max + 1);

            Console.WriteLine($"答案為:{ans}");
            Console.WriteLine($"請輸入{min}~{max}的值");
            Console.WriteLine("--------------------------------------");

            while (gameStatus)
            {
                try
                {
                    Console.Write("請輸入數值:");

                    guess = int.Parse(Console.ReadLine());
                    times++;

                    if ((guess < min) || (guess > max))
                    {
                        Console.WriteLine($"請輸入{min}~{max}的值");
                        continue;
                    }

                    if (guess == ans)
                    {
                        Console.WriteLine($"答案為{ans}，恭喜答對!共猜了{times}次");
                        gameStatus = false;
                    }
                    else if ((guess <= up) && (guess >= down))
                    {
                        up = (guess > ans) ? guess : up;
                        down = (guess < ans) ? guess : down;
                        Console.WriteLine($"介於{down}到{up}之間");
                    }
                    else
                    {
                        string otherStr = (guess > up) ? "大" : "小"; ;
                        Console.WriteLine($"輸入太{otherStr}，介於{down}到{up}之間");
                    }


                }
                catch (Exception e)
                {
                    gameStatus = false;
                    Console.WriteLine($"請輸入數字{e}");
                }

            }

            Console.WriteLine("是否繼續遊戲?(Y/N)");
            return Console.ReadLine().ToLower() == "y";
        }
        static void Main(string[] args)
        {
            while (game_Guess_Num_v2()) { }
        }
    }
}
