using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work.CW2.Event1
{
    public class Event1Runner
    {
        public static void Run()
        {
            var c1 = new Contract(1);
            var e1 = new Event1(9);
            var e2 = new Event1(1);
            c1.Subscribe(e1);
            c1.Subscribe(e2);
            e1.WriteAnn(null, "Nastya", new string[]
            {"Albedo", "Kazuha","Syao","Ita","Rainhard","Mercy","Paper", "Kaya", "Iyako" }, false);
            e2.WriteAnn(null, "AinsAllGone", new string[] { "Demeurg" }, true);
        }
    }
}
