using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_game_241215
{
    internal class Program
    {
        static void game()
        {
            Console.Clear();
            Console.WriteLine("game");
            Random rand = new Random();
            int min = 1, max = 100;
            int ans = rand.Next(min, max + 1); //include min but smaller than max 
            int count = 0, limit = 6;
            int input;
            Console.WriteLine($"答案為 : {ans} \n遊戲開始，請輸入 {min} ~ {max} 之間的整數值");
            Console.WriteLine($" {limit} 次內沒猜到就輸囉 : ) ");
            Console.WriteLine("\n-------------------------------------------------\n");
            void constr()
            {
                Console.Write("請輸入數值 : ");
                //input = Convert.ToInt32(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine(), out input))　//防亂
                {
                    Console.WriteLine(" 輸入數字 ! ! ! ");
                    Console.WriteLine("\n-------------------\n");
                    constr();
                }
                Console.WriteLine();
                count += 1;
                if (input == ans)   //答對
                {
                    Console.WriteLine($"答案為 {ans} ，恭喜答對 ( 猜了 {count} 次 ) ");
                    Console.WriteLine("\n-------------------\n");
                }
                else if (count == limit) //限制次數
                {
                    Console.WriteLine("You Are Loser ! ! !");
                    Console.WriteLine("\n-------------------\n");
                }
                else if (input > max)  // 超出最大值
                {
                    Console.WriteLine($"輸入數值太大，請介於 {min} 和 {max} 之間");
                    Console.WriteLine("\n-------------------\n");
                    constr();
                }
                else if (input < min)  //超出最小值
                {
                    Console.WriteLine($"輸入數值太小，請介於 {min} 和 {max} 之間");
                    Console.WriteLine("\n-------------------\n");
                    constr();
                }
                else if (input > ans)  //判斷大於答案
                {
                    Console.WriteLine($"介於{min} 到 {input} 之間");
                    if (input < max) max = input;
                    Console.WriteLine("\n-------------------\n");
                    constr();
                }
                else if (input < ans)  //判斷小於答案
                {
                    Console.WriteLine($"介於{input} 到 {max} 之間");
                    if (input > min) min = input;
                    Console.WriteLine("\n-------------------\n");
                    constr();
                }
            }
            //game
            constr();
        }

        static void Main(string[] args)
        {
            string restart;
            do
            {
                game();
                Console.WriteLine("是否要繼續玩遊戲 ?  ( Y / N )");
                Console.WriteLine("\n-------------------\n");
                restart = Console.ReadLine();
            }
            while (restart.ToUpper() == "Y");
        }

    }
}

