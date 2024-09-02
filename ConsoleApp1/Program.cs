using System;

namespace GeometryLibrary
{
    public class Geometry
    {
        // Метод для вычисления площади круга по радиусу
        public double CalculateArea(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным");

            return Math.PI * Math.Pow(radius, 2);
        }

        // Метод для вычисления площади треугольника по трем сторонам
        public double CalculateArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Сумма двух сторон треугольника должна быть > третьей стороны.");

            double halfP = (a + b + c) / 2;
            return Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
        }
    }
}