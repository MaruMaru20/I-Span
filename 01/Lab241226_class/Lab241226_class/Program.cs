
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab241226_class
{
    internal class Program
    {
        //Q 老師要存MSIT62資料 (學號 姓名) 國中der班級 (國英數)成績
        //A 該用什麼型態存放 string[,,,] string[][][]?? NONONO  --->  選


        //方案總管 >> 方案下 >> 右鍵 >> 加入 >> 新增現有項目 students.cs
        static void WWW()
        {
            Students xx = new Students();
            xx.studentName = "名子";
            xx.chinese = 600;

            Console.WriteLine($"號碼: {xx.studentID}");
            Console.WriteLine($"名子: {xx.studentName}");
            Console.WriteLine($"分數: {xx.chinese}");
            Students.Exam("法文");
            xx.Study();
            Console.WriteLine("---------------------------");
            Students xx2 = new Students();
            xx2.studentName = "名名子";
            xx2.chinese = 600;
            xx2.Study();
        }
        static void Main(string[] args)
        {
            //WWW();
            MSIT62 s1 = new MSIT62();
            s1.StudentName = "Bear  ";
            s1.Hi();
            MSIT62 s2 = new MSIT62("Shark ");
            s2.Hi();
            MSIT62 s3 = new MSIT62("DanDan");
            s3.Hi();



        }
    }
}
