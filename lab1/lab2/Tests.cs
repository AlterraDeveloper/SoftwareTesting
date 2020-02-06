using System;
using NUnit.Framework;

namespace SoftwareTesting.lab2
{
    [TestFixture]
    public class Tests
    {
        public int? FibonachiSequenceRecursive(int seqNumber)
        {
            if (seqNumber <= 0) return null;
            if (seqNumber == 1 || seqNumber == 2) return 1;

            return FibonachiSequenceRecursive(seqNumber - 1) + FibonachiSequenceRecursive(seqNumber - 2);
        }

        public int? FibonachiSequenceIterative(int seqNumber)
        {
            if (seqNumber <= 0) return null;
            if (seqNumber == 1 || seqNumber == 2) return 1;
            
            var answer = 0;
            int first = 1;
            int second = 1;

            for (int i = 0; i < seqNumber - 2; i++)
            {
                answer = first + second;
                first = second;
                second = answer;
            }

            return answer;

        }

        [Test]
        [TestCase(-50 , ExpectedResult = null)]
        [TestCase(-3 , ExpectedResult = null)]
        [TestCase(0 , ExpectedResult = null)]
        [TestCase(1 , ExpectedResult = 1)]
        [TestCase(2 , ExpectedResult = 1)]
        [TestCase(10 , ExpectedResult = 55)]
        [TestCase(20 , ExpectedResult = 6765)]
        public int? TestFibonachiSequence(int seqNum)
        {
            return FibonachiSequenceIterative(seqNum);
        }
    }
}