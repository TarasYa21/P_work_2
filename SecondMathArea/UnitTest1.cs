using Microsoft.VisualStudio.TestTools.UnitTesting;
using P_work_2;
using System;

namespace SecondMathArea
{
    [TestClass]
    public class Class2Test
    {
        [TestMethod]
        public void MultiplicationMathArea_3and5()
        {
            // Значення які будуть передані в метод
            int a = 3;
            int b = 5;
            //очікуваний результат
            int expected = 15;
            //виклик метода
            Class2 g = new Class2();
            int actual = g.MultiplicationMathArea(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivisionMathArea_3and5()
        {
            // Значення які будуть передані в метод
            double a = 3;
            double b = 5;
            //очікуваний результат
            double expected = 0.6;
            //виклик метода
            Class2 g = new Class2();
            double actual = g.DivisionMathArea(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
