using NUnit.Framework;
using TasksLibrary;

namespace Tests
{
    [TestFixture]
    public class GCDTests
    {
        [TestCase(10, 15, 20, ExpectedResult = 5)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(0, 140, 20, -50, 13, ExpectedResult = 1)]
        [TestCase(int.MaxValue, int.MinValue, ExpectedResult = 1)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        [TestCase(2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, ExpectedResult = 2)]
        [TestCase(3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 43, 53, 59, ExpectedResult = 1)]
        public int CheckFindingGCDByEuclid(params int[] numbers)
        {
            double workTime;
            return EuclidGreatestCommonDivisor.GetGCD(out workTime, numbers);
        }

        [TestCase(10, 15, 20, ExpectedResult = 5)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(0, 140, 20, -50, 13, ExpectedResult = 1)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        [TestCase(2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, ExpectedResult = 2)]
        [TestCase(3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 43, 53, 59, ExpectedResult = 1)]
        public int CheckFindingGCDByStain(params int[] numbers)
        {
            double workTime;
            return StainGreatestCommonDivisor.GetGCD(out workTime, numbers);
        }
    }
}
