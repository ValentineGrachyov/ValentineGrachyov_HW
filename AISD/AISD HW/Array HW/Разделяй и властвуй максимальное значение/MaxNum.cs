using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.AISD_HW.Array_HW.Разделяй_и_властвуй_максимальное_значение
{
    public class MaxNum
    {
        public void PrintMaxNum(int[] arr)
        {   
            int m = arr.Length / 2;
            
            Console.WriteLine("The num " + arr[m]);
        }

        public int[] ArraySideLeft(int[] arr) => arr[0 ..(arr.Length/2)];

        public int[] ArraySideRight(int[] arr) => arr[(arr.Length / 2)..(arr.Length )];

    }
}
