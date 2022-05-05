using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AISD.Array_Classwork;

namespace AISD
{
    public class ArrayClasswork2
    {
        public static Classcouple[] UniqNumCount(int[] array)
        {
            if (array == null)
            {
                throw new Exception("fafafa");
            }
            Classcouple[] couple = new Classcouple[0];
            foreach(var el in array)
            {
                int i = 0;
                while(i < couple.Length)
                {
                    if (couple[i].Key == el)
                    {
                        couple[i].Value++;
                        break;
                    }
                    i++;
                }
                if(i == couple.Length)
                {
                    Array.Resize(ref couple, couple.Length + 1);
                    couple[i] = new Classcouple(el, 1);
                    
                }
            }
            return couple;
        }
    }
}
