using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab250107_LINQ
{//誰實作Ienumerble? : 陣列


    //class
    class Student : IStudy, IEat
    {
        public string SName { get; set; }
        public string HowToRead(string How)
        { return $"{SName}表示: 先睡飽再縮 {How} "; }
        public string restaurant(string Name)
        {
            return $"{SName}表示: 不吃飯了{Name} ";
        }
    }
    class Teacher : IStudy
    {
        public string TName { get; set; }
        public string HowToRead(string How)
        { return $"{TName}先讀一頁再睡  {How}    "; }
    }

    //interface:watching only
    interface IStudy
    {
        //method
        string HowToRead(string How);

    }
    interface IEat
    {
        string restaurant(string Name);
    }

}
