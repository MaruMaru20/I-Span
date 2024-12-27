using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241227_keyword
{
    internal class Program
    {
        static void P1_partial()
        {
            MyMath jeff = new MyMath();
            jeff.x = 100;
            jeff.y = 200;
            int temp = jeff.Cool(100, 200);
            Console.WriteLine(temp);

            int temp2 = jeff.Cool("1000", "2000");
            Console.WriteLine(temp2);
        }

        static void P2_property()
        {
            Member m1 = new Member();
            m1.MemberName = "NMMM";
            m1.MemberAge = 999;
            m1.QueryMember();
            //Member m2 = new Member("jeff");
            m1.Login();

            m1.Shopping();
        }

        static void P3_列舉()
        {

            //列舉:enum
            //USER
            //ENGINEER
            DateTime aaaa = DateTime.Now;

            DayOfWeek bbbb = aaaa.DayOfWeek;

            switch (aaaa.DayOfWeek)
            {   
                case DayOfWeek.Sunday:
                    Console.WriteLine("777");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("111");
                    
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("222");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("333");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("444");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("555");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("666");
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            //P1_partial();
            //P2_property();
            P3_列舉();

        }
    }
}
