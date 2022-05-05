using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework._2_Semester_Hw._28._04._2022Events
{
    public class MCHS
    {
        public void CallPolice(Object w, ElectricalStation e)
        {
            Console.WriteLine($"Температура на электростанции достигла критической точки {e.CrTemp}, вызываю МЧС!");

        }

        public void Subscribe(ElectricalStation e)
        { e.CallDelegate += CallPolice; }
        public void UnSubscribe(ElectricalStation e) => e.CallDelegate -= CallPolice;
        
    }
}
