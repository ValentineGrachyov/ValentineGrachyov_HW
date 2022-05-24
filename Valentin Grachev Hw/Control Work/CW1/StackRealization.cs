using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework.Control_Work
{
    public class StackRealization<T>  : IEnumerator<T>
    {
        private Node<T> head;

        private int position = 0;

        public T Current => head.InfField;

        object IEnumerator.Current
        {
            get
            {
                if(position == 0 || position > Size())
                {  throw new ArgumentException("Нет аргумента"); }
                
                return head.InfField;
            }
        }

        public StackRealization() { }

        public StackRealization(T a)
        {
            head = new Node<T>(a);
        }

        

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public int Size()
        {
            int count = 0;
            while(head != null)
            {
                head = head.NextNode;
                count++;
            }
            return count;

        }

        public void AddEl(T a)
        {
            var newNode = new Node<T>(a);            
            if (head == null)
            { Console.WriteLine("Стек пустой"); }
            newNode.NextNode = head;
            head = newNode;      
        }

        public void DeleteSecondEl()
        {
            var headCopy = head;
            headCopy.NextNode = headCopy.NextNode.NextNode;   
        }

        public void DeletePenultimateEl()
        {
            var headCopy = head;
            var nextEl = headCopy.NextNode.NextNode;

            while(nextEl.NextNode != null)
            {
                headCopy = headCopy.NextNode;
                nextEl = nextEl.NextNode;
                
            }
            headCopy.NextNode = nextEl;
            
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (head == null)
            {

                return "Список пуст";
            }
            var headCopy = head;
            while (headCopy.NextNode != null)
            {
                result.Append(headCopy.InfField.ToString() + "\n");
                headCopy = headCopy.NextNode;
            }

            result.Append(headCopy.InfField.ToString() + "");
            return result.ToString();

        }

        public void WriteToConsole()
        {
            Console.WriteLine(ToString());
        }

        public void Dispose()
        {
            head = null;
        }

        public bool MoveNext()
        {
            if(position != Size())
            {
                position++;
                return true;
            }
            else 
                return false;
        }

        public void Reset()
        {
            position = 0;

        }
    }



}

    

