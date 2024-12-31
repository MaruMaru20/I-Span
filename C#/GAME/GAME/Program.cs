using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
    internal class Program
    {

        static void game()
        {

            Console.Clear();
            var rand = new Random();
            int min = 0, max = 101;
            int ans = rand.Next(min, max);

            int input = 0;
            int count = 0;
            int err = 3;       //防亂計數器
            int min2 = min +1, max2 = max-1;
            Console.Write($"答案為 :");
            Console.WriteLine(ans);
            //Console.Clear();   //估掰了答案

            Console.WriteLine($"-----------------猜數字-----------------");
            Console.WriteLine($"請輸入 {min2} ~ {max2}之間的數字 ");
            Console.WriteLine(new string('-', +40));


            while (input != ans)                     //迴圈開始!
            {
                Console.Write("請輸入 :");
                //input = Convert.ToInt32(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine(), out input))　//防亂第一刀　要輸入數字 
                {
                    Console.WriteLine(" 輸 入 數 字 !");
                    err--;
                    if (err == 0)
                    {

                        Console.WriteLine($" 　˙　︿　˙　掰＆＿＊︿＃＄＠＆＊");
                        
                        break;
                    }
                    

                }

                count++;

                if (input == ans)                                               //中獎或者沒有數字能猜了
                {
                    Console.WriteLine($"答對了 猜了{count}次");
                }
                if (ans == min2 || ans == max2)
                {
                    Console.WriteLine($"hen接近答案了 答案是{ans} 結　束　");   //接近答案也會結束
                    break;
                }



                else if (min < input && input < max) //沒中獎 可能不是來亂der
                {

                    if (input > ans)
                    {
                        Console.WriteLine($"答錯了 請輸入 {min2}到{input-1}");
                        max = input;
                        max2 = input - 1;
                    }
                    else if (input < ans)
                    {

                        Console.WriteLine($"答錯了 請輸入 {input+1}到{max2}");
                        min = input;
                        min2 = input + 1;
                    }


                }
                else                           //來亂的走這　亂輸入數字會到這　
                {
                    err--;
                    Console.WriteLine($" 是 在 哈 囉 ?");

                    Console.WriteLine($" 請  輸  入 {min2} 到 {max2} 好 咩"); 

                    if (err == 0)              //你沒了
                    {
                        Console.WriteLine($" 哩來亂ㄟ喔 這局掰了");
;
                        break;
                    }
                }



                if (count % 5 == 0 && input != ans)                 //每5次詢問 且不是答案
                {
                    Console.WriteLine($"已經猜{count}次  繼續? (y/n): ");
                    string GO = Console.ReadLine();
                    if (GO.ToLower() != "y")
                    {
                        Console.WriteLine("..........");
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine($"請 輸 入 {min+1}到{max -1}");
                }
                //min = (ans - input > 0) ? input : min;
                //max = (ans - input < 0) ? input : max;
            }
        }


        //每次詢問有一喵喵沒人性 小改一下
        //防亂兩刀
        //1.不能出現神奇文字/不會因為輸入文字跳掉  
        //2.不能輸入比第二次值小/大的數字
        //2-EX:第一次50 o-u-t->50 -100 第2次輸入不能49

        static void Main(string[] args)
        {


            while (true)
            {

                Console.WriteLine($"-----------------猜數字-----------------");
                Console.WriteLine("\t");
                Console.WriteLine("開始遊戲? (Y/N): ");
                string play = Console.ReadLine();
                if (play?.ToLower() != "y")
                {
                    Console.WriteLine("ＯＫ掰!");
                    break;
                }
                Console.Clear();
                game();
            }
        }
    }

}

