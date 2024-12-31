using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241225_List
{
    internal class Program
    {
        static void P1_List_review()
        {
            //<> 泛型
            //Predicate 委派
            List<int> ok = new List<int>();
            ok.Add(100);
            ok.Add(10);
            ok.Add(200);
            ok.Add(300);
            ok.Add(4100);
            ok.Add(11300);
            ok.Add(10);

            int result = ok.Count;

            Console.WriteLine(result);

            bool remov = ok.Remove(10);

            Console.WriteLine(remov);
            Console.WriteLine(string.Join(", ", ok));

            result = ok.Count;
            Console.WriteLine(result);

            ok.RemoveAt(5);
            Console.WriteLine(string.Join(", ", ok));

            ok.RemoveRange(0, 4);
            Console.WriteLine(string.Join(", ", ok));

            ok.RemoveAll(x => x > 0);
            Console.WriteLine(string.Join(", ", ok));

            result = ok.Count;
            Console.WriteLine(result);

        }

        static void P2_Dict()
        {
            Dictionary<int, bool> lk = new Dictionary<int, bool>();
            lk.Add(100, true);
            //lk.Add("1",true); refuse


            Dictionary<string, string> like = new Dictionary<string, string>();
            like.Add("J", "S");
            like.Add("Je", "Sh");
            like.Add("Jef", "Sha");
            like.Add("Jeff", "Shar");
            like.Add("Jeff ", "Shark");


            Console.WriteLine(string.Join(",", like));

            Console.WriteLine(like["Jeff "]);

            foreach (KeyValuePair<string, string> item in like)
            {
                Console.WriteLine(item);
            }

            foreach (var no2 in like.Values)
            {
                Console.WriteLine(no2);
            }
            //檢查先
            bool oo = like.ContainsKey("J");
            Console.WriteLine(oo);

            int countt = like.Count;
            Console.WriteLine(countt);

        }

        static void P3_Observe()
        {
            //可以用來4捨5
            double temp = 1.5;
            int xa = Convert.ToInt32(temp);
            Console.WriteLine(xa);
            //不能4捨5
            int xb = (int)temp;
            Console.WriteLine(xb);

            int xc = int.Parse("22");
            Console.WriteLine(xc);

            Console.Clear();

            //------------------------------------------
            //TryParse can only input int
            string s = "shark";
            int result;

            bool xd = int.TryParse(s, out result);

            Console.WriteLine(result);
            Console.WriteLine(xd);
            Console.WriteLine();
        }

        static int P4_first_function(int aa, int bb)
        {

            aa += bb;
            return aa;
        }

        static void P5_exmKey_in_out_ref()
        {
            //1.宣告 函式的 參數 
            //2.呼叫 函式的 資料

            //1
            int any(int aa, int bb)
            {
                //aa += bb;
                int tmp = aa + bb;
                aa = 1;
                bb = 2;

                return tmp;
            }   //value
            int aaa = 5;
            int bbb = 9;
            int x = any(aaa, bbb);
            Console.WriteLine(x);
            Console.WriteLine(aaa); //5
            Console.WriteLine(bbb); //9
            Console.Clear();
            //2
            int any_2(ref int aa, ref int bb)
            {
                int tmp = aa + bb;
                aa = 0;
                bb = 0;
                return tmp;
            }   //reference
            int aaa_2 = 5;
            int bbb_2 = 9;
            int x2 = any_2(ref aaa_2, ref bbb_2); 
            Console.WriteLine(x2);
            Console.WriteLine(aaa_2); //0
            Console.WriteLine(bbb_2); //0

            bool any_3( int aa,  int bb, out int cc)
            {
                cc = aa+bb;
                return true;
            }
            int aaa_3 = 5;
            int bbb_3 = 9;
            int ccc_3;
            bool ooxx = any_3(aaa_3,bbb_3,out ccc_3);

            Console.WriteLine(ccc_3);

            int any_4(in int aa, in int bb)
            {
                int tmp = aa + bb;
                //aa = 0;
                //bb = 0;
                return tmp;
            }
            int bbb_4 = 5;
            int aaa_4 = 9;
            int x4 = any_4(aaa_4, bbb_4);
            Console.WriteLine(x4);

            //ref -> 傳址 +可改
            //in  -> 傳址 +不可改
            //out -> 傳址 +可改 +脫離函式(return)前要設定


        }

        static void Main(string[] args)
        {
            //P1_List_review();
            //P2_Dict();
            //P3_Observe();
            //int x = P4_first_function(10,15);   Console.WriteLine(x);
            P5_exmKey_in_out_ref();
        }
    }
}
