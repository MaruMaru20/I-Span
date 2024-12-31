using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab241230_inheritance
{
    class iPhone
    {
        public string PhoneColor { get; }
        public string PhoneSpace { get; }

        public iPhone()
        {
            Console.WriteLine("建構中 - 11111");
            PhoneColor = "Black";
            PhoneSpace = "512GB";
        }

        public iPhone(string PhoneColor, string PhoneSpace)
        {
            Console.WriteLine("建構中 - 22222");
            this.PhoneColor = PhoneColor;
            this.PhoneSpace = PhoneSpace;
        }

        public virtual void HeySiri()
        {
            Console.WriteLine("Unn?");
        }
        public virtual void Call()
        {
            Console.WriteLine("Nope pay first");
        }
        public virtual void Camara()
        {
            Console.WriteLine("keekekek?");
        }
    }

    //inheritance <  :  > 繼承  
    //可多個?  NO
    class iPhone16 : iPhone { }

    //延伸--------繼承 可修改?
    class iPhone17 : iPhone
    {
        // x (進到  建構 --1)
        public iPhone17()
        {
            Console.WriteLine("建構中 - 33333");
        }
        //y (進到  建構 --1)
        public iPhone17(string city, string store)
        {
            Console.WriteLine("建構中 - 44444 ");
            Console.WriteLine($"go to {city} to take{store}");
        }
        //z 增加 ----base   根據父類別去呼叫參數(進到  建構 --2)
        public iPhone17(string city, string store, string color, string space) : base(color, space)
        {
            Console.WriteLine("建構中 - 55555 ");
            Console.WriteLine($"go to {city} to take{store}");
        }

        //父類別如需繼承    最好主動加上 virtual
        //父類別沒有加 virtual 則需 new (不推薦)
        public new void HeySiri()
        {
            Console.WriteLine("嘿?");
        }
        //父類別有加 virtual 則需 override 
        public override void Call()
        {
            //base.Call();
            Console.WriteLine("鈴聲2");
        }
    }
}

