using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class ComplexNum
    {

        private int real;
        public int Real { get { return real; } }
        public int Imagine;

        public ComplexNum(int real, int Image)
        {
            this.real = real;
            Imagine = Image;
        }

        public void Complex()
        {
            if (Imagine > 0)
            {
                Console.WriteLine($"Комплексное число {Real} + {Imagine}i");

            }
            else
            {
                Console.WriteLine($"Комплексное число {Real}  {Imagine}i");

            }
            Console.ReadLine();
        }

        public void ComplexSum(ComplexNum input)
        {
            //Console.WriteLine("Сумма двух комплексных чисел");
            int real1 = Real + input.Real;

            int image1 = Imagine + input.Imagine;

            CheckNum(real1, image1);

        }


        private static ComplexNum Add(ComplexNum a, ComplexNum b)
        {
            a.ComplexSum(b);
            return a;
        }
        public static ComplexNum operator +(ComplexNum a, ComplexNum b) => ComplexNum.Add(a, b);  
        public void ComplexMult(ComplexNum input)
        {
            Console.WriteLine("Перемножение чисел");
            int real1 = Real * input.Real + Imagine * input.Imagine * (-1);

            int image1 = Real * input.Imagine + Imagine * input.Real;

            CheckNum(real1, image1);
            
        }

        public void Trigonometriya()
        {            
            double length = Math.Sqrt(Math.Pow(Real,2) + Math.Pow(Imagine,2));

            double cos = Real / length;

            double sin = Imagine / length;

            if (cos > 0 && sin > 0 && Imagine > 0)            
                Console.WriteLine($"{Real} + {Imagine}*i = {length}({cos} + {sin}*i)");

            if (cos > 0 && sin > 0 && Imagine < 0)
                Console.WriteLine($"{Real}  {Imagine}*i = {length}({cos} + {sin}*i)");

            if (cos>0 & sin<0 && Imagine < 0)
                Console.WriteLine($"{Real}  {Imagine}*i = {length}({cos}  {sin}*i)");

            if (cos > 0 & sin < 0 && Imagine > 0)
                Console.WriteLine($"{Real} + {Imagine}*i = {length}({cos}  {sin}*i)");

            if (cos<0 & sin>0 && Imagine < 0)
                Console.WriteLine($"{Real}  {Imagine}*i = {length}({cos} + {sin}*i)");

            if (cos < 0 & sin > 0 && Imagine > 0)
                Console.WriteLine($"{Real} + {Imagine}*i = {length}({cos} + {sin}*i)");


            if (cos < 0 && sin < 0 && Imagine < 0)
                Console.WriteLine($"{Real}  {Imagine}*i = {length}({cos}  {sin}*i)");

            if (cos < 0 && sin < 0 && Imagine > 0)
                Console.WriteLine($"{Real} + {Imagine}*i = {length}({cos}  {sin}*i)");

            Console.ReadLine();
        }

        void CheckNum(int real1, int image1)
        {
            if (image1 > 0)
            {
                Console.WriteLine($"{real1} + {image1}i");
                Console.ReadLine();
            }
            else
                Console.WriteLine($"{real1}  {image1}i");
            Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{Real} {Imagine}";
        }
    }


}
