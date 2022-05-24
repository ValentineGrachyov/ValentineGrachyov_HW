using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework._2_Semester_Hw._28._02___7
{
    public  class LinkedList<T>
    {       
        protected GenericNode<T> head;

        public LinkedList() { }

        public LinkedList(T a)
        {
            head = new GenericNode<T>(a);
        }

        public void Add(T a)
        {
            var newNode = new GenericNode<T>(a);
            
            if (head == null)
                head = newNode;

            var headCopy = head;

            while (headCopy.NextNode != null)
            {
                headCopy = headCopy.NextNode;
            }
            headCopy.NextNode = newNode;

        }

        public void ReverseList(params T[] arr)
        {
            foreach(var item in arr)
            {
                Add(item);
            }
            var headCopy = head;
            Stack<T> st = new Stack<T>();
            for (GenericNode<T> i = null; i != headCopy;headCopy = headCopy.NextNode)
            {
                st.Push(headCopy.InfField);
            }
            var newNode = new GenericNode<T>(st.Pop());
            head = newNode;
            
            while(st.Count > 0)
            {
                Add(st.Pop());
            }
            
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
                result.Append(headCopy.InfField.ToString() + " ");
                headCopy = headCopy.NextNode;
            }

            result.Append(headCopy.InfField.ToString() + " ");
            return result.ToString();

        }
        public void WriteToConsole()
        {
            Console.WriteLine(ToString());
        }
    }
}
