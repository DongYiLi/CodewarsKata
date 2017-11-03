using System;
using System.Linq;
using CodewarsKata;
using NUnit.Framework;

namespace CodewarsKataTests
{
    [TestFixture]
    public class ContainsDuplicateIITest
    {
        [TestCase(new int[] { 1, 2, 3, 1 }, 3, ExpectedResult = true, TestName = "1,2,3,1_3_Should_Be_True")]
        [TestCase(new int[] { 99, 99 }, 2, ExpectedResult = true, TestName = "9,9_2_Should_Be_True")]
        [TestCase(new int[] { 1 }, 1, ExpectedResult = false, TestName = "1_1_Should_Be_False")]
        [TestCase(new int[] { 1, 0, 1, 1 }, 1, ExpectedResult = true, TestName = "1,0,1,1_1_Should_Be_True")]
        [TestCase(new int[] { 1, 2, 1 }, 0, ExpectedResult = false, TestName = "1,2,1_0_Should_Be_False")]
        [TestCase(new int[] { 1, 2, 1 }, 1, ExpectedResult = false, TestName = "1,2,1_1_Should_Be_False")]

        public bool SampleTests(int[] input, int k)
        {
            var kata = new ContainsDuplicateII();
            return kata.ContainsNearbyDuplicate(input, k);
        }
    }
}