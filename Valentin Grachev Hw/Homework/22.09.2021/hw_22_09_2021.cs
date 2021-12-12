using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class hw_22_09_2021
    {
        public void Task_1()
        {
            Console.WriteLine("Введите количество элементов в массиве");
            int n = Int32.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n ; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }

            int min = Int32.MaxValue;

            foreach(var el in a)
            {
                min = Math.Min(min, el);
            }
            Console.WriteLine(min);

        }
        public void Task_2A()
        {
            string s = Console.ReadLine();
            while(s.Length>36)
            {
                Console.WriteLine("Введена строка неверной длины");
                s = Console.ReadLine();
                
            }

            char[] chars = s.ToCharArray();
            foreach(var el in chars)
            {
                Console.Write(el);
            }

        }
        public void Task_2B()
        {
            
            }
        
    }
}
