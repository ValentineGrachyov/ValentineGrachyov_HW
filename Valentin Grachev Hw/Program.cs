using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using Homework._2_Semester_Hw._28._02___7;
using Homework._2_Semester_Hw._28._04._2022Events;



namespace Homework
{
     class Program
    {
        static void Main()
        {
            var a = new ElectricalStation(10);
            var f = new FireBrigade();
            var p = new MCHS();
            p.Subscribe(a);
            f.Subscribe(a);
            a.Timer();
            a.StartSt(null);
            
            
            Console.ReadLine();
        }
    }
}
