using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework._2_Semester_Hw._28._02___7
{
    public class GenericNode<T>
    {
        public T InfField;
        public GenericNode<T> NextNode;

        public GenericNode(T a)
        {
            InfField = a;
        }
    }
}
