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

        // Метод для первого расширенного задания.
        public void DeletePenultimate()
        {
            var headCopy = head;
            var middleEl = headCopy.NextNode;
            var next = middleEl.NextNode;

            while (next.NextNode != null)
            {
                next = next.NextNode;
                middleEl = middleEl.NextNode;
                headCopy = headCopy.NextNode;
            }
            headCopy.NextNode = middleEl.NextNode;
        }

        // Метод для второго расширенного задания.
        public void DeleteCorrectNum(int n)
        {
            var headCopy = head;
            var next = headCopy.NextNode;

            while (next.InfField != n)
            {
                headCopy = headCopy.NextNode;
                next = next.NextNode;
                if (next.NextNode == null)
                {
                    break;
                }
            }

            headCopy.NextNode = next.NextNode;
        }

        // Метод для третьего расширенного задания.
        public void Delete_All_Correct_Elements(int k)
        {
            var headCopy = head;

            if (headCopy.NextNode != null)
            {
                while (headCopy.InfField != k && headCopy.NextNode != null)
                {
                    headCopy = headCopy.NextNode;
                }
                if (headCopy.NextNode == null) { }
                else
                {
                    DeleteEl(k);
                    Delete_All_Correct_Elements(k);
                }
            }
        }
        public void DeleteEl(int n)
        {
            var headCopy = head;
            var middleEl = headCopy.NextNode;
            var next = middleEl.NextNode;

            while (middleEl.InfField != n)
            {
                if (next.NextNode == null)
                {
                    next.NextNode = headCopy.NextNode;
                }
                headCopy = headCopy.NextNode;
                middleEl = middleEl.NextNode;
                next = next.NextNode;
            }

            headCopy.NextNode = middleEl.NextNode;
        }

        // Метод для четвертого расширенного задания.

        public void Add_Near_Element(int m, int k)
        {
            var headcopy = head;
            
            while(headcopy.InfField != k)
            {
                headcopy = headcopy.NextNode;
            }
            AddEl_Before(m, k);
            AddEl_After(m, k);
        }
        public void AddEl_After(int a, int k)
        {
            var headCopy = head;

            while (headCopy.InfField != k)
            {
                headCopy = headCopy.NextNode;

            }

            var newNode = new Node(a);

            if (headCopy.NextNode != null)
            {
                newNode.NextNode = headCopy.NextNode;
            }

            headCopy.NextNode = newNode;
        }
        public void AddEl_Before(int a, int k)
        {
            var headCopy = head;
            var next = headCopy.NextNode;

            while (next.InfField != k)
            {
                headCopy = headCopy.NextNode;
                next = next.NextNode;
            }

            var newNode = new Node(a);

            if (headCopy.NextNode != null)
            {
                newNode.NextNode = headCopy.NextNode;
            }

            headCopy.NextNode = newNode;

        }



        // Основное дз.
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

            result.Append(headCopy.InfField.ToString() + " ");
            return result.ToString();

        }
        public void WriteToConsole()
        {
            Console.WriteLine(ToString());
        }
    }
}
