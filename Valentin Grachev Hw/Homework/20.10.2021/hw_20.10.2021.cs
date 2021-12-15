using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Circle
    {
        double Radius;
        double Perimeter;
        double Diameter;
        double Square;

        public Circle(double Radius)
        {
            this.Radius = Radius;
            this.Perimeter = GetPerimeter(Radius);
            this.Diameter = GetDiameter(Radius);
            this.Square = GetSquare(Radius);
        }

        public static double GetPerimeter(double Radius)
        {
            if (Radius <= 0)
                return 0;

            return 2 * Math.PI * Radius;
        }

        public static double GetSquare(double Radius)
        {
            if (Radius <= 0)
                return 0;

            return  Math.PI * Radius* Radius;
        }

        public static double GetDiameter(double Radius)
        {
            if (Radius <= 0)
                return 0;

            return 2 * Radius;
        }

        public void Print()
        {
            if (Radius <= 0)
            {
                Console.WriteLine("Нет такой окружности");
                return;
            }
            Console.WriteLine($"Радиус = {Radius}\nПериметр = {Perimeter}\nПлощадь = {Square}\nДиаметр = {Diameter}");
        }

    }

    public class Student
    {
        string Name;
        string Surname;
        string Patronic;
        string GroupNum;
       int Progress;
        string Sno;
        public DateTime Birthday;
        public void Read(int y,  int m, int d, int p)
        {
            Console.WriteLine("Имя");
            Name = Console.ReadLine();
            Console.WriteLine("Фамилия");
            Surname = Console.ReadLine();
            Console.WriteLine("Отчество");
            Patronic = Console.ReadLine();
            Birthday = new DateTime (y,m,d);
            Console.WriteLine("В какой вы группе?");
            GroupNum = Console.ReadLine();
            Console.WriteLine("Вы состоите в сно? (да или нет)");
            Sno = Console.ReadLine();
            Progress = p;
           
            

            Console.WriteLine($"{Name} {Surname} {Patronic} Дата рождения {Birthday} {GroupNum} \nЧленство в СНО {Sno}\nВаша успеваемость(средний балл) { Progress}");
            Sno = Console.ReadLine();
        }
    }

    public class BigNum
    {
        public int[] Num = { 0 };
        public int[] Num1 = { 0 };
        
        public void Sum(int[] array, int[] array1)
        {

            int[] result = new int[Math.Max(array.Length, array1.Length)];
            
            for (int i = 0; i < array.Length && i< array1.Length ; i +=1 )
            {
                

                result[i] = array[ i] + array1[ i];

                    
               
            }
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }

        }




    }

}
