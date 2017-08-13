using System;
using System.Linq;
using CodewarsKata;
using NUnit.Framework;

namespace CodewarsKataTests
{
    [TestFixture]
    public class BandNamegeneratorTest
    {
        [TestCase("knife", ExpectedResult = "The Knife", TestName = "knife_Should_Be_The Knife")]
        [TestCase("tart", ExpectedResult = "Tartart", TestName = "tart_Should_Tartart")]
        [TestCase("sandles", ExpectedResult = "Sandlesandles", TestName = "sandles_Should_Be_Sandlesandles")]
        [TestCase("bed", ExpectedResult = "The Bed", TestName = "bed_Should_Be_The Bed")]
        public string SampleTests(string input)
        {
            var kata = new BandNameGenerator();
            return kata.Generator(input);
        }
    }
}