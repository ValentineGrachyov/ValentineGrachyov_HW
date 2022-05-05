using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work.CW2.Event1
{
    public  class Contract : EventArgs  
    {
        public int Id { get; set; }

        public Contract(int id)
        {
            Id = id;
        }

        public void WriteAContract(Object w,Child c)
        {
            Console.WriteLine($"Контракт под номером {Id} был заключен с {c.P_Name}");
        }

        public void Subscribe(Event1 w)
        {
            w.WriteAnnDelegate += WriteAContract;
        }

        public void UnSubscribe(Event1 w)
        {
            w.WriteAnnDelegate -= WriteAContract;
        }
    }
}
