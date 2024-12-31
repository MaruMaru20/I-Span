using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_20241219
{
    internal class Program
    {
        //Lab 猜數字 1~100
        static void Lab()
        {
            int minNum = 1;    //數字範圍最小值
            int maxNum = 100;    //數字範圍最大值
            Random random = new Random();   //宣告一個Random
            int answer = random.Next(minNum, maxNum+1);   //產生1~100的隨機數
            int guess;  //使用者猜的數字
            int count = 0;  //猜的次數                       

            Console.WriteLine("答案為：" + answer);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            do
            {
                Console.Write($"請輸入 {minNum} ~ {maxNum} 的數字：");
                guess = int.Parse(Console.ReadLine());
                count++;
                if (guess > answer)
                {
                    if (guess <= maxNum)
                    {
                        maxNum = guess;
                    }
                    Console.WriteLine("太大了！");
                }
                else if (guess < answer)
                {
                    if (guess >= minNum)
                    {
                        minNum = guess;
                    }
                    Console.WriteLine("太小了！");
                }
                else
                {
                    Console.WriteLine($"恭喜你猜對了！答案是{answer}，你總共猜了{count}次");
                    Console.WriteLine("是否繼續遊戲？(Y/N)");
                    string input = Console.ReadLine();
                    if (input.ToUpper() == "Y")
                    {
                        answer = random.Next(1, 101);
                        count = 0;
                        minNum = 1;
                        maxNum = 100;
                        Console.WriteLine("答案為：" + answer);
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine();
                    }
                    else
                    {                        
                        Console.WriteLine("遊戲結束");
                    }
                } 
            } while (guess != answer);
        }        

        static void Main(string[] args)
        {
            Lab();
        }
    }
}
