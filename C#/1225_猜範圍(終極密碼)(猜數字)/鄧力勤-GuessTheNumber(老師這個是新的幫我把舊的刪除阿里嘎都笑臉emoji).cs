using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main()
        {
            // checknum函數判斷input值有無違反規定，用try...catch攔截格式錯誤
            // 最後再將input值傳回Main
            int checknum(ref int minnum, ref int maxnum)
            {
                while (true) //while(true) 重複直到input符合規定
                {
                    try
                    {
                        int tmp = Convert.ToInt32(Console.ReadLine());
                        if (tmp >= maxnum)
                        {
                            Console.WriteLine("太大了，請重新輸入");
                            Console.Write("請輸入數值:");
                        }
                        else if (tmp <= minnum)
                        {
                            Console.WriteLine("太小了，請重新輸入");
                            Console.Write("請輸入數值:");
                        }
                        else
                            return tmp;
                    }
                    catch (FormatException) //FormatException 格式錯誤
                    {
                        Console.WriteLine("輸入的內容不是有效的整數，請再試一次。");
                        Console.Write("請輸入數值:");
                    }
                }
            }
            //將code包成一個函數，方便呼叫。
            void game()
            {
                Console.WriteLine("==========終極密碼==========");
                Random rn = new Random();
                int num = rn.Next(100);
                Console.WriteLine("數字為{0}", num);
                int min = 0;
                int max = 100;
                Console.WriteLine("遊戲開始，請輸入 {0} - {1} 之間的數值", min, max);
                Console.WriteLine("============================");


                for (int i = 1; i <= 100; i++)
                {
                    Console.Write("請輸入數值:");
                    int input = checknum(ref min, ref max); //checknum函數會將值return to input

                    if (input == num)
                    {
                        Console.WriteLine("恭喜！你猜中了，你猜了{0}次", i);
                        break;
                    }
                    else if (input < num)
                    {
                        min = input;
                    }
                    else
                    {
                        max = input;

                    }
                    Console.WriteLine("介於 {0} 和 {1} 之間", min, max);
                }
                //重複遊玩，使用try...catch，攔截格式錯誤
                Console.Write("再次遊玩?(Y/N)=>");
                while (true)
                {
                    try
                    {
                        string NG = Console.ReadLine();
                        NG = NG.ToUpper();
                        if (NG == "Y")
                        {
                            Console.Clear();
                            game();
                            return;
                        }
                        else if (NG == "N")
                        {
                            Console.Write("再見 掰掰!! 笑臉emoji");
                            return;
                        }
                        else
                            Console.Write("你再給我亂輸入試試看=>");
                    }
                    catch (FormatException)
                    {
                        Console.Write("請再試一次=>");
                    }
                }
            }
            //主程式
            game();
        }
    }
}
