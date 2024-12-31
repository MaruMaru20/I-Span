using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241218
{
    internal class Program
    {
        static void P1_Console()
        {
            Console.WriteLine("AE");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ResetColor();

            Console.Write(true);
            Console.Write("0");

            Console.Clear();
        }

        static void P2_String()
        {
            Console.WriteLine("Hi,Bye");
            string xa = "Jeff shark";
            Console.WriteLine("I love" + xa);
            Console.WriteLine($"sure {xa} is great we love {xa}");
            // format
            Console.WriteLine("we love {0},{1}", xa, "  l~o~v~e");
        }

        static void P3_declare()
        {
            string xa = "jeff shark";
            String xb = "JEFF shark";
            System.String xc = "JEFF SHARK";


            Console.WriteLine(xa);
            Console.WriteLine(xb);
            Console.WriteLine(xc);

            Console.WriteLine(xa.GetType());
            Console.WriteLine(xb.GetType());
            Console.WriteLine(xc.GetType());
        }

        static void P4_int() 
        {
            int xa = 123;
            Console.WriteLine(xa);

            System.Int16 xb = 2345;
            Console.WriteLine(xb);
            
            Console.Clear();

            int max = int.MaxValue;
            int mini = int.MinValue;

            Console.WriteLine($"int between {mini} to {max}");

            int hugee = max + 1;
            int huge = max + 1 + max;
            Console.WriteLine(hugee);

        }

        static void P5_count()
        {
            float x = 10;
            float y = 3;
            Console.WriteLine($"{x}/{y} is? {x/y}");

        }


        static void Main(string[] args)
        {
            //P1_Console();
            //P2_String();
            //P3_declare();
            //P4_int();
            P5_count();




        }
    }
}
