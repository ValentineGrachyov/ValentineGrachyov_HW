using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Homework

{
    class Program
    {
        static void Main()
        {

            var list = new CustomList(4);
            list.AddToHead(1);
            list.AddToHead(2);
            list.AddToHead(3);
            list.AddToHead(4);
            list.AddToHead(5);
            list.AddToHead(6);
            list.AddToHead(7);
            list.AddToHead(8);
            list.AddToHead(9);
            list.AddToHead(10);
            list.DeletePosition(3);
            list.WriteToConsole();
            Console.ReadLine();
            
        }


    }
}
