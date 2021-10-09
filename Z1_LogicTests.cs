using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CheckTest1()
        {
            var s = "";
            var message = Logic.Check(s);
            Assert.AreEqual("Пустая строка", message);
        }
        [TestMethod()]
        public void CheckTest2()
        {
            var s = "asd";
            var message = Logic.Check(s);
            Assert.AreEqual("Вы ввели не правильное выражение", message);
        }
        [TestMethod()]
        public void CheckTest3()
        {
            var s = "123";
            var message = Logic.Check(s);
            Assert.AreEqual("Вы ввели не правильное значение", message);
        }
        [TestMethod()]
        public void CheckTest4()
        {
            var s = "12+13";
            var message = Logic.Check(s);
            Assert.AreEqual("Сумма = 25", message);
        }
        [TestMethod()]
        public void CheckTest5()
        {
            var s = "12-11";
            var message = Logic.Check(s);
            Assert.AreEqual("Сумма = 1", message);
        }
        [TestMethod()]
        public void CheckTest6()
        {
            var s = "12-13";
            var message = Logic.Check(s);
            Assert.AreEqual("Сумма = -1", message);
        }
        [TestMethod()]
        public void CheckTest7()
        {
            var s = "12-12";
            var message = Logic.Check(s);
            Assert.AreEqual("Сумма = 0", message);
        }
    }
}
