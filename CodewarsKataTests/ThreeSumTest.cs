using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CodewarsKata;
using NUnit.Framework;

namespace CodewarsKataTests
{
    [TestFixture]
    public class ThreeSumTest
    {
        private ThreeSum _kata = new ThreeSum();

        [TestCaseSource(typeof(Test), "TestCases")]
        public IList<IList<int>> SampleTests(int[] nums)
        {
            return _kata.Calculate(nums);
        }

        public class Test
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(new[] { 0, 0, 0, 0 }).Returns(new List<List<int>> { new List<int> { 0, 0, 0 } }).SetName("0, 0, 0, 0_Should_Be_{ {0, 0, 0} }");
                    yield return new TestCaseData(new[] { -2, 0, 0, 2, 2 }).Returns(new List<List<int>> { new List<int> { -2, 0, 2 } }).SetName("-2, 0, 0, 2, 2_Should_Be_{ {-2, 0, 2} }");
                    yield return new TestCaseData(new[] { -1, 0, 1, 2, -1, -4 }).Returns(new List<List<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } }).SetName("-1, 0, 1, 2, -1, -4_Should_Be_{ { -1, -1, 2 }, { -1, 0, 1 } }");
                }
            }
        }
    }
}