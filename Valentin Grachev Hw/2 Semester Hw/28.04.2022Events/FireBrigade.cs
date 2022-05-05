using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework._2_Semester_Hw._28._04._2022Events
{
    public class FireBrigade 
    {
        public void CallFireBrigade(Object w, ElectricalStation e)
        {
            Console.WriteLine($"Температура на электростанции достигла критической точки {e.CrTemp}, вызываю пожарных!");

        }

        public void Subscribe(ElectricalStation e)
        { e.CallDelegate += CallFireBrigade; }
        public void UnSubscribe(ElectricalStation e) => e.CallDelegate -= CallFireBrigade;
    }
}
