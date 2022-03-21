using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class StackRunner
    {
        public static void Run()
        {
            var stack = new Stack<int>();

            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            stack.Add(4);
            stack.Add(5);

            stack.DeleteSecondEl();
            //stack.DeletePrevElement();
            //stack.Peek(1);
            
            stack.Bust();
            Console.WriteLine($" {stack.Size()}");
        }
    }
}
