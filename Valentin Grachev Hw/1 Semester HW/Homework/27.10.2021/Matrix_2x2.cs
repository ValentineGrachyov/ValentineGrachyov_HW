using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Matrix_2x2
    {
        public double[,] Matrix = new double[2, 2];
        public Matrix_2x2(double num_11,double num_12, double num_21, double num_22 )
        {
            Matrix[0, 0] = num_11;
            Matrix[0, 1] = num_12;
            Matrix[1, 0] = num_21;
            Matrix[1, 1] = num_22;

        }

        public double Det()
        {
            return  Matrix[0, 0] * Matrix[1, 1] - Matrix[0, 1] * Matrix[1, 0];
        }
        public void Mult(Matrix_2x2 input)
        {
            double[,] temp = new double[2, 2];
            temp[0, 0] =Matrix[0,0]*input.Matrix[0,0]+ Matrix[0, 1] * input.Matrix[1,0];
            temp[0, 1] = Matrix[0, 0] * input.Matrix[0, 1] + Matrix[0, 1] * input.Matrix[1, 1];
            temp[1, 0] = Matrix[1, 0] * input.Matrix[0, 0] + Matrix[1, 1] * input.Matrix[1, 0];
            temp[1, 1] = Matrix[1, 0] * input.Matrix[0, 1] + Matrix[1, 1] * input.Matrix[1, 1];

            Matrix = temp;

        }

        public void Print()
        {
            Console.WriteLine(Det());
            Console.WriteLine($"{Matrix[0, 0]} {Matrix[0, 1]}\n{Matrix[1, 0]} {Matrix[1, 1]} ");
            
        }
    }
}
