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
            for (int i = 1; i <= length; i++)
            {

                result =  result.Append(Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse)).ToArray();
                // Во втором цикле, массив nums заполняется считанной строкой, и передается в ячейки result. 
                
            }
            
            sr.Dispose();
            return result;
        }

        public static int[] Task4(int[][] array)
        {



            int[] result = { };
;
            //foreach(var el in result)

            for (int i = 0; i < array.GetLength(0); i++)
            {

                result = ArrayClasswork.JoinArray(result, array[i]);

            }

            return result;
        }
    }
}
