using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_241225_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0; 
            int min = 1; 
            int max = 100;
            Random rnd = new Random(); // 隨機數生成器
            int rand = rnd.Next(min, max + 1); // 生成隨機數
            int count = 0; // 猜測次數計數
            bool isGuessed = false; // 控制遊戲循環的布林變數

            // 顯示遊戲開始訊息
            Console.WriteLine($"答案為:{rand}");
            Console.WriteLine($"遊戲開始，請輸入 {min}~{max} 之間的數值");
            Console.WriteLine("---------------------------------------");

            // 判斷是否繼續遊戲
            while (!isGuessed)
            {
                Console.Write("請輸入數值: ");
                string userInput = Console.ReadLine();

                // 嘗試將輸入轉換為整數，若失敗則提示重新輸入
                if (!int.TryParse(userInput, out input))
                {
                    Console.WriteLine("無效的輸入，請輸入一個整數。\n");
                    continue;
                }

                count++; // 增加猜測次數

                // 輸入驗證：若輸入超出範圍，提示並要求重新輸入
                if (input > max)
                {
                    Console.WriteLine($"輸入太大，請輸入 {min} 到 {max} 之間的數字。\n");
                    continue;
                }

                if (input < min)
                {
                    Console.WriteLine($"輸入太小，請輸入 {min} 到 {max} 之間的數字。\n");
                    continue;
                }

                // 比較輸入與隨機數
                if (input > rand)
                {
                    Console.WriteLine($"介於 {min} 和 {input} 之間。\n");
                    max = input; // 更新最大範圍
                }
                else if (input < rand)
                {
                    Console.WriteLine($"介於 {input} 和 {max} 之間。\n");
                    min = input; // 更新最小範圍
                }
                else
                {
                    // 猜對了
                    Console.WriteLine($"恭喜答對！答案為 {input}，你總共猜了 {count} 次。");
                    isGuessed = true; // 結束循環
                }
            }
        }
    }
}

