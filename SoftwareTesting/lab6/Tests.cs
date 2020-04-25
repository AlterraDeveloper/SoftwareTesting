using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SoftwareTesting.lab6
{
    [TestFixture]
    public class Tests
    {
        public int[] BubbleSort(int[] collection, int? outerCounter)
        {
            var nums = collection.ToArray();
            var cycleCounter = outerCounter ?? nums.Length;

            for (var i = 0; i < cycleCounter; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j]) continue;

                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }

            return nums;
        }

        [Test]
        [TestCase(new[] { 10, 7, 4, 1, 6, 8, 5, 14 }, 0, ExpectedResult = new[] { 10, 7, 4, 1, 6, 8, 5, 14 }, Description = "Пропустить внутренний цикл полностью")]
        [TestCase(new[] { 10, 7, 4, 1, 6, 8, 5, 14 }, 1, ExpectedResult = new[] { 1, 10, 7, 4, 6, 8, 5, 14 }, Description = "Внутренний цикл. Только 1 проход")]
        [TestCase(new[] { 10, 7, 4, 1, 6, 8, 5, 14 }, 2, ExpectedResult = new[] { 1, 4, 10, 7, 6, 8, 5, 14 }, Description = "Внутренний цикл. Только 2 прохода")]
        [TestCase(new[] { 10, 7, 4, 1, 6, 8, 5, 14 }, 3, ExpectedResult = new[] { 1, 4, 5, 10, 7, 8, 6, 14 }, Description = "m проходов внутреннего цикла, где m < n. m = 3; n = 8")]
        [TestCase(new[] { 10, 7, 4, 1, 6, 8, 5, 14 }, 7, ExpectedResult = new[] { 1, 4, 5, 6, 7, 8, 10, 14 }, Description = "n-1 проходов внутреннего цикла. n = 8")]
        [TestCase(new[] { 10, 7, 4, 1, 6, 8, 5, 14 }, 8, ExpectedResult = new[] { 1, 4, 5, 6, 7, 8, 10, 14 }, Description = "n проходов внутреннего цикла.n = 8")]
        [TestCase(new[] { 10, 7, 4, 1, 6, 8, 5, 14 }, 9, ExpectedResult = new[] { 1, 4, 5, 6, 7, 8, 10, 14 }, Description = "n+1 проходов внутреннего цикла.n = 8")]
        public int[] BubbleSortTest(int[] collection, int? outerCounter)
        {
            return BubbleSort(collection, outerCounter);
        }
    }
}