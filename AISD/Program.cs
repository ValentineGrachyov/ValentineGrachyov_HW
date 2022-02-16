using System;

namespace AISD
{
    class Program
    {
        static void Main(string[] args)
        {
            // В k вписывается количество массивов.
            int k = 4;
            
            int[][] array = ArrayHW.ReadFile(k);
            int[] result = ArrayHW.Task4(array, k);

            foreach (int el in result)
            {
                Console.Write($"{el} ");
            }

            Console.ReadLine();
        }
    }
}

