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
            // �������� �� ������ ������� � �����
                int a = 3;
                int b = 5;
            //���������� ���������
                int expected = 8;
            //������ ������
                Class1 g = new Class1();
                int actual = g.PlusMathArea(a, b);
                Assert.Equal(expected, actual);
        }
        [Fact]
        public void DeductionMathArea_3and5()
        {
            // �������� �� ������ ������� � �����
            int a = 3;
            int b = 5;
            //���������� ���������
            int expected = -2;
            //������ ������
            Class1 g = new Class1();
            int actual = g.DeductionMathArea(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
