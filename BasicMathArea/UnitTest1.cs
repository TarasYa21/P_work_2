using System;
using Xunit;
using System.IO;
using P_work_2;

namespace BasicMathArea
{
    public class UnitTest1
    {
        [Fact]
        public void PlusMathArea_3and5()
        {
            // Значення які будуть передані в метод
                int a = 3;
                int b = 5;
            //очікуваний результат
                int expected = 8;
            //виклик метода
                Class1 g = new Class1();
                int actual = g.PlusMathArea(a, b);
                Assert.Equal(expected, actual);
        }
        [Fact]
        public void DeductionMathArea_3and5()
        {
            // Значення які будуть передані в метод
            int a = 3;
            int b = 5;
            //очікуваний результат
            int expected = -2;
            //виклик метода
            Class1 g = new Class1();
            int actual = g.DeductionMathArea(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
