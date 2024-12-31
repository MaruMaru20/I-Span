using System;

namespace Lab241227_keyword
{
    //定義屬性
    partial class MyMath
    {
        public int x;
        public int y;
    }
    //定義方法
    partial class MyMath
    {
        public int Cool()
        {
            return x + y;
        }
        public int Cool(int x2,int y2)
        {
            return x2 + y2;
        }
        public int Cool(string x3, string y3)
        {

            return int.Parse(x3) + int.Parse(y3);
        }
    }
}