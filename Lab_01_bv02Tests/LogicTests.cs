using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_01_bv02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_bv02.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void Result_minmax_4diff_test()
        {
            Result result = new Result { min_1 = 1, min_2 = 2, max_2 = 3, max_1 = 4 };
            var message = Logic.Min_Max(result);
            Assert.AreEqual("Первый минимум = 1 Второй минимум = 2 Первый максимум = 4 Второй максимум = 3", message);
        }
        [TestMethod()]
        public void Result_minmax_2diff_test()
        {
            Result result = new Result { min_1 = 1, min_2 = 2, max_2 = 2, max_1 = 4 };
            var message = Logic.Min_Max(result);
            Assert.AreEqual("Минимум = 1 Максимум = 4", message);
        }
        [TestMethod()]
        public void Result_minmax_0diff_test()
        {
            Result result = new Result { min_1 = 1, min_2 = 1, max_2 = 1, max_1 = 1 };
            var message = Logic.Min_Max(result);
            Assert.AreEqual("Все элементы одинаковые", message);
        }
    }
}

