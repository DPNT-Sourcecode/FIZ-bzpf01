using BeFaster.App.Solutions.SUM;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        [Test]
        public void ComputeSumFirstBelow()
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => SumSolution.Sum(-1, 100));
        }

        [Test]
        public void ComputeSumFirstAbove()
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => SumSolution.Sum(101, 100));
        }

        [Test]
        public void ComputeSumSecondBelow()
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => SumSolution.Sum(0, -1));
        }

        [Test]
        public void ComputeSumSecondAbove()
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => SumSolution.Sum(0, 101));
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        public int ComputeSumBothMinimun(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(100, 100, ExpectedResult = 10000)]
        public int ComputeSumBothMaximum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(3, 9, ExpectedResult = 27)]
        public int ComputeSumBothMiddle(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }
    }
}
