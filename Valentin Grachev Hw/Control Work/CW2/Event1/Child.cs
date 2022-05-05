using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Control_Work.CW2.Event1
{
    public class Child
    {
        public string P_Name { get; set; }
        public string[] Name { get; set; }
        public bool IsAdult { get; set; }

        public Child(string p_name, string[] name,  bool isAdult)
        {
            P_Name = p_name;
            Name = name;
            IsAdult = isAdult;
        }

    }
}
