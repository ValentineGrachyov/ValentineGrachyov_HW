using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main()
        {
            var a = new Vektor(10, 11);
            var b = new Vektor(1, 9);
            var c = new Vektor(10, 1);
            bool is_equals = a.Equal_of_Vectors(c);
            a = a.Add(a);
            b = b.Mult(b, 3);
            a.Vektor_ToString();
            b.Vektor_ToString();
            a.Cosinus(a);
            double sc_m = a.Scalar_Mult(a);
            Console.WriteLine($"{is_equals} {sc_m}") ;
            Console.ReadLine();
            //
        }
    }
}
//