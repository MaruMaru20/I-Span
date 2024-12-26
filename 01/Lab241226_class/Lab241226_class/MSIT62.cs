using System;

namespace Lab241226_class
{
    // 24 12 26屬性 未完
    internal class MSIT62
    {
        public int StudentID { get; }
        public string StudentName;
        public int Chinese;
        public int English;
        public int Math;
        static int count;

        //可有多個建構子 但設定參數要不一樣
        public MSIT62()
        {
            //Console.WriteLine("Hi");
            count++;
            StudentID = count;
        }

        public MSIT62(string str)
        {

            Console.WriteLine("HOHO");
            StudentName = str;
            count++;
            StudentID = count;

        }
        //方法
        public void Hi()
        {

            Console.WriteLine($"{StudentName}Say:   HE is No: {StudentID}");

        }

    }
}