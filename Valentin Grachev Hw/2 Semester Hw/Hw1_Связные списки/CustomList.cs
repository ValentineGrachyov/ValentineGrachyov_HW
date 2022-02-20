using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class CustomList
    {

        private Node head;

        public CustomList() { }

        public CustomList(int a)
        {
            head = new Node(a);
        }

        public void AddToHead(int a)
        {
            var newNode = new Node(a);

            newNode.NextNode = head;
            head = newNode;


        }

        public void DeleteFirst()
        {
            var headCopy = head;

            headCopy = head.NextNode;

            head = headCopy;
        }

        public void DeleteLast()
        {

            var headCopy = head;
            var previous = head;

            while (headCopy.NextNode != null)
            {
                previous = headCopy;
                if (headCopy.NextNode != null)
                {
                    headCopy = headCopy.NextNode;
                   
                }
                
            }
            previous.NextNode = null;

            headCopy = previous;

            

           
            

            
        }

        public void DeletePosition(int a)
        {
            var copyhead = head;
            var previous = head;
            
            for(int i = 1; i<a; i++)
            {
                if (copyhead == null)
                    throw new Exception("Лист недостаточной длины");
                else
                {
                    copyhead = copyhead.NextNode;                   
                }

            }

            // Здесь идет переход предыдущего элемента.
            for(int i = 0; i<a-2;i++)
            {
                previous = previous.NextNode;
            }
            previous.NextNode = copyhead.NextNode;
            
            

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
            return result.ToString();

        }

        public void WriteToConsole()
        {
            Console.WriteLine(ToString());
        }

    }
}
