using System;

namespace AISD
{
    public  class ContestTask1
    {
        public void Run()
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] sticks = new int[n+1]; 
            string[] str = Console.ReadLine().Split(' ');
            int[] triangles = new int[n + 1];
            int answer = 0;
            for(int i = 0; i < n; i++)
            {                
                sticks[i] = Int32.Parse(str[i]);
            }
            for(int i = 0;i < n; i++)
            {
                triangles[i] += 1;
            }
            foreach(var el in triangles)
            {
                if(el% 3 == 0 || el >=3)
                { answer += el/3;}
            }
            Console.WriteLine(answer);
        }
    }
}
