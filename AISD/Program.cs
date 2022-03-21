using System;

namespace AISD
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new CustomList(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.ReplaceNearEl();
            

            list.WriteToConsole();








            Console.ReadLine();
        }
    }
}

