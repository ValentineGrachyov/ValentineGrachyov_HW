using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work.CW2.Reflection
{
    public class Event
    {
        public void Print_A(Reflection r)
        {            
            Console.WriteLine("A");
        }
        public void Subscribe(Reflection r)
        {
            r.CallDelegate += Print_A;
        }
    }
}
