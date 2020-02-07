using System;
using SoftwareTesting.lab2;
using Tests = SoftwareTesting.lab4.Tests;

namespace SoftwareTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Tests().BinarySearch(new double[] { -59, -45, -30, -8, 0, 1, 4, 48, 58, 78, 119 }, -200));
            Console.ReadKey();
        }
    }
}
