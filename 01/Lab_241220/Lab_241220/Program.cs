using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_241220
{
    internal class Program
    {
        static void discount()
        {
            Console.Write("How many? ：");
            double quantity = double.Parse(Console.ReadLine());
            Console.Write("Each price ：");
            double price = double.Parse(Console.ReadLine());

            double total = quantity * price;
            double discount = quantity >= 110 ? 0.8 : (quantity >= 20 ? 0.9 : (quantity >= 10 ? 0.95 : 1));

            total *= discount;

            //想去0 去點     9.5折 90折<---看不爽
            string gogo = (discount * 100).ToString(); //要tostring才能動
            gogo = gogo.TrimEnd('0').TrimEnd('.'); //先想到TRIM 失敗

            //早上 ++
            if (quantity < 10)
            {
                gogo = (discount * 0).ToString();
            }


            double per = (1 - discount) * 100;

            Console.WriteLine($"{gogo}折 總價：{total:F2}");
            Console.WriteLine($"{per}%off  total price is：{total:F2}");
            // any other way?  01. 4捨   02. 無折


            //-------------------------------------------------//
        }

        static void P2_discount2()
        {
            Console.Write("How many? ：");
            double quantity = double.Parse(Console.ReadLine());
            Console.Write("Each price ：");
            double price = double.Parse(Console.ReadLine());

            double total = 0;
            string discount = "None";
            if (quantity >= 20)
            {
                total = quantity * price * 0.9;
                discount = "9";
            }
            else if (quantity >= 10)

            {
                total = quantity * price * 0.95;
                discount = "95";
            }
            Console.WriteLine($"Dis {discount} ,total{total}");
        }

        static void P3_shopping()
        {
            Console.Write("How many cloth? ：");
            double quantity = double.Parse(Console.ReadLine());

            double price = 399;
            double target = 1500;
            double dis = 0.79;
            double total = quantity * price;
            double goal = target - total;

            double discount = total * dis;

            if (total < target)
            {
                Console.WriteLine($"total price :{total:c0} less{target:c0} need{goal:c0}");
            }
            else

                Console.WriteLine($"total price :{total:c0} over{target:c0} need{discount:c0}");
        }

        static void P4_switch_case()
        {
            Console.Write("input value1: ");
            string xa = Console.ReadLine();
            double a = Convert.ToInt32(xa);


            Console.WriteLine("P5");

            string xb = "";
            switch (a)
            {
                case 0:
                    xb = "10";
                    break;
                case 1:
                    xb = "20";
                    break;
                default:
                    xb = "infinty";
                    break;

            }
            Console.WriteLine(xb);
        }

        static void P5_bouns()
        {
            Console.Write("how long? : ");
            string xa = Console.ReadLine();
            double a = Convert.ToDouble(xa);
            Console.Write("payment? : ");
            string xb = Console.ReadLine();
            double b = Convert.ToDouble(xb);

            Console.WriteLine($"exm: {a} year , salary {b:C0}");
            int less_year = 3;
            int year = 6;

            switch (a)
            {
                case 3:
                    Console.WriteLine($"{a} less {year} bouns are {a * b:c0}");
                    break;
                case 6:
                    Console.WriteLine($"is reach to {year} bouns are {b * year:c0}");
                    break;
                default:
                    Console.WriteLine($"oops {less_year} year req  bouns:NONE");
                    break;
            }


        }
        static void P6_bouns_if()
        {
            Console.Write("how long? : ");
            string xa = Console.ReadLine();
            double a = Convert.ToDouble(xa);
            Console.Write("payment? : ");
            string xb = Console.ReadLine();
            double b = Convert.ToDouble(xb);

            Console.WriteLine($"exm: {a} year , salary {b:C0}");
            int[] bouns_year = { 0, 1, 2, 3, 4, 5, 6 };

            if (a >= bouns_year[3])
            {
                Console.WriteLine($"{a} less {bouns_year[6]} bouns are {bouns_year[3] * b:c0}");
            }
            else if (a >= bouns_year[6])
            {
                Console.WriteLine($"{a} are {bouns_year[6]} bouns are {bouns_year[6] * b:c0}");
            }
            else
            {

                Console.WriteLine($"oops {bouns_year[1]} year req  {bouns_year[0] * b:c0}");
            }

        }

        static void P7_for()
        {
            for (int k = 1; k < 26; k++)
            {
                if (k == 7)
                {
                    continue;
                }
                Console.WriteLine(k);
            }
            Console.Clear();
            //infinity
            for (; ; )
            {
                Console.WriteLine("100");
                break;
            }
        }

        //老大
        static void P8_isprime()

        {
            //int k = 0;
            //string a = "";
            //for (int i = 1; i <= 99; i += 2)
            //{
            //    k += i;
            //    a += " + " + i.ToString();
            //}
            //Console.WriteLine($"{a} = {k}");

            //--------------------------------

            //int k = 0;

            //string a = "";

            //for (int i = 1; i <= 99; i += 2)

            //{

            //    k += i;

            //    a += "+" + i.ToString();

            //}

            //Console.WriteLine($"{a.Remove(0, 1)} = {k}");
            //---------------------
            for (int i = 0; i < 100; i++)
            {

                if (i % 2 == 0)
                {
                    continue;
                }
                string r = $"{i} + ";
                //Console.Write(r.Substring("+");
            }
        }

        static void P9_while()
        {
            while (true)
            {
                Console.WriteLine("N");
                break;
            }
            int x = 5;
            while (x < 10)
            {
                Console.WriteLine(x);
                x += 1;
            }
            Console.Clear();
            int y = 5;
            do
            {
                Console.WriteLine("123");

                //; break;
            }
            while (y < 3);
        }

        static void P10_prtWhile()
        {
            //    int a = 10, b = 10, c = 10;
            //    while (c >= 0)
            //    {
            //        a = a + b;
            //        c = c - 1;
            //    }
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //    Console.WriteLine(c);
            //}
            //    int a = 10, b = 20, c;
            //    do
            //    {
            //        for ( c = 1; c <= 5; c++) // 0 to 5
            //        {
            //            a += c;  // a 25
            //        }
            //        b -= 1; // b 19
            //    } while (b <= 0);
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //    Console.WriteLine(c);
            //}

            int a = 10, b = 20, c;
            do
            {
                for (c = 1; c <= 5; c++) //C+1
                {
                    c = a + b;// 30
                    a -= 1; //9
                }
                b -= 1; //19
            } while (b < 0);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        // Z7
        static void P21_flower()
        {
            int total;
            int i = 100;
            while (i <= 999)
            {
                total = i;
                int num1 = i / 100; //9
                int num2 = (i / 10) % 10; //6
                int num3 = i % 10;//9
                if (total == (num1 * num1 * num1) + (num2 * num2 * num2) + (num3 * num3 * num3))
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        static void P11_prtWhile2()
        {
            

            int temp = 100;
            while (temp <1000) {
                //#1
                //int temp = 153;
                string xa = Convert.ToString(temp);
                int a = Convert.ToInt32(xa.Substring(0, 1));
                int b = Convert.ToInt32(xa.Substring(1, 1));
                int c = Convert.ToInt32(xa.Substring(2, 1));

                int total = (int)(Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3));
                if (temp == total) 
                {
                    Console.WriteLine(temp);
                }
                    //int tmp = 153;
                    //int a = tmp / 100;
                    //int b = 5;
                    //int c = tmp % 10;
                    //Console.WriteLine(a);
                    //Console.WriteLine(b);
                    //Console.WriteLine(c);
                    temp++;
            }
        }

        static void PX_boss()
        {
            int x = 100;

            string k = string.Empty;

            while (x <= 999)

            {

                int x1 = x / 100;

                int x2 = (x / 10) % 10;

                int x3 = x % 10;

                if (((x1 * x1 * x1) + (x2 * x2 * x2) + (x3 * x3 * x3)) == x)

                {

                    k += x.ToString() + "、";

                }

                x += 1;

            }

            Console.WriteLine($"在100~999之間符合條件的數值有 :{k.Substring(0, k.LastIndexOf("、"))}");

        }


        static void Main(string[] args)
        {
            //discount();
            //P2_discount2();
            //P3_shopping();
            //P4_switch_case();
            //P5_bouns();
            //P6_bouns_if();
            //P7_for();
            //P8_isprime();
            //P9_while();
            //P10_prtWhile();
            //P11_prtWhile2();
            //P21_flower();
            PX_boss();
        }
    }
}
