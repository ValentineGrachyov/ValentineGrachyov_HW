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
