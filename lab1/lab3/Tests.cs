using NUnit.Framework;

namespace SoftwareTesting.lab3
{
    [TestFixture]
    public class Tests
    {
        [Test]
        //[TestCase(1,-2,-3)]
        //[TestCase(8, 0, 0)]
        [TestCase(6, 15, 0)]
        public void TestEquation(double a, double b, double c)
        {
            var result = lab1.Tests.FindRootsOfSquareEquation(a, b, c);
            //Assert.AreEqual(new double[]{3,-1},result );
            //Assert.AreEqual(new double[]{0},result );
            CollectionAssert.AreEqual(new[]{0,-2.5},result);
        }
    }
}