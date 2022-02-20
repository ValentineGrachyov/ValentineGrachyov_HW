using System;

namespace AISD
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = @"C:\Программирование\Task4.txt";

            //var result = ArrayHW.Task4(ArrayHW.ReadFile(path));
            //Console.WriteLine(String.Join(" ", result));

            int[] array = new int[7] { 1, 2, 3, 1, 2, 20, 1 };
            var result = ArrayClasswork2.UniqNumCount(array);

            Console.WriteLine(result);
            Console.ReadLine();








            Console.ReadLine();
        }
    }
}

