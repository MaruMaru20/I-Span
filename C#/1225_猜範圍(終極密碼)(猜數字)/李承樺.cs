using System;

namespace Lab241225_Game
{
    internal class Program
    {
        static void P1_Game()
        {
            int count = 0; 
            int min = 1;
            int max = 100;
            int limit = 10; 
            Random random = new Random();
            int answer = random.Next(min, max + 1); // 隨機產生答案
            bool gameOver = false;
            Console.WriteLine($"答案為:{answer}");
            Console.WriteLine("遊戲開始，請輸入1~100之間的數值");
            while (!gameOver)
            {
                Console.WriteLine($"目前範圍是 {min} 到 {max} 之間");
                Console.Write("請輸入數值: ");

                string input = Console.ReadLine();
                if (count == limit ) // 最多猜測次數限制
                {
                    Console.WriteLine("抱歉，你已經猜了 10 次，遊戲結束！");
                    Console.WriteLine($"正確答案是 {answer}！");
                    break;
                    gameOver = true;
                   
                }
                if (int.TryParse(input, out int userGuess)) // 驗證輸入是否為數字
                
                {
                    count++;
                    if (userGuess < min )
                    {
                        Console.WriteLine($"輸入太小，請輸入介於 {min} 和 {max} 之間的數值！");
                        Console.WriteLine($"猜測次數{count}");
                        continue;
                    } else if ( userGuess > max) {
                        Console.WriteLine($"輸入太大，請輸入介於 {min} 和 {max} 之間的數值！");
                        Console.WriteLine($"猜測次數{count}");
                        continue;
                    }

                    if (userGuess == answer)
                    {
                        Console.WriteLine($"恭喜答對！答案是 {answer}，你共猜了 {count} 次。");

                        gameOver = true;
                    }
                    else if (userGuess > answer)
                    {
                        Console.WriteLine($"太大了 ！");
                        Console.WriteLine($"猜測次數{count}");

                        max = userGuess - 1; // 更新最大值
                    }
                    else
                    {
                        Console.WriteLine($"太小了！");
                        Console.WriteLine($"猜測次數{count}");

                        min = userGuess + 1; // 更新最小值
                    }


                    
                }
                else
                {
                    count++;
                    Console.WriteLine("無效輸入，請輸入一個有效的數字！");
                    Console.WriteLine($"猜測次數{count}");

                }
            }

            Console.WriteLine("是否要重新開始遊戲？(Y/N)");

            string restart = Console.ReadLine();
            if (restart?.ToUpper() == "Y")
            {
                Console.Clear();
                P1_Game(); // 重新開始遊戲
            }
            else
            {
                Console.WriteLine("遊戲結束，感謝遊玩！");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            P1_Game();
        }
    }
}