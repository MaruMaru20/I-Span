using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20241225_Game
{
    internal class Program
    {
        static void check_ans(int ans, int min, int max)
        {
            int guess = userInput();
            Console.WriteLine("");
            int count = 1;
            bool bingo = false;
            while (!bingo)
            {
                if (ans == guess)
                {
                    Console.WriteLine($"答案為：{ans}，恭喜答對! (猜了{count}次)");
                    bingo = true;
                    Console.WriteLine("");
                    break;
                }
                else if (guess > ans)
                {
                    if (!(guess > max))
                    {
                        max = guess;
                    }
                    Console.WriteLine($"輸入太大，請介於 {min} 和 {max} 之間");
                    Console.WriteLine("");
                    count++;
                }
                else if (guess < ans)
                {
                    if (!(guess < min))
                    {
                        min = guess;
                    }
                    Console.WriteLine($"輸入太小，請介於 {min} 和 {max} 之間");
                    Console.WriteLine("");
                    count++;
                }
                Console.Write("請輸入數值：");
                guess = Convert.ToInt32(Console.ReadLine());
            }

        }
        static int set_answer(int min, int max)
        {
            Random myObject = new Random();
            int ans = myObject.Next(min, max + 1);

            Console.WriteLine("===========教學版===========");
            Console.WriteLine($"答案為：{ans}");
            Console.WriteLine($"遊戲開始，請輸入{min}~{max}之間的數值");
            Console.WriteLine("----------------------------\n");
            return ans;
        }

        static int userInput()
        {
            int number;
            Console.Write("請輸入數值：");
            bool isNumber = Int32.TryParse(Console.ReadLine(), out number);
            while (!isNumber)
            {
                Console.Write("\n必須輸入\"數字\"，請重新輸入數值 :");
                isNumber = Int32.TryParse(Console.ReadLine(), out number);
                Console.WriteLine(isNumber);
            }
            return number;
        }

        static void Main(string[] args)
        {
            bool play = true;
            while (play)
            {
                int min = 1;
                int max = 100;
                int ans = set_answer(min, max);
                check_ans(ans, min, max);
                Console.Write("是否要繼續遊戲嗎(y/n)：");
                string playAgain = Console.ReadLine().ToLower();
                Console.WriteLine("\n");
                if (playAgain == "n")
                {
                    play = false;
                    Console.Write("===========結束遊戲===========\n\n");
                }
                else
                {
                    Console.Clear();

                }
            }

        }
    }
}
