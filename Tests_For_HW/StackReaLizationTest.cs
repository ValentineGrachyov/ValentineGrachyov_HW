using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework.Control_Work
{
    [TestClass]
    public class StackReaLizationTest
    {
        [TestMethod]
        public void Size_Test_Metod()
        {
            var s = new StackRealization<int>();
            s.AddEl(1);
            s.AddEl(1);
            s.AddEl(1);
            s.AddEl(1);
            Assert.AreEqual(s.Size(), 4);
        }

        [TestMethod]

        public void Is_Empty_Test_Method()
        {
            var s = new StackRealization<int>();
            Assert.AreEqual(s.IsEmpty(), false);
        }


        [TestMethod]

        public void Delete_Second_El_Test()
        {
            var s = new StackRealization<int>();            
            s.AddEl(1);
            s.AddEl(2);
            s.AddEl(3);
            s.AddEl(4);
            s.AddEl(5);
            s.DeleteSecondEl();

            Assert.AreEqual(s.Size(),4);
        }
        [TestMethod]
        public void Delete_Prev_El_Test()
        {
            var s = new StackRealization<int>();
            s.Add(1);
            s.Add(2);
            s.Add(3);
            s.Add(4);
            s.Add(5);
            s.DeletePenultimateEl();
            var s1 = new StackRealization<int>();
            s1.Add(1);
            s1.Add(3);
            s1.Add(4);
            s1.Add(5);

            Assert.AreEqual(s.ToString(), s1.ToString());
        }
        [TestMethod]
        public void Bust_Test()
        {
            var s = new StackRealization<int>();
            s.AddEl(1);
            s.AddEl(2);
            s.AddEl(3);
            s.AddEl(4);
            s.AddEl(5);
            var s1 = new StackRealization<int>();
            s1.AddEl(1);
            s1.AddEl(2);
            s1.AddEl(3);
            s1.AddEl(4);
            s1.AddEl(5);

            Assert.AreEqual(s.ToString(), s1.ToString());
        }      
        
    }
}
