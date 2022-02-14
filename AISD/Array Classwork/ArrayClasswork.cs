using System;
using System.IO;

namespace AISD
{
    public class ArrayClasswork
    {
        public static int[] JoinArray(int[] a1, int[] a2)
        {
            if (a1?.Length == 0 && a2?.Length == 0)
            {
                Console.WriteLine("Один из массивов пустой");
                return null;
            }


            int i1 = 0;
            int i2 = 0;
            int[] result = new int[a1.Length + a2.Length];
            int iResult = 0;

            while (i1 < a1.Length && i2 < a2.Length)
            {
                if (a1[i1] < a2[i2])
                {
                    result[iResult] = a1[i1];
                    i1++;
                }
                else
                {
                    result[iResult] = a2[i2];
                    i2++;
                }
                iResult++;
            }

            if (i1 < a1.Length)
            {
                for (int i = i1; i < a1.Length; i++)
                {
                    result[iResult] = a1[i];
                    iResult++;
                }
            }
            if (i2 < a2.Length)
            {
                for (int i = i2; i < a2.Length; i++)
                {
                    result[iResult] = a2[i];
                    iResult++;
                }
            }
            return result;
        }

        public int[] DeSum(int[] a1, int[] a2)
        {
            int[] result = new int[a1.Length + a2.Length];
            int i1 = 0;
            int i2 = 0;
            int iRes = 0;

            while (i1 < a1.Length && i2 < a2.Length)
            {
                if (a1[i1] < a2[i2])
                {
                    result[iRes] = a1[i1];
                    i1++;
                    iRes++;
                }
                else
                    if (a1[i1] == a2[i2])
                {
                    i1++;
                    i2++;
                }

                else if (a2[i2] > a1[i1])
                {

                    i2++;
                }
            }
            if (i1 < a1.Length)
                for (int i = i1; i < a1.Length; i++)
                {
                    result[iRes] = a1[i];
                    iRes++;
                }
            if (i2 < a2.Length)
                for (int i = i2; i < a2.Length; i++)
                {
                    result[iRes] = a2[i];
                    iRes++;
                }

            return result;
        }

        public static int[] Cross(int[] a1, int[] a2)
        {
            if (a1?.Length == 0 && a2?.Length == 0)
            {
                Console.WriteLine("Что- то пошло не так");
                return null;
            }

            int i1 = 0;
            int i2 = 0;
            int iRes = 0;
            int[] result = new int[a1.Length + a2.Length];

            while(i1<a1.Length && i2 < a2.Length)
            {
                if (a1[i1] == a2[i2])
                {
                    result[iRes] = a1[i1];
                    i1++;
                    i2++;
                    iRes++;

                }
                else if(a1[i1]> a2[i2])
                {
                    i2++;
                }
                else 
                    i1++;
                

               
                
                
            }
            return result;

        }
       public static void Task5(int[] a)
        {
            if (a?.Length == 0)
            {
                throw new Exception("уа уа уа");
            }
            
            int max = int.MaxValue;
            foreach(int el in a)
            {

                if(el%10 < max)
                {
                    max = el;
                    
                }
                else
                {
                    max = el;
                }

                if(max%10 == el)
                {

                }
                Console.WriteLine(max);
            }

            //return result;
        }

    }
}


