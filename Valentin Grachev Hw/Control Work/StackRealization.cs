using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework
{
    public class Stack<T> : IComparable<Stack<T>> , IEnumerable
    {
        List<T> stack = new List<T>();
        private int count = 0;
        private int max = int.MaxValue;


        public int CompareTo(Stack<T> other)
        {
            if (other == null) return 1;

            return max.CompareTo(other.max);
        }

        public void Add(T a)
        {
            stack.Add(a);
            count++;
        }

        public void DeleteSecondEl()
        {
            stack.RemoveAt(1);
            count--;
        }

        public void DeletePrevElement()
        {
            stack.RemoveAt(stack.Count - 2);
            count--;
        }

        public void Peek()
        {
            if (count == 0)
                throw new Exception("Пустой стек");

            stack.RemoveAt(stack.Count-count  );
            count--;
        }

        public int Size()
        {
            return count;
        }

        public bool IsEmpty()
        {
            if (count == 0)
            {
                return false;
            }                
            return true;
        }

        public void Bust()
        {
            for(int i = stack.Count-1; i >=0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public Stack<T> GetEnumerator()
        {
            return new Stack<T>();
        }
    }

    
}
