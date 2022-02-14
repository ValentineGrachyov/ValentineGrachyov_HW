using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD
{
    class ArrayHw
    {
        public static int[] Task4(int[][] array, int k)
        {
            int[] result = new int[0];

            for (int i = 0; i < k; i++)
            {

                result = ArrayClasswork.JoinArray(result, array[i]);

            }

            return result;
        }
    }
}
