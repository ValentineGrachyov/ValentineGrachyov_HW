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



namespace Homework
{
     class Program
    {
        static void Main()
        {
            //Event1Runner.Run();
            //Event2Runner.Run();
            //ReflectionRunner.Run();

            var a = new Linq();
            a.Run();
            
            Console.ReadLine();
        }
    }
}
