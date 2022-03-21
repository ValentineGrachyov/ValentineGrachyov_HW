using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HW_Task_2:CustomList
    {        
        public HW_Task_2(int a)
        {
            head = new Node(a);
        }
        public void El_Sum()
        {
            var headCopy = head;
            double sum = 0;

            while(headCopy.NextNode != null)
            {
                sum += headCopy.InfField;
                headCopy = headCopy.NextNode;
            }
            sum += headCopy.InfField;

            Console.WriteLine("Сумма всех элементов списка " + sum);
        }
    }
}
