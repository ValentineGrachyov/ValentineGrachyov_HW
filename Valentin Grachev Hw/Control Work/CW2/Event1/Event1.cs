using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work.CW2.Event1
{
    public  class Event1
    {
        private int childCount;
        public int ChildCount
        {
            get { return childCount; }            
        }

        public Event1(int childNum)
        {
            childCount = childNum;
        }

        public EventHandler<Child> WriteAnnDelegate;

        public void WriteAnn(Object w,string p_name, string[] name,  bool isAdult )
        {
            var param = new Child(p_name, name, isAdult);
            if (WriteAnnDelegate != null && ChildCount > 2)
                WriteAnnDelegate(null, param);
            else
                Console.WriteLine("Не удалось заключить договор с " +p_name);
        }

        
    }
}
