using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class hw_29_09_2021
    {
        public void Task_1()
        {
            int ost = 0;
            int n = 0;
            int res = 0;
            while (ost == 0)
            {

                n = Readint();
                while (n > 0)
                {
                    ost = n % 10;
                    if (ost == 0)
                    {
                        Console.WriteLine("Wrong num");
                        break;
                    }
                    n /= 10;
                    res = (res * 10 + ost);
                }
            }

             Console.WriteLine(res);
        }
        public int Readint()
        {
            int n = Int32.Parse(Console.ReadLine());
            return n;
        }

        public void Fibbonachi(int n)
        {
            if(n==1)
            {
                Console.WriteLine("Число фибоначи равно 1");
                return;
            }
            if (n==0)
            {
                Console.WriteLine("Число фибоначи равно 0");
                return;
            }
            int prevnum = 0;
            int nextnum = 1;
            int sum = 0;

           for (int i = 2; i<=n; i++)
            {
                sum = prevnum + nextnum;
                prevnum = nextnum;
                nextnum = sum ;
                
            }
            Console.WriteLine(sum);
            
               
        }
    }
}
