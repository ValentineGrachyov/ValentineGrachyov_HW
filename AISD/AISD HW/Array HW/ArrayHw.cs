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

        public static int[][] ReadFile(string path)
        {
            int[][] result = Array.Empty<int[]>();
            
            
            StreamReader sr = new(path);
            var length = int.Parse(sr.ReadLine());
            // С каждой итерацией i в первом цикле мы двигаемся по ячейкам, в которых будут храниться массивы.
            for (int i = 1; i < length; i++)
            {

                _ = result.Append(Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse));
                // Во втором цикле, массив nums заполняется считанной строкой, и передается в ячейки result. 
                
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
