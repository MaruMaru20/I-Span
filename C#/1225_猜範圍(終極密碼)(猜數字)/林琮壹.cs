using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20241225_Game2
{
    internal class Program
    {
        static void P1_game()
        {
            int target;
            int min;
            int max;
            Random rnd = new Random();
            void display() // 建立要顯示的畫面函式
            {
                Console.WriteLine("====猜數字====");
                min = 1;
                max = 100;
                target = rnd.Next(min, max + 1); // 產生1~100的隨機整數
                Console.WriteLine($"答案為：{target}");
                Console.WriteLine("遊戲開始，請輸入 1 ~ 100 之間的數值");
                Console.WriteLine("-------------------------------------------");
            }
            display(); //呼叫要顯示的畫面函式
            Console.WriteLine("\n");
            Console.Write("請輸入數值：");
            int input; // 宣告輸入型態為整數
            bool numberOrNot = int.TryParse(Console.ReadLine(), out input); // 用TryParse接整數輸入
            int count = 0; // 計算輸入了幾次
            void game() // 建立下一步比大小函式
            {
                count += 1;
                Console.WriteLine("\n");
                Console.Write("請輸入數值：");  
                numberOrNot = int.TryParse(Console.ReadLine(), out input); // 用TryParse接整數輸入
            }
            void checkInput() // 建立檢查輸入格式正確與否函式
            {
                while (numberOrNot == false)
                {
                    Console.WriteLine("請輸入正確數值 !!!");
                    game();
                    count = 0;
                }
            }
            checkInput(); // 呼叫檢查輸入格式正確與否函式
            void game2() // 建立比大小函示
            {
                while (input != target) // 判斷當輸入不等於答案
                {
                    if (input > target && input < max)
                    {
                        Console.WriteLine($"介於{min}和{input}之間");
                        max = input;
                        game(); // 呼叫下一步比大小函式
                    }
                    else if (input < target && input > min)
                    {
                        Console.WriteLine($"介於{input}和{max}之間");
                        min = input;
                        game(); // 呼叫下一步比大小函式
                    }
                    else if (input > max)
                    {
                        Console.WriteLine($"輸入太大，請介於{min}和{max}之間");
                        game(); // 呼叫下一步比大小函式
                    }
                    else if (input < min)
                    {
                        Console.WriteLine($"輸入太小，請介於{min}和{max}之間");
                        game(); // 呼叫下一步比大小函式
                    }
                    else if (input == target) // 當輸出等於答案
                    {
                        break; // 跳脫迴圈
                    }
                }
            }
            game2(); // 呼叫比大小函式
            while (input == target) // 判斷要不要再玩
            {
                count += 1;
                Console.WriteLine($"答對{target}，恭喜答對 (猜了 {count}) 次");
                Console.WriteLine("\n");
                Console.WriteLine($"是否要繼續遊戲? (Y/N)");
                string again = (Console.ReadLine()).ToUpper(); // 輸入字母轉大寫
                if (again == "Y") // 重玩
                {
                    Console.Clear();        // 清空主控台畫面
                    display();                 // 呼叫要顯示的畫面函式
                    game();                   // 呼叫下一步比大小函式
                    checkInput();           // 呼叫檢查輸入格式正確與否函式
                    count = 0;               // 重置記次
                    game2();                 // 呼叫比大小函式
                }
                else if (again == "N")   // 不玩
                {
                    break; // 結束迴圈
                }
            }

        }
        static void Main(string[] args)
        {
            P1_game();
        }
    }
}
