using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241230_inheritance
{
    internal class Program
    {
        static void P1()
        {
            //class複習

            //Q1 設定顏色
            iPhone plus15 = new iPhone();
            Console.WriteLine($"Color: {plus15.PhoneColor}");
            Console.WriteLine($"Space: {plus15.PhoneSpace}");
            plus15.HeySiri();
            //Q2 有指定
            iPhone urphone = new iPhone("green", "64GB");
            Console.WriteLine($"Color: {urphone.PhoneColor}");
            Console.WriteLine($"Space: {urphone.PhoneSpace}");
            urphone.Call();


            //inheritance
            iPhone16  neww = new iPhone16 ();
            Console.WriteLine($"Color: {neww.PhoneColor}");
            Console.WriteLine($"Space: {neww.PhoneSpace}");
            neww.Call();

        }

        static void P2()
        {
            Console.WriteLine("iPhone17");
            {
                iPhone17 x = new iPhone17();
                iPhone17 y = new iPhone17("Taipei" , "101");
                Console.Clear();
                iPhone17 z = new iPhone17("Taipei" , "101","pink","16GB");
                Console.WriteLine($"Color: {z.PhoneColor}");
                Console.WriteLine($"Space: {z.PhoneSpace}");
                z.HeySiri();
                z.Call();
            }
        }

        static void P3()
        {
            DateTime time = DateTime.Now;
            DayOfWeek Date = time.DayOfWeek;
            Console.WriteLine(Date);
            Console.WriteLine(Convert.ToInt32(DayOfWeek.Monday));
            Console.WriteLine((int)DayOfWeek.Monday);
            Console.WriteLine((DayOfWeek)1); //monday

            switch (Date)  
            {
                case DayOfWeek.Sunday:
                    
                    break;
                case DayOfWeek.Monday:
                    Console.Write("上課..    ");
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }

            int week = (int)DayOfWeek.Monday;
            switch (week)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("噢 NO!");
                    break;
                case 5:
                    Console.WriteLine("YaY");
                    break;
                case 6:
                case 0:
                    Console.WriteLine("tomorrow nono");
                    break;
                default:
                    break;
            }
        }

        static void P4()
        {
            List<string> list = new List<string>();
            list.Add("鯊魚");
            list.Add("大鯊魚");
            list.Add("超級大鯊魚");
            list.Add("超級無敵大鯊魚");
            list.Add("超級無敵傑夫鯊鯊");

            string x = list[2];
            Console.WriteLine(x);
            Console.Clear();


            //for_enum sk = new for_enum();
            //sk.shark


            string y = list[(int)for_enum.shark.鯊魚 ];
            Console.WriteLine(y);

            int een = (int)neenum.a;
            Console.WriteLine(een);
        }

        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            P4();
        }
    }
}
