using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Ingrediate
    {
        private int squirrels;
        public int Squirreles
        {
            get
            {
                return squirrels;
            }
            set
            {
                if(value<0)
                {
                    throw new Exception("Жиры всегда положительны!!!!");
                }
                squirrels = value;
            }
        }

        private int fats;
        public int Fats
        {
            get
            {
                return fats;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Жиры всегда положительны!!!!");
                }
                fats = value;
            }
        }

        private int carbonHydrates;
        public int CarbonHydrates
        {
            get
            {
                return carbonHydrates;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Жиры всегда положительны!!!!");
                }
                carbonHydrates = value;
            }
        }

        private int kalority;
        public int Kalority
        {
            get
            {
                return kalority;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Жиры всегда положительны!!!!");
                }
                kalority = value;
            }
        }

        public Ingrediate(int squirrels, int fats, int carbonhydrates, int kalority)
        {
            Squirreles = squirrels;
            Fats = fats;
            CarbonHydrates = carbonhydrates;
            Kalority = kalority;
        }

    }
}
