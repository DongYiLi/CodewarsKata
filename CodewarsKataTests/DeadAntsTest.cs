using System;
using System.Linq;
using CodewarsKata;
using NUnit.Framework;

namespace CodewarsKataTests
{
    [TestFixture]
    public class DeadAntsTest
    {
        [TestCase("ant ant ant ant", ExpectedResult = 0, TestName = "ant ant ant ant_Should_Be_0")]
        [TestCase(null, ExpectedResult = 0, TestName = "null_Should_Be_0")]
        [TestCase("ant anantt aantnt", ExpectedResult = 2, TestName = "ant anantt aantnt_Should_Be_2")]
        [TestCase("ant ant .... a nt", ExpectedResult = 1, TestName = "ant ant .... a nt_Should_Be_1")]
        [TestCase("ant ant .b.b.b. a ntb", ExpectedResult = 1, TestName = "ant ant .b.b.b. a ntb_Should_Be_1")]
        public int SampleTests(string input)
        {
            var kata = new DeadAnts();
            return kata.DeadAntCount(input);
        }
    }
}