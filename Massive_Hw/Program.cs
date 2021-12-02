using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static  void Main()
        {

            var x = Int32.Parse(Console.ReadLine());
            
            var y = Int32.Parse(Console.ReadLine());

            int[][] spiralArray = new int[y][];
            for (int i = 0; i < y; i++)
            {
                spiralArray[i] = new int[x];
            }

            int l = 0;
            int k = 0;

            while (l < y)
            {
                while (k < x)
                {
                    spiralArray[l][k] = Int32.Parse(Console.ReadLine());
                    k++;
                }

                k--;
                l++;

                if (l >= y)
                {
                    break;
                }

                while (k >= 0)
                {
                    spiralArray[l][k] = Int32.Parse(Console.ReadLine());
                    k--;
                }

                l++;
                k++;
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(spiralArray[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }










    }
}
