using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Vektor
    {
        public double x { get; set; }

        public double y { get; set; }

        public Vektor() { x = 0; y = 0; }

        public Vektor(double x_coordinate, double y_coordinate)
        {
            x = x_coordinate;
            y = y_coordinate;

        }

        public Vektor Add(Vektor vector)
        {
            return new Vektor(x + vector.x, y + vector.y);
        }

        public void Add_To_Yourself(Vektor vector)
        {
            x += vector.x;
            y += vector.y;
        }

        public Vektor Sub(Vektor vector)
        {
            return new Vektor(x - vector.x, y - vector.y);
        }

        public void Sub_To_Yourself(Vektor vector)
        {
            x -= vector.x;
            y -= vector.y;
        }

        public Vektor Mult(Vektor vector, double cof)
        {

            return new Vektor(x * cof, y * cof);
        }

        public void Mult_To_Yourself(double cof)
        {
            x *= cof;
            y *= cof;

        }

        public void Vektor_ToString()
        {
            Console.WriteLine($"Vector ({x};{y})");
        }


        public double Vektor_Length()
        {
            double Length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return Length;
        }

        public double Scalar_Mult(Vektor vector)
        {
            double scolar_mult = vector.x * x + vector.y * y;

            return scolar_mult;
        }

        public double Cosinus(Vektor vector)
        {
            double cosinus = Scalar_Mult(vector) / (Vektor_Length() * vector.Vektor_Length());
            return cosinus;
        }

        public bool Equal_of_Vectors(Vektor vector)
        {
            return x == vector.x && y == vector.y;
        }




    }
   


}


