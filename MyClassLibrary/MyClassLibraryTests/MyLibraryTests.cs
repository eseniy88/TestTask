using MyClassLibrary;
using Xunit.Sdk;
namespace MyClassLibraryTests
{
    public class MyLibraryTests
    {
        [Fact]
        public void IsRightAngledTriangleTest()
        {
            bool actualResult = GeometricalThings.IsRightAngledTriangle(1.0, 1.0, Math.Sqrt(2.0));

            Assert.True(actualResult);
            // failure... ������ ����� ��� ������� �������� ���������� ����������� � ��� �� ���������
            // "������" ���������� ��������� ��� �� TRUE. 
            // ��������� �������� Equal ������ ����� ������������ ������ ���� ��������� ��� ��������
            // ���������� ����� � ��������� �������. ���� ����� ���� �� ����� ������������ ��� decimal,
            // �.�. �� �� ����� ��������.
        }
        [Fact]
        public void ClaculateAreaTestCircle()
        {
            Circle myCircle = new Circle();
            double result = GeometricalThings.CalculateArea(myCircle, 10.0);
            Assert.Equal(Math.PI * 10.0 * 10.0, result);
            // done
        }
        [Fact]
        public void ClaculateAreaTestTriangle()
        {
            Triangle myTriangle = new Triangle();
            double result = GeometricalThings.CalculateArea(myTriangle, 1, 1, 1);

            double semiperimeter = (1.0 + 1.0 + 1.0) / 2;
            double etalon = Math.Sqrt(semiperimeter * (semiperimeter - 1.0) * (semiperimeter - 1.0) * (semiperimeter - 1.0));
            Assert.Equal(etalon, result);
            // done
        }
        [Fact]
        public void CalculateCircleAreaNowTest()
        {
            double result = GeometricalThings.CalculateCircleAreaNow(10.0);
            Assert.Equal(Math.PI * 10.0 * 10.0, result);
            // done
        }
    }
}