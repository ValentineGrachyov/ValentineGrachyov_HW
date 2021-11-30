using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive_Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            
          

            int[] number = new int[] {  1, 2, 3, 4,5,6 } ;

            int n = Int32.Parse(Console.ReadLine());
            var a = new string[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Console.ReadLine();
                }
            foreach (string el in a)
            {
                Console.Write(el);
            }


            void Min(int[] input)
            {
                int min = int.MaxValue;
                foreach (int i in input)
                {
                    if (i < min)
                        min = i;
                }
                Console.WriteLine();
                Console.WriteLine(min);
            }
            Min(number);

            Console.ReadLine();

        }
            


           

        
            
           
        
        
    }
}
