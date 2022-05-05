using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work
{
    public class StackRunner
    {
        public static void Run()
        {
            
            var stack = new StackRealization<int>(4);
            stack.AddEl(5);
            stack.AddEl(6);
            stack.AddEl(7);
            stack.AddEl(8);
            stack.AddEl(9);
            //stack.DeleteSecondEl();
            stack.DeletePenultimateEl();
            stack.WriteToConsole();

            

            
        }
    }
}
