using System;
using System.Linq;
using CodewarsKata;
using NUnit.Framework;

namespace CodewarsKataTests
{
    [TestFixture]
    public class StringAverageTest
    {
        [TestCase("", ExpectedResult = "n/a", TestName = "Empty_Should_Be_n/a")]
        [TestCase("zero nine five two", ExpectedResult = "four", TestName = "zero nine five tow_Should_Be_four")]
        [TestCase("four six two three", ExpectedResult = "three", TestName = "four six two three_Should_Be_three")]
        [TestCase("one two three four five", ExpectedResult = "three", TestName = "one two three four five_Should_Be_three")]
        [TestCase("five four", ExpectedResult = "four", TestName = "five four_Should_Be_four")]
        [TestCase("zero zero zero zero zero", ExpectedResult = "zero", TestName = "zero zero zero zero zero_Should_Be_zero")]
        [TestCase("one one eight one", ExpectedResult = "two", TestName = "one one eight one_Should_Be_two")]
        [TestCase("ten one two three", ExpectedResult = "n/a", TestName = "ten one two three_Should_Be_n/a")]
        public string SampleTests(string input)
        {
            var kata = new StringAverage();
            return kata.AverageString(input);
        }
    }
}