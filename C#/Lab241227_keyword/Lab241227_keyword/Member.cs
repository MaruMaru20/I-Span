using System;

namespace Lab241227_keyword
{
    internal class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }

        //屬性是否想做特殊處理
        private int _age;
        public int MemberAge
        {
            set { _age = (value > 18) ? 18 : value; }
            get { return _age; }
        }

        //屬性才能 get set  但下列為變數 
        private bool isLogin = false;

        public Member()
        {
            Console.WriteLine("OK");
        }
        public Member(string _MemberName)
        {
            Console.WriteLine("OK?????");
            //MemberName = _MemberName;
        }

        public void QueryMember()
        {
            Console.WriteLine($"ㄤㄤ{MemberName},你 {MemberAge}歲");
        }

        //如果未呼叫login不能買


        public void Login()
        {
            Console.WriteLine("OK");
            isLogin = true;
        }
        public void Shopping()
        {
            if (isLogin == true)
            {

                Console.Write("suss");
            }
            else
            {
                Console.WriteLine("OOPS");
            }
        }
    }
}