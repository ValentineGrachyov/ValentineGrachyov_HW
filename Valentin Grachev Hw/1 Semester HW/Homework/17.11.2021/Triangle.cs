using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
     public class Triangle
    {
        protected double A;

        protected double B;

        protected double C;

        protected double AngleAB;

        protected double AngleAC;
        
        protected double AngleBC;

        public Triangle(double a, double b, double c)
        {
            ChangeTriangle(a, b, c);
            
        }

        public void ChangeTriangle(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a) throw new Exception("Невозможно создать треугольник с этими данными");

            A = a;
            B = b;
            C = c;

            AngleAB = GetAngle(A, B, C);

            AngleAC = GetAngle(A, C, B);

            AngleBC = GetAngle(C, B, A);

        }

        public   double GetSquare()
        {
            return 0.5 * A * B * Math.Sin(AngleAB*Math.PI/180);
            
        }

        public double GetPerimeter() => A + B + C;

        public void Print()
        {
            Console.WriteLine( $"{A}, {B}, {C}, {AngleAB}, {AngleAC}, {AngleBC},  , {GetPerimeter()}");
            
        }

        public double GetAngle(double side_1, double side_2, double side_3 )
        {
            double angle = Math.Acos((side_1 * side_1 + side_2 * side_2 - side_3 * side_3) / (2 * side_1 * side_2)) * (180 / Math.PI);
            return angle;
        }

        public double GetSideA() => A;
        public double GetSideB() => B;
        public double GetSideC() => C;






    }

    public class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b, double c): base(a,b,c)
        {
            ChangeTriangle(a, b, c);

            if (AngleAB == 90 | AngleAC == 90 | AngleBC == 90) { }
            else
                throw new Exception("Это не прямоугольный треугольник");

        }

        public double GetSquare(double a, double b, double c)
        {
            ChangeTriangle(a, b, c);
            double result =0;
            if (AngleAB == 90)
                result = 0.5 * a * b;
            else
                if (AngleAC == 90)
            {
                result = 0.5 * a * c;
            }
            else
                result = 0.5 * b * c;

            
            return result;
        }
    }

    public class TwoSideTriangle:Triangle
    {
        public TwoSideTriangle(double a, double b, double c):base(a,b,c)
        {
            ChangeTriangle(a, b, c);

            if (a == b | a == c | b == c) { }
            else
                throw new Exception("Не равнобедренный треугольник");

        }
        

        public double GetHight(double a, double b,double c)
        {
            double height = 0;
            if (a == b)
                height = Math.Sqrt(b * b - Math.Pow(c,2) / 4);
            else
                if (a == c)
                height = Math.Sqrt(a * a - Math.Pow(b, 2) / 4);
            else
                height = Math.Sqrt(b * b - Math.Pow(a, 2) / 4);
            return height;
        }

        

        public double GetSquare(double a, double b,double c, double h)
        {
            
            double result = 0;
            if (a == b)
                result = 0.5*h*c/2;
            else
               if (a == c)
                result = 0.5 * h * b / 2;
            else
                result = 0.5 * h * a / 2;
            return result;
            
        }
        
    }


}
