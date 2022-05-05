using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work.CW2.Event2
{
    public class Contract
    {
        public int Id { get; set; }

        public Contract(int id)
        {
            Id = id;
        }
        public void WrContract(Object w, Civilian c)
        {
            Console.WriteLine($"Договор {Id} был подписан с {c.Name}");
        }

        public void Subscribe(Event2 c)
        {
            c.CivilianDelegate += WrContract;
        }
        public void UnSubscribe(Event2 c)
        {
            c.CivilianDelegate -= WrContract;
        }
    }
}
