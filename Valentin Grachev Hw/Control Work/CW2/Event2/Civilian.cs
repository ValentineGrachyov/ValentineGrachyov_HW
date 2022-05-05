using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work.CW2.Event2
{
    public class Civilian : EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Civilian(string name, int age)
        {
            Name = name;
            Age = age; 
        }

       

    }
}
