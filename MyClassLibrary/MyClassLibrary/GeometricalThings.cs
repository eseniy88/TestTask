using System.Reflection.Metadata;

namespace MyClassLibrary
{
    public class GeometricalThings
    {
        public static double CalculateCircleAreaNow(double radius)
        {
            // площадь круга = два пи эр))
            return Math.PI * radius * radius;
        }
        public static double CalculateTriangleNow(double sideOne, double sideTwo, double sideThree)
        {
            //sideOne = sideOne < 0 ? -sideOne : sideOne;
            //sideTwo = sideTwo < 0 ? -sideTwo : sideTwo;
            //sideThree = sideThree < 0 ? -sideThree : sideThree;
            // для нахождения площади любого треугольника сначала требуется найти его полупериметр
            double semiperimeter = (sideOne + sideTwo + sideThree) / 2;
            // затем вычислить саму площадь
            return Math.Sqrt(semiperimeter * (semiperimeter - sideOne) * (semiperimeter - sideTwo) * (semiperimeter - sideThree));
        }
        public static double CalculateArea(object shape, params double[] parameters)
        {
            Type type = shape.GetType();     
            if (shape.GetType() == typeof(Circle))
            {
                // если передаваемый в функцию объект == Circle, то возвращаем результат соответствующего действия
                // (расчет площади круга)
                return CalculateCircleAreaNow(parameters[0]);
            }
            else if (shape.GetType() == typeof(Triangle))
            {
                // если передаваемый в функцию объект == Triangle, то возвращаем результат соответствующего действия
                // (расчет площади треугольника)
                return CalculateTriangleNow(parameters[0], parameters[1], parameters[2]);
            }
            //
            // в случае добавления новых фигур:
            // 1. добавить соответствующий ELSE-IF;
            // 2. добавить класс вновь создаваемой фигуры.
            // а пока выбрасываемся с исключением:
            else
            {
                throw new ArgumentException("неподдерживаемая на данный момент фигура!");
            }
        // метод, проверяющий является ли треугольник прямоугольным
        }
        public static bool IsRightAngledTriangle(double sideOne, double sideTwo, double sideThree)
        {
            double[] sides = { sideOne, sideTwo, sideThree };
            Array.Sort(sides);
            // возвращаем TRUE если треугольник прямоугольный
            return (sides[0] * sides[0]) + (sides[1] * sides[1]) == sides[2] * sides[2];
            
        }
    }
    public class Circle
    {
        // предположим, что при передаче числа в конструктор (положительного ли или отрицательного
        // радиус все равно будет положительный (по модулю)
        public double Radius
        {
            get { return Radius; }
            set { Radius = value > 0 ? value : -value; }
        }
    }
    public class Triangle
    {
        // по аналогии с Circle
        public double SideOne
        {
            get { return SideOne; }
            set { SideOne = value > 0 ? value : -value; }
        }
        public double SideTwo
        {
            get { return SideTwo; }
            set { SideTwo = value > 0 ? value : -value; }
        }
        public double SideThree
        {
            get { return SideThree; }
            set { SideThree = value > 0 ? value : -value; }
        }
    }
}

