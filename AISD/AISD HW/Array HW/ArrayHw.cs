using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AISD
{
    public class ArrayHW
    {

        public static int[][] ReadFile(int k)
        {
            int[][] result = new int[k][];
            

            StreamReader str = new StreamReader(@"C:\Программирование\Task4.txt");

            // С каждой итерацией i в первом цикле мы двигаемся по ячейкам, в которых будут храниться массивы.
            for (int i = 0; i <k; i++)
            {
               
                string a = str.ReadLine();
                string[] a1 = a.Split(' ');
                int[] nums = new int[a1.Length];


                // Во втором цикле, массив nums заполняется считанной строкой, и передается в ячейки result. 
                for(int j = 0; j<a1.Length; j++)
                {
                    nums[j] = Convert.ToInt32(a1[j]);
                    result[i] = nums;
                                        
                }
  
            }
            return result;
        }

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
