using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work
{
    public class Node<T>
    {
        public T InfField;
        public Node<T> NextNode;

        public Node(T a)
        {
            InfField = a;
        }
    }
}
