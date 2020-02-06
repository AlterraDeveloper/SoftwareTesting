using System;
using NUnit.Framework;

namespace lab1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(1,-2,-3,ExpectedResult = new double[]{ 3,-1})]
        [TestCase(-1,-2,15,ExpectedResult = new double[]{ -5,3})]
        [TestCase(6,15,0,ExpectedResult = new double[]{ 0,-2.5})]
        [TestCase(1,12,36,ExpectedResult = new double[]{ -6})]
        [TestCase(8,0,0,ExpectedResult = new double[]{ 0 })]
        [TestCase(0, 0, 0, ExpectedResult = null)]//нет корней, т.к. уравнение не квадратное
        [TestCase(0, 8, 8, ExpectedResult = null)]//нет корней, т.к. уравнение не квадратное
        [TestCase(5,0,30,ExpectedResult = null)]// нет корней, т.к. ответ в области комплексных чисел 
        [TestCase(5,3,7,ExpectedResult = null)]// нет корней, т.к. ответ в области комплексных чисел
        public double[] TestEquation(double a, double b, double c)
        {
            return FindRootsOfSquareEquation(a, b, c);
        }

        public static double[] FindRootsOfSquareEquation(double a, double b, double c)
        {
            double[] answer = null;

            if (a != 0)
            {
                var discriminant = b * b - 4.0 * a * c;

                if (discriminant == 0)
                {
                    answer = new[] { (-b / 2.0 * a) };
                }
                else if (discriminant > 0)
                {
                    answer = new[]
                    {
                        (-b + Math.Sqrt(discriminant))/(2.0*a),
                        (-b - Math.Sqrt(discriminant))/(2.0*a)
                    };
                }
            }

            return answer;
        }
    }
}