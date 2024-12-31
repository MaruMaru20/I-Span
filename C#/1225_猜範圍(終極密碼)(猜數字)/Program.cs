using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab241225game
{
    internal class Program
    {
        static void P1_GuessNumber()
        {
            //Console.WriteLine("P1");
            Console.WriteLine("============ 教學版 ============");
            int number = 0;
            int numbers = 1;
            int numberb = 100;
            Random rand = new Random();
            int answer = rand.Next(numbers, numberb + 1);//讓範圍可以更改
            int times = 1;
            Console.WriteLine($"答案為：{answer}");
            Console.WriteLine("遊戲開始，請輸入 1 ~ 100 之間的數值");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            while (answer != number)
            {
                Console.Write("請輸入數值：");
                number = int.Parse(Console.ReadLine());
                //Console.WriteLine($"{(number>answer?$"介於 {numbers} 和 {number} 之間": $"介於 {number} 和 {numberb} 之間")}");
                if (number > answer)
                {

                    if (number > numberb)
                    {
                        number = numberb;
                        Console.WriteLine($"輸入太大，介於 {numbers} 和 {number} 之間");
                    }
                    else
                    {
                        numberb = number;
                        Console.WriteLine($"介於 {numbers} 和 {number} 之間");
                    }

                }
                else if (number < answer)
                {

                    if (number < numbers)
                    {
                        number = numbers;
                        Console.WriteLine($"輸入太小，介於 {number} 和 {numberb} 之間");
                    }
                    else
                    {
                        numbers = number;
                        Console.WriteLine($"介於 {number} 和 {numberb} 之間");
                    }

                }
                else
                {
                    Console.WriteLine($"答案為 {answer} ，恭喜答對 (猜了 {times} 次)");
                }
                Console.WriteLine("");
                times++;
            }
        }
        static void P2_GuessNumber2()
        {
            //Console.WriteLine("P2");
            Console.WriteLine("============ 終極版 ============");
            int number = 0;
            int small = 1;
            int big = 100;
            Random rand = new Random();
            int answer = rand.Next(small, big + 1);//讓範圍可以更改
            int times = 1;
            Console.WriteLine($"答案為：{answer}");
            Console.WriteLine("遊戲開始，請輸入 1 ~ 100 之間的數值");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");
            while (answer != number)
            {
                Console.Write("請輸入數值：");
                number = int.Parse(Console.ReadLine());
                if (number > answer)
                {
                    big = number > big ? big : number;
                }
                else
                {
                    small = number < small ? small : number;
                }
                Console.WriteLine($"{(number == answer ? $"答案為 {number} ，恭喜答對 (猜了 {times} 次)\n" : small<number&&number<big? $"介於 {small} 和 {big} 之間\n":number>big?$"輸入太大，請介於 {small} 和 {big} 之間\n":number<small? $"輸入太小，請介於 {small} 和 {big} 之間\n": $"介於 {small} 和 {big} 之間\n")}");
                times++;
            }
            Console.WriteLine("是否要繼續遊戲? (Y/N)");
            string xa = Console.ReadLine().ToUpper();
            Console.Clear();

            if (xa == "Y")
            {
                P2_GuessNumber2();
            }
            else if (xa == "N")
            {
            }
        }
        static void Main(string[] args)
        {
            //P1_GuessNumber();
            P2_GuessNumber2();
        }
    }
}
