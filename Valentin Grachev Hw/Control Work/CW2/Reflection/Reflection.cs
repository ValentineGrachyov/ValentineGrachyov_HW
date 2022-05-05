using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Homework.Control_Work.CW2.Reflection
{
    public class Reflection
    {
        public Action<Reflection> CallDelegate;

        public void CallDel(Reflection r)
        {
            r.CallDelegate += CallDel;
        }

        private int num = 4;

        public void PrintPrivate()
        {
            Console.WriteLine(num);
        }
        public int PrivateNumCopy;

        public int Num { get { return 1; } }

        public static void Print()
        {
            Console.WriteLine("Hello world");            
        }
    }

    
}
