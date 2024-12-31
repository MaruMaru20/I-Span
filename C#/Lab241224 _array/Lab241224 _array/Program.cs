using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241224__array
{
    internal class Program
    {
        static void P1_sales()
        {

            string[] where = { "台北", "台中", "高雄" };
            string[] depart = { "點心部", "飲料部", "小吃部", "文具部" };
            int[,] cost = {
            { 1100, 2200, 3300, 0 },
            { 2200, 4400, 0,    0 },
            { 1000, 2000, 3000, 4000 }
        };


            string add = " ".PadRight(6);
            Console.WriteLine($"{"",14}{depart[0]}\t{depart[1]}{add}{depart[2]}{add}{depart[3]}");
            Console.WriteLine(new string('-', +60));
            for (int d = 0; d < where.Length; d++) //3
            {
                Console.Write($"{where[d],-8}");
                for (int c = 0; c < depart.Length; c++) //4
                {
                    if (cost[d, c] != 0)
                        Console.Write($"{cost[d, c].ToString("C0"),12}");
                    else
                        Console.Write($"{"",12}");  //  \t

                }
                Console.WriteLine();

            }

            Console.WriteLine(new string('-', +60));


            for (int i = 0; i < where.Length; i++)
            {
                int total = 0;
                for (int j = 0; j < depart.Length; j++)
                {
                    total += cost[i, j];
                }
                Console.WriteLine($"{where[i]}{"",9} 總金額 : {total:C0}");
            }
        }

        //teacher--
        static void P1_departmentsale()
        {
            string[] area = { "台北", "台中", "高雄" };
            string[] department = { "點心部", "飲料部", "小吃部", "文具部" };

            int[][] cost = new int[area.Length][];
            cost[0] = new int[3];
            cost[0][0] = 1100;
            cost[0][1] = 2200;
            cost[0][2] = 3300;

            cost[1] = new int[2];
            cost[1][0] = 2200;
            cost[1][1] = 4400;

            cost[2] = new int[4];
            cost[2][0] = 1000;
            cost[2][1] = 2000;
            cost[2][2] = 3000;
            cost[2][3] = 4000;

            int[] total =new int[area.Length];

            //規劃完畢 D=Department C=cost
            Console.WriteLine("\t" + string.Join("\t", department));

            Console.WriteLine(new string('-', +60));

            for (int a = 0; a < area.Length; a++)
            {
                Console.Write(area[a] + "\t");


                for (int c = 0; c < cost[a].Length; c++)
                {
                    Console.Write(cost[a][c] + "\t");

                    total[a] += cost[a][c];
                }
                Console.Write("\n");
            }
            Console.WriteLine(new string('-', +60));

            for (int a = 0; a < area.Length; a++)
            {
                Console.WriteLine($"{area[a]}\t總金額:{total[a]}");
            }
        }

        static void P1_BOSS()
        {
            Console.WriteLine("P1");

            string[,] store = new string[4, 5];

            store[0, 0] = "";

            store[0, 1] = "點心部";

            store[0, 2] = "飲料部";

            store[0, 3] = "小吃部";

            store[0, 4] = "文具部";

            store[1, 0] = "台北";

            store[1, 1] = "1100";

            store[1, 2] = "2200";

            store[1, 3] = "3300";

            store[1, 4] = "0";

            store[2, 0] = "台中";

            store[2, 1] = "2200";

            store[2, 2] = "4400";

            store[2, 3] = "0";

            store[2, 4] = "0";

            store[3, 0] = "高雄";

            store[3, 1] = "1000";

            store[3, 2] = "2000";

            store[3, 3] = "3000";

            store[3, 4] = "4000";

            int[] sum = new int[4];

            for (int i = 0; i < store.GetLength(1); i++)

            {

                Console.Write($"{store[0, i]}\t");

            }

            Console.WriteLine("\n");

            Console.WriteLine("---------------------------------------------");

            for (int i = 1; i < store.GetLength(0); i++)

            {

                int temp = 0;

                for (int j = 1; j < store.GetLength(1); j++)

                {

                    temp += Convert.ToInt32(store[i, j]);

                    //Console.WriteLine(temp);

                }

                sum[i] += temp;

            }

            for (int i = 1; i < store.GetLength(0); i++)

            {

                for (int j = 0; j < store.GetLength(1); j++)

                {

                    if (store[i, j] == "0")

                    {

                        store[i, j] = string.Empty;

                    }

                    Console.Write($"{store[i, j]}\t");

                }

                Console.WriteLine("\n");

            }

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine($"{store[1, 0]} 總金額 : {sum[1]:C0}");

            Console.WriteLine($"{store[2, 0]} 總金額 : {sum[2]:C0}");

            Console.WriteLine($"{store[3, 0]} 總金額 : {sum[3]:C0}");

        }

        static void P2_Address_or_Value()
        {
            string[] ani = { "shark" ,"Jeff"};
            string[] an2 = ani; //an2 get address(references) from ani not value

            Console.WriteLine(string.Join(",",ani));
            Console.WriteLine(string.Join(",",an2));
            Console.WriteLine(new string('-', +60));
            an2[0] = "wolf";
            Console.WriteLine(string.Join(",", ani));
            Console.WriteLine(string.Join(",", an2));
        }

        static void P3_ArrayList()
        {   //setting
            ArrayList biubiu = new ArrayList();
            biubiu.Add(5566);
            biubiu.Add("XMS");
            biubiu.Add(true);


            //get
            Console.WriteLine(biubiu.Count);
            Console.WriteLine(biubiu.Capacity);
            Console.WriteLine(biubiu[1]);

            Console.Clear();


            //update
            Console.WriteLine(biubiu[1]);
            biubiu[1] = "XMS eat turkey";
            Console.WriteLine(biubiu[1]);

            // wanna Join? ToArray() then
            string temp = string.Join(",", biubiu.ToArray());
            Console.WriteLine(temp);

            Console.Clear();

            foreach (var item in biubiu)
            {
                Console.WriteLine(item);
            }

            //一維陣列 型態單一 初始設定要詳細
            //陣列清單 型態多元 免
        }

        static void P4_List()
        {
            //() call
            List<string> pewpew = new List<string>();
            pewpew.Add("one");
            pewpew.Add("oneone");
            pewpew.Add("oneoneone");

            Console.WriteLine(pewpew[0]);
            Console.WriteLine(pewpew[1]);
            Console.WriteLine(pewpew[2]);
            Console.WriteLine(new string("-",+10));
            //remove
            pewpew.Remove("one");
            Console.WriteLine(pewpew[0]);
            Console.WriteLine(pewpew[1]);


        }
        static void Main(string[] args)
        {
                //P1_sales();
                //P1_BOSS();
                //P1_departmentsale();
                //P2_Address_or_Value();
                //P3_ArrayList();
                P4_List();

        }
    }
}
