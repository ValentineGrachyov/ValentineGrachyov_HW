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
            
          

            int[,] number = new int[2, 3] { { 1, 2, 3 }, { 4,5,6 } };

            int[] massive = new int[36] ;

            foreach(int i in massive)
            {
                 
                int k = Int32.Parse(Console.ReadLine());
                k = i;
                Console.WriteLine(massive[i]);
            }



            void Min(int[,] input)
            {
                int min = int.MaxValue;
                foreach(int i in input )
                {
                    if (i < min)
                        min = i;
                }

                Console.WriteLine(min);
            }

            Min(number);
            Console.ReadLine();
           
        
        }
    }
}
