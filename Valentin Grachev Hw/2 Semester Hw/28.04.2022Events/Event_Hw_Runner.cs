using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework._2_Semester_Hw._28._04._2022Events
{
    public class Event_Hw_Runner
    {
       public void Run()
        {
            var a = new ElectricalStation(10);
            var m = new MCHS();
            var f = new FireBrigade();
            
            m.Subscribe(a);
            f.Subscribe(a);
            a.StartSt(0);
            Console.ReadLine();
        }
    }
}
