using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SoftwareTesting.lab6
{
    [TestFixture]
    public class Tests
    {
        public void BubbleSort(int[] collection)
        {
            var nums = collection.ToArray();
            
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] <= nums[j]) continue;

                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }

        [Test]
        [TestCase(new []{10,7,4,1,7,8,5,14})]
        public void BubbleSortTest(int[] collection)
        {
            BubbleSort(collection);
            CollectionAssert.AreEqual(collection, new[] { 1, 4, 5, 6, 7, 8, 10, 14 });
        }
    }
}