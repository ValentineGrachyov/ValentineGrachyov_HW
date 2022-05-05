using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework._2_Semester_Hw
{
    public class CustomList
    {

        protected Node head;

        public CustomList() { }

        public CustomList(int a)
        {
            head = new Node(a);
        }

        // Метод для удаления предыдущего значения списка.
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

        // Метод для  удаления конкретного значения списка.
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

        // Метод для удаления всех конкретных элементов в листе.
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

        // Метод для удаления элемента.
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

        /// <summary>
        /// Метод для добавления элемента до и после конкретного значения.
        /// </summary>
        /// <param name="m"> Элемент, который нужно добавить</param>
        /// <param name="k"> Элемент, возле которого добавляем</param>

        public void Add_Near_Element(int m, int k)
        {
            var headcopy = head;

            while (headcopy.InfField != k)
            {
                headcopy = headcopy.NextNode;
            }
            
             void AddEl_After(int a, int l) // a- элемент для добавления l- элемент вокруг которого добавляем.
            {
                var headCopy = head;

                while (headCopy.InfField != l)
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
             void AddEl_Before(int a, int l)
            {
                var headCopy = head;
                var next = headCopy.NextNode;

                while (next.InfField != l)
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
            AddEl_Before(m, k);
            AddEl_After(m, k);
        }
        

        // Сумма всех элементов.
        public void El_Sum()
        {
            var headCopy = head;
            double sum = 0;

            while (headCopy.NextNode != null)
            {
                sum += headCopy.InfField;
                headCopy = headCopy.NextNode;
            }
            sum += headCopy.InfField;

            Console.WriteLine("Сумма всех элементов списка " + sum);
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

            for (int i = 1; i < a; i++)
            {
                if (copyhead == null)
                    throw new Exception("Лист недостаточной длины");
                else
                {
                    copyhead = copyhead.NextNode;
                }

            }

            
            for (int i = 0; i < a - 2; i++)
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
