using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework
{
    [TestClass]
    public class StackReaLizationTest
    {
        [TestMethod]
        public void Size_Test_Metod()
        {
            var s = new Stack<int>();
            s.Add(1);
            s.Add(1);
            s.Add(1);
            s.Add(1);
            Assert.AreEqual(s.Size(), 4);
        }

        [TestMethod]

        public void Is_Empty_Test_Method()
        {
            var s = new Stack<int>();
            Assert.AreEqual(s.IsEmpty(), false);
        }


        [TestMethod]

        public void Delete_Second_El_Test()
        {
            var s = new Stack<int>();            
            s.Add(1);
            s.Add(2);
            s.Add(3);
            s.Add(4);
            s.Add(5);
            s.DeleteSecondEl();

            Assert.AreEqual(s.Size(),4);
        }
        [TestMethod]
        public void Delete_Prev_El_Test()
        {
            var s = new Stack<int>();
            s.Add(1);
            s.Add(2);
            s.Add(3);
            s.Add(4);
            s.Add(5);
            s.DeletePrevElement();

            Assert.AreEqual(s.ToString(), new string[] { "5","4","3","1"});
        }
        [TestMethod]
        public void Bust_Test()
        {
            var s = new Stack<int>();
            s.Add(1);
            s.Add(2);
            s.Add(3);
            s.Add(4);
            s.Add(5);

            Assert.AreEqual(s.Size(), 4);
        }
        [TestMethod]
        public void Peek_Test()
        {
            var s = new Stack<int>();
            s.Add(1);
            s.Add(2);
            s.Add(3);
            s.Add(4);
            s.Add(5);
            s.Peek(1);

            Assert.AreEqual(s.Size(), 4);
        }
    }
}
