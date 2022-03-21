using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD
{
    public class Node
    {
        public int InfField;
        public Node NextNode;

        public Node(int a)
        {
            InfField = a;
        }
    }
}
