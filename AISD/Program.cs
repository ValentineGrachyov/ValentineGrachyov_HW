using System;
using System.Collections.Generic;
using System.Linq;



namespace AISD
{
    class Program
    {
        static void Main(string[] args)
        {

            int numFromStreet = Int32.Parse(Console.ReadLine());
            string[] streetproducts = Console.ReadLine().Split(new char[] {'\n', ' '});
            int[] nums = (int[])streetproducts.Select(x => Int32.Parse(x));
            string[] str = (string[])streetproducts.Where(x => !IsNum(x)).Select(x => x);
            Dictionary<string, int>  productsFromStreet = new Dictionary<string, int>();
            for(int i = 0; i < numFromStreet; i++)
            {
                productsFromStreet.Add(str[i], nums[i]);
            }

            int numInMag = Int32.Parse(Console.ReadLine());
            string[] MagProducts = Console.ReadLine().Split(new char[] { '\n', ' ' });
            int[] nums1 = (int[])streetproducts.Select(x => Int32.Parse(x));
            string[] str1 = (string[])streetproducts.Where(x => !IsNum(x)).Select(x => x);
            Dictionary<string, int> productsInMag = new Dictionary<string, int>();
            for (int i = 0; i < numInMag; i++)
            {
                
                productsInMag.Add(str1[i], nums1[i]);
            }
            int[] result = new int[Math.Max(numInMag, numFromStreet)];

            for(int i = 0;i < Math.Max(numInMag,numFromStreet); i++)
            {
                if(productsInMag[str1[i]] == productsFromStreet[str1[i]])
                {
                    result[i] += productsFromStreet[str1[i]];
                }
                result[i] = 03;
            }


            static bool IsNum( string source)
            {
                if (string.IsNullOrWhiteSpace(source)) return false;

                try
                {
                    var num = int.Parse(source);
                    return true;
                }
                catch
                {
                    return false;
                }

            }

        }

        
    }
}

