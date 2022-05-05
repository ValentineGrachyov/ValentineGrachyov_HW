using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Classwork.Mult
{
    public class StrangeMult
    {
        public double Calc(int a, int b)
        {
            var result = calc(new Number(a, 0), new Number(b,0));
            return (result.Numeral * Math.Pow(10, result.Discharge));

        }

        private int Length(int a)
        {
            int l = 1;
            while (a / 10 != 0) l++;
            return l;
        }
        private  Number calc(Number a, Number b)
        {
            if (b.Numeral == 0 || a.Numeral == 0) return new Number(0, 0);
            if (a.Numeral == 1) return new Number(b.Numeral, b.Discharge + a.Discharge);
            if (b.Numeral == 1) return new Number(a.Numeral, b.Discharge + a.Discharge);
            if (a.Numeral < 10 || b.Numeral < 10) return new Number(b.Numeral * a.Numeral, 0);

            int aLength = Length(a.Numeral);
            int bLength = Length(b.Numeral);
            int halfLength1 = aLength / 2;
            int halfLength2 = bLength / 2;
            Number a1 = new Number(Convert.ToInt32(a.Numeral / Math.Pow(10, halfLength1)), 1);
            Number a2 = new Number(Convert.ToInt32(a.Numeral % Math.Pow(10, aLength - halfLength1)), 0);
            Number b1 = new Number(Convert.ToInt32(b.Numeral / Math.Pow(10, halfLength2)), 1);
            Number b2 = new Number(Convert.ToInt32(b.Numeral % Math.Pow(10, bLength - halfLength2)), 0);

            Number ac = calc(a1, b1);
            Number cd = calc(a2, b2);

        }

    }

    public struct Number
    {
        public int Numeral;
        public int Discharge;

        public Number(int numeral, int discharge)
        {
            Numeral = numeral;
            Discharge = discharge;
        }
    }
   
}
