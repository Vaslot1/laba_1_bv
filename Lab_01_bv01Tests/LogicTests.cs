using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_01;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void Rubl_and_Kopeika_Test()
        {
            var n = 121;
            var message = Logic.Convert_Money(n);
            Assert.AreEqual("1 Рубль 21 Копейка", message);
        }
        [TestMethod()]
        public void Rublya_and_Kopeiki_Test()
        {
            var n = 3374;
            var message = Logic.Convert_Money(n);
            Assert.AreEqual("33 Рубля 74 Копейки", message);
        }
        [TestMethod()]
        public void Rublei_and_Kopeek_Test()
        {
            var n = 6687;
            var message = Logic.Convert_Money(n);
            Assert.AreEqual("66 Рублей 87 Копеек", message);
        }
        [TestMethod()]
        public void Without_Rub_Test()
        {
            var n = 8;
            var message = Logic.Convert_Money(n);
            Assert.AreEqual("8 Копеек", message);
        }
        [TestMethod()]
        public void Eror_Test()
        {
            var n = 93199;
            var message = Logic.Convert_Money(n);
            Assert.AreEqual("Ошибка", message);
        }
    }
}