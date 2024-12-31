using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Game()
        {
            var rand = new Random();
            int min = 1, max = 100;
            int Ans = rand.Next(min, max + 1);
            int count = 0;  // 記數
            int x = 0;  // 輸入
            //int condition;
            Console.WriteLine($"答案為:{Ans}");
            string output = $"遊戲開始，請輸入 {min} ~ {max} 之間的數值";
            Console.WriteLine(output);
            Console.WriteLine("---------------------------------------");

            do
            {
                Console.Write("請輸入數值:");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    count++;
                    //condition = (x == Ans) ? 0 :
                    //    (x < min || x > max) ? 1 :
                    //    (x < Ans) ? 2 :
                    //    (x > Ans) ? 3 : 4;
                    switch (true)       // case bool _ when  7.0以上使用
                    {
                        case bool _ when x == Ans:  // 程式碼觸發必須上而下
                            output = $"答案為{Ans},總共猜{count}次";
                            break;
                        case bool _ when x < min:
                            output = $"輸入太小，請輸入在介於{min}和{max}之間";
                            break;
                        case bool _ when x > max:
                            output = $"輸入太大，請輸入在介於{min}和{max}之間";
                            break;
                        case bool _ when x < Ans:
                            min = x;
                            output = $"介於{min}和{max}之間";
                            break;
                        case bool _ when x > Ans:
                            max = x;
                            output = $"介於{min}和{max}之間";
                            break;
                        default:
                            output = "判別邏輯有錯";
                            break;
                    }
                    //switch (condition)
                    //{
                    //    case 0:
                    //        output = $"答案為{Ans},總共猜{count}次";
                    //        break;
                    //    case 1:
                    //        output = $"請輸入在介於{min}和{max}之間的整數!";
                    //        break;
                    //    case 2:
                    //        min = x;
                    //        output = $"介於{min}和{max}之間";
                    //        break;
                    //    case 3:
                    //        max = x;
                    //        output = $"介於{min}和{max}之間";
                    //        break;
                    //    default:
                    //        output = "判別邏輯有錯";
                    //        break;
                    //}
                }
                catch (FormatException)  // 輸入的不是整數
                {
                    output = $"請輸入在介於{min}和{max}之間的整數!";
                }
                catch (OverflowException)  // 超出 int32 範圍
                {
                    output = "輸入的數字超出範圍，請介於 -2147483648 到 2147483647 之間!";
                }
                catch (Exception ex)
                {
                    output = $"發生未知錯誤: {ex.Message}";
                }
                Console.WriteLine(output);
            } while (x != Ans);
        }

        static void Main(string[] args)
        {
            string x = "Y";
            while (x == "Y")
            {
                x = "N";
                Game();
                Console.WriteLine("是否要繼續遊戲? (Y/N)");
                x = Console.ReadLine().ToUpper();
            }
        }
    }
}
