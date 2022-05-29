using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;



namespace AISD
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread tread = new Thread(A);
            Task twrite = new Task(A);
            
        }
        public  static void A()
        {
            Console.WriteLine("A");
        }
    }
}

