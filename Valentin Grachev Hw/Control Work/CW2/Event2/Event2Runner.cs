using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work.CW2.Event2
{
    public  class Event2Runner
    {
        public static void Run()
        {
            var c1 = new Contract(1);
            var e = new Event2();
            c1.Subscribe(e);
            e.CallContract("Valya", 18);
            e.CallContract("Dima", 5);

        }
    }
}
