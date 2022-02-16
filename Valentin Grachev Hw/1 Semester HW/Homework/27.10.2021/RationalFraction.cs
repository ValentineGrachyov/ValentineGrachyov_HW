using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class RationalFraction
    {
        int Numerator;
        int Denominator;

        public RationalFraction(int Numerator, int Denominator)
        {
            if (Denominator == 0)
            {
                Console.WriteLine("Нет такой дроби");
                
            }
            else
            {
                this.Numerator = Numerator;
                this.Denominator = Denominator;

                
                Reduce();
            }
            
        }

        public void Reduce()
        {
            int Nod = 1;
            for (int i = 1; i <= Denominator; i++)
            {
               if(Numerator% i == 0 && Denominator% i ==0)
                {
                    Nod = i;
                }
               
            }
            Numerator /= Nod;
            Denominator /= Nod;
            

        }

        public void Mult(RationalFraction input)
        {
            Numerator *= input.GetNumerator();
            Denominator *= input.GetDenominator();

            Reduce();
        }

        public void Div(RationalFraction input)
        {
            Denominator *= input.GetNumerator();
            Numerator *= input.GetDenominator();

            Reduce();
        }

        public double ToDouble()
        {
            double num = Numerator;
            double denum = Denominator;
            return num / denum;
            
        }
        public int GetNumerator()
        {
            return Numerator;
        }
        public int GetDenominator()
        {
            return Denominator;
        }
        public void Print()
        {
            Console.WriteLine($"{Numerator}/{Denominator} ");
        }


    }
}
