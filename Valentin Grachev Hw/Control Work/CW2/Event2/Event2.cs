using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work.CW2.Event2
{
    public class Event2
    {
        

        public EventHandler<Civilian> CivilianDelegate;

        public void CallContract(string name, int age)
        {
            var param = new Civilian(name, age);
            if (CivilianDelegate != null && age >= 18)
                CivilianDelegate(null, param);
            else
                Console.WriteLine($"Не удалось заключить контракт с {name}");
        }
    }
}
