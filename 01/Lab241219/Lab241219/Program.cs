using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241219
{
    internal class Program
    {
        static void P1_counting()
        {
            int a = 10;
            int b = 5;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;

            Console.WriteLine(d);
            Console.WriteLine(e);
        }

        static void P2_float()
        {
            Console.WriteLine("1");
            float x = 1.23f;
            double y = 1.23;
            decimal z = 1.23m;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.Clear();

            float f1 = 1.0f;
            float f2 = 6.0f;
            float f3 = f1 / f2;
            Console.WriteLine(f3);

            double d1 = 1.0;
            double d2 = 6.0;
            double d3 = d1 / d2;
            Console.WriteLine(d3);

            decimal c1 = 1.0m;
            decimal c2 = 6.0m;
            decimal c3 = c1 / c2;
            Console.WriteLine(c3);

        }

        static void P3_stringformat()
        {
            double x = 123.123;

            //C 貨幣
            Console.WriteLine(x.ToString("c0"));
            Console.WriteLine(x.ToString("c2")); //C:貨幣/2:後幾位
            Console.WriteLine("Total cost:{0:c99}", x);


            //N 貨幣逗點
            int y = 1000000000;
            Console.WriteLine(y.ToString("N0"));

            //F 小數點控制

            double z = 0.123456;
            Console.WriteLine(z.ToString("F"));
            Console.WriteLine(z.ToString("F99"));

        }

        static void P4_stringmethod()
        {
            string X = "   Jeff Shark  ";
            Console.WriteLine("max length: " + X.Length);
            Console.WriteLine(X);
            //--------------------------////去空格字數查詢
            Console.WriteLine(X.Trim());
            Console.WriteLine("max length: " + X.Length);
            //faild?
            //1.
            X = X.Trim();
            Console.WriteLine(X.Length);
            //2.
            Console.WriteLine(X.Trim().Length);
            //--------------------------//

            Console.WriteLine(X.ToUpper());
            Console.WriteLine(X.ToLower());
            Console.WriteLine(X.IndexOf("j"));
            Console.Clear();

            //指定開始起點
            Console.WriteLine(X);
            Console.WriteLine(X.Substring(5, 5));

            Console.Clear();

            // 補足指定長度 EX:帳戶,日期 預設空格(左)
            Console.WriteLine(X.PadLeft(50, '0'));





        }

        static void P5_sp_sympl()
        {
            string a = "";
            string b = null;
            string c = string.Empty;

            Console.WriteLine(a == b); // "" != null
            Console.WriteLine(b == c); // null != string.emtpy
            Console.WriteLine(a == c); // "" = string.emtpy

            // 特殊符號 跳脫字元 \
            string xa = "E:\\I-Span";
            string xb = @"E:\I-Span\123";
            Console.WriteLine(xa);
            Console.WriteLine(xb);

            //ex if字串放入變數又有跳脫字元(有順序)
            string shark = "Jeff Shark";
            string temp = $@"  {shark} is so \cool\";
            Console.WriteLine(temp);
        }

        static void P6_consoleRead()
        {
            Console.WriteLine("input value :");


            string xa = Console.ReadLine();
            Console.WriteLine("input: " + xa);

            //中文處理變數字，數字也會加工處理
            int xb = Console.Read();
            Console.WriteLine("input : " + xb);

        }

        static void P7_KG()
        {
            Console.Write("Please input (kg): ");
            string x = Console.ReadLine();

            double way1 = Convert.ToDouble(x) * 0.6;

            double temp = Convert.ToDouble(x);
            double way2 = temp * 0.6;

            Console.WriteLine($"input {x} switch to {way1} tkg");
            Console.WriteLine($"input {x} switch to {way2} tkg");



        }

        static void P8_IF()
        {
            //判斷 > bool
            //C# 只能輸入(判斷式/bool)
            bool x = false;
            if (x)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }

        static void P9_compare()

        {
            Console.Write("input value1: ");
            string x = Console.ReadLine();

            Console.Write("input value2: ");
            string y = Console.ReadLine();
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);


            if (a > b)
            {
                Console.WriteLine($"{x}>{y} = TRUE");
                Console.WriteLine($"{x}<{y} = FALSE");
            }
            else
            {
                Console.WriteLine($"{x}>{y} = FALSE");
                Console.WriteLine($"{x}<{y} = TRUE");
            }



            //--------------Teacher#1--------------//

            //int a100 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("input value1: ");
            //string a1 = Console.ReadLine();
            //int a2 = Convert.ToInt32(a1);

            //Console.Write("input value1: ");
            //string b1 = Console.ReadLine();
            //int b2 = Convert.ToInt32(b1);

            //Console.WriteLine($"{a1}>{b1}={a2 > b2}"); ;
            //Console.WriteLine($"{a1}<{b1}={a2 < b2}");






        }

        static void P10_compare2()
        {



            Console.Write("input value1: ");
            string x = Console.ReadLine();

            Console.Write("input value2: ");
            string y = Console.ReadLine();

            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);

            //#2
            bool c = a % b == 0;
            bool d = b % a == 0;
            //c | d
            //b % a == 0 || b % a == 0


            if (c | d)
            {

                Console.WriteLine($"{x} are {y} double");
                //}
                //else if (b % a == 0)
                //{
                //    Console.WriteLine($"{x} are {y} double");
            }
            else
            {
                Console.WriteLine($"{x} are not {y} double");
            }







        }

        static void P11_ternaryOP()
        {
            //IF
            string food = string.Empty;
            int weather = 11;

            if (weather < 15)
            {
                food = "Hot Pot";
            }
            else
            {
                food = "KFC";
            }
            Console.WriteLine(food);

            string food2 = (weather < 15) ? "Hot Pot" : "KFC";
            Console.WriteLine(food2);
            Console.WriteLine($"I want to eat {((weather < 15) ? "Hot Pot" : "KFC")} tonight");
        }


        static void P12_discount() 
        {
            //10杯飲料95折 20杯9折
            //100盃也可以
            //飲料均一價

            //show:
            //num=10
            //Pri=10
            //discount 5% totalPrice = $

            //Console.Write("input total : ");
            //string num = Console.ReadLine();

            //Console.Write("input Price : ");
            //string price = Console.ReadLine();
            //double a = Convert.ToDouble(num);
            //double b = Convert.ToDouble(price);

            //if (a >= 10) {
            //    Console.WriteLine(

            Console.Write("請輸入數量 : ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("請輸入單價 : ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"折扣{(amount >= 100 ? 9 : 95)}折，總金額為 : {price * amount * (amount >= 100 ? 0.9 : 0.95)} 元");



        }



        static void Main(string[] args)
        {
            //P1_counting();
            //P2_float();
            //P3_stringformat();
            //P4_stringmethod();
            //P5_sp_sympl();
            //P6_consoleRead();
            //P7_KG();
            //P8_IF();
            //P9_compare();
            //P10_compare2();
            //P11_ternaryOP();
            P12_discount();
        }
    }
}
