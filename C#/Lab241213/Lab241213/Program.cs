using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241213
{
    internal class Program
    {


        static void P5_arrayrev()
        {
            int[] ar = new int[10];
            for (int k = 0; k < ar.Length; k++)
            {
                ar[k] = k + 1;
                Console.WriteLine($" 陣列內容: ar [{k}] = {ar[k]}");
            }
            Console.WriteLine("=======陣列反轉======");

            Array.Reverse(ar);
            Console.WriteLine(string.Join("\n", ar));
        }


        static void P7_tempture()
        {

            //Console.WriteLine("P7 平均溫度");
            //int[] tempture = { 26, 28, 29, 31, 35, 34, 36, 37, 36, 32, 28, 18 };
            //int tmp = 0;
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.Write($"    {(i + 1).ToString("D2")} 月");
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine(" ----------------------------------------------------------------------------------------");
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.Write($"    {tempture[i]} 度");
            //    tmp += tempture[i];
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine($"平均溫度 : {tmp / 12}");


            //------------------------------------------------------//teacher.
            int[] tempture = { 26, 28, 29, 31, 35, 34, 36, 37, 36, 32, 28, 18 };
            for (int k = 1; k < tempture.Length + 1; k++)
            {
                Console.Write($"{k.ToString().PadLeft(2, '0')}月\t");
            }
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            int total = 0;
            for (int k = 0; k < tempture.Length; k++)
            {
                total += tempture[k];
                Console.Write($"{tempture[k]}度\t");

            }
            //double avg = Convert.ToDouble(total) / tempture.Length;
            double avg = total * 1.0 / tempture.Length;
            Console.WriteLine($"\n \n AVG: {avg:F2}");
        }

        static void P8_TwoDimArray()
        {
            string[] xx = new string[1];

            //TwoDim
            string[,] xx2 = new string[2, 5];
            xx2[1, 0] = "Jeff";
            xx2[1, 1] = "Jeff2";
            xx2[1, 2] = "Jeff3";
            xx2[1, 3] = "Jeff4";
            xx2[1, 4] = "Jeff5";

            xx2[0, 0] = "Shark";
            xx2[0, 1] = "Shark2";
            xx2[0, 2] = "Shark3";
            xx2[0, 3] = "Shark4";
            xx2[0, 4] = "Shark5";
            Console.WriteLine($"{xx2[1, 4]}");


            //#2
            string[,] xx3 = {
                { "Jeff", "Jeff2", "Jeff3" },
                { "shark", "shark2", "shark3" } };
            Console.WriteLine(xx3[0, 2]);
            Console.WriteLine(xx3[1, 1]);
            Console.Clear();

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine(xx3[row, col]);
                }

            }

            //get
            foreach (var item in xx3)
            {
                Console.Write($"{item}  ");
            }
            //faild to get value
            //string temp = string.Join("#", xx3);
        }

        static void P9_ArrayMethod()
        {
            int[,,] xx = new int[2, 5, 9];

            Console.WriteLine(xx.Length);      //Total number    Ex:90
            Console.WriteLine(xx.Rank);        //Dim number      Ex:3
            Console.WriteLine(xx.GetLength(0));//Get Dim setting Ex:2 5 9
        }


        static void P10_JaggedArray()  //Jagged 不規則
        {
            string[][] house =  new string[3][];
            house[2] = new string[3];
            house[2][0] = "x";
            house[2][1] = "y";
            house[2][2] = "z";

            house[1] = new string[3];
            house[1][0] = "A";
            house[1][1] = "B";
            house[1][2] = "C";

            house[0] = new string[4];
            house[0][0] = "1";
            house[0][1] = "2";
            house[0][2] = "3";
            house[0][3] = "4";

            for (int c = 0; c < house.Length; c++)
            {
                for (int s = 0; s < house[c].Length; s++)
                {
                    Console.Write("  "+house[c][s]);
                }
            }

            Console.WriteLine("\n----------------------------");

            foreach (string[] item in house)
            {
                Console.WriteLine(string.Join(",", item));
            }





        }


        static void Main(string[] args)
        {

            //P5_arrayrev();
            //P7_tempture();
            //P8_TwoDimArray();
            //P9_ArrayMethod();
            P10_JaggedArray();
        }
    }
}
