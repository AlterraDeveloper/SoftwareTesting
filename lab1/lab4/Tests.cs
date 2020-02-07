using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using NUnit.Framework;

namespace SoftwareTesting.lab4
{
    [TestFixture]
    public class Tests
    {
        public int BinarySearch(IEnumerable<double> collection, double key)
        {
            if (collection == null) return -1;

            var array = collection as double[] ?? collection.ToArray();

            if (array.Length == 0 || !IsSorted(array)) return -1;

            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                var current = (left + right) / 2;

                if (array[current] == key)
                {
                    return current;
                }

                if (array[current] > key)
                {
                    right = current-1;
                }
                else if (array[current] < key)
                {
                    left = current+1;
                }
            }

            return -1;
        }

        private bool IsSorted(IEnumerable<double> collection) 
        {
            var array = collection as double[] ??collection.ToArray();
            for (int i = 0; i < array.Length -1; i++)
            {
                if (array[i] > array[i+1]) return false;
            }

            return true;
        }

        [Test]
        [TestCase(new double[]{ -59,-45,-30,-8,0,1,4,48,58,78,119 },-8,ExpectedResult = 3, Description = "Массив сортирован (нечетное число элементов), ключ есть в массиве")]
        [TestCase(new double[]{ -59,-45,-30,-8,1,4,48,58,78,119 },-8,ExpectedResult = 3, Description = "Массив сортирован(четное число элементов), ключ есть в массиве")]
        [TestCase(new double[]{ -59,-45,-30,-8,0,1,4,48,58,78,119 },100,ExpectedResult = -1, Description = "Массив сортирован (нечетное число элементов), ключа нет в массиве")]
        [TestCase(new double[]{ -59,-45,-30,-8,0,1,4,48,78,119 },100,ExpectedResult = -1, Description = "Массив сортирован (четное число элементов), ключа нет в массиве")]
        [TestCase(new double[]{ -59,-45,-45,-8,0,1,4,12,58,78,78,119 },78,ExpectedResult = 10, Description = "Массив сортирован и имеет дубликаты, ключ есть в массиве")]
        [TestCase(new double[]{ 5,3,7,-8,12,15,489,41,-59,0 },-8,ExpectedResult = -1,Description = "Массив не сортирован")]
        [TestCase(new double[]{ 45 },45,ExpectedResult = 0, Description = "Массив состоит из одного элемента, ключ есть в массиве")]
        [TestCase(new double[]{ 80 },45,ExpectedResult = -1, Description = "Массив состоит из одного элемента, ключа нет в массиве")]
        [TestCase(new double[]{},-8,ExpectedResult = -1, Description = "Пустой массив")]
        [TestCase(null,default(double),ExpectedResult = -1, Description = "Массива не существует")]
        public int BinarySearchTest(IEnumerable<double> collection, double item)
        {
            return BinarySearch(collection, item);
        }
    }
}