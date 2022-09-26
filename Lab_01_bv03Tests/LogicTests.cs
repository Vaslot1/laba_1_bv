using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_01_bv03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_bv03.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void Reverse_test()
        {
            var str = "wow papa mama,sun";
            var reversed = Logic.Reverse_Str(str);
            Assert.AreEqual("sun mama papa wow", reversed);
        }
    }
}