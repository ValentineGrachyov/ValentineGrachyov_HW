using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class RationallFractions
    {
        private int a;
        private int b;
        public RationallFractions()
        {
            a = 0;
            b = 1;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="x" числитель></param>
        /// <param name="y" знаменатель></param>
        public RationallFractions(int x, int y)
        {
            a = x;
            b = y;

        }

        private void reduce_Yourself()
        {
            
            int z = NOD(a, b);
            a = a / z;
            b = b / z;
        }

        private RationallFractions reduce(RationallFractions r)
        {
            int z = NOD(r.a, r.b);
            return new RationallFractions(r.a / z, r.b/z);
        }
        private int NOD(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            while (x != 0 && y != 0)
            {
                if (x > y)

                    x = x % y;
                else
                    y = y % x;
            }
            return x + y;
        }
        private int Nok(int x, int y)
        {
            return x * y / NOD(x, y);
        }

        public RationallFractions Add(RationallFractions r)
        {
            int z = Nok(r.b, b);
            int z1 = z / b * a + z / r.b * r.a;
            RationallFractions newZ = new RationallFractions(z1, z);
            return reduce(newZ);

            
        }
        public void Add_Toyourself(RationallFractions r)
        {
            int z = Nok(r.b, b);
            a = z / b * a + z / r.b * r.a;
            b = z;
            reduce_Yourself();
        }

        public RationallFractions Sub(RationallFractions r)
        {
            int z = Nok(r.b, b);
            int z1 = z / b * a + z / r.b * r.a;
            RationallFractions newZ = new RationallFractions(z1, z);
        }
    }
}
