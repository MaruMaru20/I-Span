using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab250107_LINQ
{
    class Car
    {
        public virtual string Start()
        {
            return "The car is Start";
        }
        public string Stop()
        {
            return "The car is stop";
        }
    }
    //inheritance review
    class Mini_cooper : Car
    {

    }
    class Volvo : Car 
    {

        public string Start(string a)
        {
            return $"{a} The car is Start.";
        }


    }
}
