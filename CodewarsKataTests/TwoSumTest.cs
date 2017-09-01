using System;
using System.Linq;
using CodewarsKata;
using NUnit.Framework;

namespace CodewarsKataTests
{
    [TestFixture]
    public class TwoSumTest
    {
        private TwoSum _kata = new TwoSum();

        [TestCase(new[] { 1, 2, 3, 4 }, 9, ExpectedResult = new[] { 0, 0 }, TestName = "1,2,3,4_9_Should_Be_0,0")]
        [TestCase(new[] { 2, 7, 11, 15 }, 9, ExpectedResult = new[] { 0, 1 }, TestName = "2,7,11,15_9_Should_Be_0,1")]
        [TestCase(new[] { 3, 2, 4 }, 6, ExpectedResult = new[] { 1, 2 }, TestName = "3,2,4_6_Should_Be_1,2")]
        public int[] SampleTests(int[] nums, int target)
        {
            return _kata.Calculate(nums, target);
        }
    }
}