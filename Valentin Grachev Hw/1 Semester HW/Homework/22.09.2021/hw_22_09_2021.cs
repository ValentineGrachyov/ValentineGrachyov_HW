using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class hw_22_09_2021
    {
       public static void Task1()
        {
            
            int[,] a = { {-155,36 }, {61,31 } };
            int min = a[0,0];
            foreach (var el in a) min = Math.Min(min, el);

            Console.WriteLine(min);
            
            
        }

        public static void Task2()
        {
           string line =  Console.ReadLine();
            if (line.Length > 36)
            {
                throw new Exception("Максимум 36 символов");
            }

            var array = line.ToCharArray();
              
            foreach (var el in array) Console.Write(el);
            
           
                
        }
        
    }
}
