using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab241225_Game
{
    internal class Program
    {
        static void game()
        {
            int score = 0;
        Start:
            Console.WriteLine("==========終極密碼 最終決定版==========");
            Random x = new Random();
            int anw = x.Next(1, 100);
            //隱藏解答
            //Console.WriteLine($"答案為:{anw}");
            Console.WriteLine("請依提示猜數字，猜超過10次挑戰即失敗");
            Console.WriteLine("遊戲開始，請輸入1~100之間的數值");
            Console.WriteLine($"您的分數為:{score}");
            Console.WriteLine("---------------------------------------");

            int times = 0;
            int maxnum = 100;
            int minnum = 1;

            int result;
            while (true)
            {
                Console.Write("請輸入數值：");
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    int guest = result;
                    if (times >= 9)
                    {
                        x = new Random();
                        anw = x.Next(1, 100);
                        Console.WriteLine("猜超過10次，挑戰失敗，分數-1");
                        score--;
                    AskAgain:
                        Console.WriteLine("是否要再玩一次?( Y / N )");
                        string ask = Console.ReadLine().ToUpper();
                        if (ask == "Y")
                        {
                            Console.Clear();
                            goto Start;
                        }
                        else if (ask == "N")
                        {
                            Console.Clear();
                            Console.WriteLine("感謝您的遊玩!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("請輸入Y或是N!");
                            goto AskAgain;
                        }
                    }
                    else if (guest < minnum || guest > maxnum)
                    {
                        Console.WriteLine($"超出範圍，請輸入{minnum}~{maxnum}之間的數值");
                        times++;
                    }
                    else if (guest < anw)
                    {
                        minnum = guest;
                        Console.WriteLine($"請輸入介於{guest}~{maxnum}之間的數值");
                        times++;
                    }
                    else if (guest > anw)
                    {
                        maxnum = guest;
                        Console.WriteLine($"請輸入介於{minnum}~{guest}之間的數值");
                        times++;
                    }
                    else
                    {
                        times++;
                        Console.WriteLine($"答案為{anw}，恭喜答對!分數+1， 您一共猜了{times}次");
                        score++;
                    AskAgain:
                        Console.WriteLine("是否要再玩一次?( Y / N )");
                        string ask = Console.ReadLine().ToUpper();
                        if (ask == "Y")
                        {
                            Console.Clear();
                            goto Start;
                        }
                        else if (ask == "N")
                        {
                            Console.Clear();
                            Console.WriteLine("感謝您的遊玩!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("請輸入Y或是N!");
                            goto AskAgain;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("輸入了無效數值！請輸入一個有效的整數");
                }
            }



        }
        static void Main(string[] args)
        {
            game();
        }
    }
}
