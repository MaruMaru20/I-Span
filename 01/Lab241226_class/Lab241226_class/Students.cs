using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241226_class
{

    //  constructor 建構子| 建構函式
    // 1. 一定是public
    // 2. 函式名稱與類別名稱要一樣
    // 3.不用寫回傳值

    //範例:
    //public      Students() { }
    //static void 函式名稱() { }
        
    internal class Students
    {
        public Students(int studentID, string studentName, int chinese, int english, int math)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.chinese = chinese;
            this.english = english;
            this.math = math;
        }
        public Students() 
        {
            //Console.WriteLine("COOL");
        }
        // properties  定義屬性 
        // private "預設值" but why?
        // {get; set;}?

        public int studentID { get; }
        public string studentName;
        public int chinese;
        public int english;
        public int math;
        public static string classroom ="1802";

        // methods     定義方法 
        //物件方法:Study
        public void Study()
        {
            Console.WriteLine($"{studentName}  從不讀書");
        }

        //靜態方法:Exam
        public static void Exam(string subject)
        {
            Console.WriteLine($"{subject}  都0分");

        }

    }
}
