using System;

namespace AISD
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 4; 
            int[][] array = new int[k][];
            array[0]=new int[] { 1, 2, 3, 4, 5, 6, 11, 16 };
            array[1] = new int[] { 1, 3, 4, 19, 25 };
            array[2]= new int[] { 3, 4, 6, 8 };
            array[3] = new int[] { 10, 12};
            int[] result = ArrayHw.Task4(array, k);

            foreach(int el in result)
            {
                Console.Write($"{el} ");
            }

            Console.ReadLine();
        }
    }
}

