using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using Homework.Control_Work.CW2.Event1;
using Homework.Control_Work.CW2.Event2;
using Homework.Control_Work.CW2.Reflection;
using Homework.Control_Work.CW2;
using Homework._2_Semester_Hw._28._02___7;



namespace Homework
{
     class Program
    {
        static void Main()
        {
            var a = new LinkedList<int>(0);
            a.AddRange(1,2,3,5,6);
            a.WriteToConsole();

            Console.ReadLine();
        }
    }
}
