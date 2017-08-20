using System;
using System.Linq;
using CodewarsKata;
using NUnit.Framework;

namespace CodewarsKataTests
{
    [TestFixture]
    public class CountingDuplicatesTest
    {
        [TestCase("", ExpectedResult = 0, TestName = "Empty_Should_Be_0")]
        [TestCase("abcde", ExpectedResult = 0, TestName = "abcde_Should_0")]
        [TestCase("aabbcde", ExpectedResult = 2, TestName = "aabbcde_Should_Be_2")]
        [TestCase("aabBcde", ExpectedResult = 2, TestName = "aabBcde_Should_Be_2")]
        [TestCase("Indivisibility", ExpectedResult = 1, TestName = "Indivisibility_Should_Be_1")]
        [TestCase("Indivisibilities", ExpectedResult = 2, TestName = "Indivisibilities_Should_Be_2")]
        [TestCase("aA11", ExpectedResult = 2, TestName = "aA11_Should_Be_2")]
        [TestCase("ABBA", ExpectedResult = 2, TestName = "ABBA_Should_Be_2")]
        public int SampleTests(string input)
        {
            var kata = new CountingDuplicates();
            return kata.DuplicateCount(input);
        }
    }
}