using System;
using System.Linq;
using CodewarsKata;
using NUnit.Framework;

namespace CodewarsKataTests
{
    [TestFixture]
    public class BowlingGameTest
    {
        private readonly BowlingGame _kata = new BowlingGame();

        [TestCase(new[] { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, ExpectedResult = 2, TestName = "1,1_Should_Be_2")]
        [TestCase(new[] { 1, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, ExpectedResult = 10, TestName = "1,9_Should_Be_10")]
        [TestCase(new[] { 1, 9, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, ExpectedResult = 12, TestName = "1,9,1_Should_Be_12")]
        [TestCase(new[] { 1, 9, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, ExpectedResult = 14, TestName = "1,9,1,2_Should_Be_14")]
        [TestCase(new[] { 1, 9, 1, 9, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, ExpectedResult = 23, TestName = "1,9,1,9,1_Should_Be_23")]
        public int SampleTests(int[] nums)
        {
            return _kata.Calculate(nums);
        }
    }
}