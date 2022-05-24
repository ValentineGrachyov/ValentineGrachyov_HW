using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.AISD_HW.Karatsuba
{
    public class Karatsuba
    {
        public double KaratsubaMultiple(double a, double b)
        {
            if(a<10 && b<10)
            { return a * b; }

            var discharge = Math.Max(a.ToString().Length, b.ToString().Length);

            var dischargeHalf = discharge / 2;

            var a_0 = Math.Floor(a/Math.Pow(10,dischargeHalf));
            var a_1 = a % Math.Pow(10, dischargeHalf);
            var b_0 = Math.Floor(b/Math.Pow(10,dischargeHalf));
            var b_1 = b % Math.Pow(10, dischargeHalf);

            var x = KaratsubaMultiple(a_0, b_0);
            var y = KaratsubaMultiple(a_1, b_1);
            var z = KaratsubaMultiple(a_1 + a_0, b_1 + b_0);

            return x*Math.Pow(10,dischargeHalf*2) + Math.Pow(10,dischargeHalf)*(z - x- y) + y;
        }
    }
}
