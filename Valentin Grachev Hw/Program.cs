using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            var a = new hw_22_09_2021();
            a.Task_2B();
            a.Task_1();
            a.Task_2A();

            var b = new hw_29_09_2021();

            b.Task_1();
            b.Fibbonachi(10);

            var c = new Circle(4);
            c.Print();



            var f = new RationalFraction(4, 5);
            var g = new RationalFraction(2, 1);

            f.Mult(g);

            f.Div(g);
            Console.WriteLine(f.ToDouble());
            f.Print();

            var m = new Matrix_2x2(1, 2, 3, 4);
            var m1 = new Matrix_2x2(1, 2, 3, 4);
            m.Mult(m1);
            m.Print();
            var k = new ComplexNum(1, -2);
            var k1 = new ComplexNum(1, -3);
            k.Complex();
            k1.Complex();
            k.ComplexSum(k1);
            k.ComplexMult(k1);
            k.Trigonometriya();



            var s = new Student();
            s.Read(2000, 7, 19, 70);
            s.Read(1978, 1, 29, 56);
            s.Read(2055, 12, 9, 20);

            var num = new BigNum();
            int[] array = {1, 2, 3 };
            int[] array1 = { 1, 2, 3 };
            num.Num = array;
            num.Num1 = array1;
            num.Sum( array, array1 );
            Console.ReadLine();
            



        }










    }
}
