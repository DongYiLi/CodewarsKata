using System;
using System.Linq;
using CodewarsKata;
using NUnit.Framework;

namespace CodewarstKataTests
{
    [TestFixture]
    public class NextBiggerNumberTest
    {
        private NextBiggerNumber _kata = new NextBiggerNumber();

        [TestCase(0, ExpectedResult = -1, TestName = "0_Should_Be_-1")]
        [TestCase(9, ExpectedResult = -1, TestName = "9_Should_Be_-1")]
        [TestCase(111, ExpectedResult = -1, TestName = "111_Should_Be_-1")]
        [TestCase(531, ExpectedResult = -1, TestName = "531_Should_Be_-1")]
        [TestCase(12, ExpectedResult = 21, TestName = "12_Should_Be_21")]
        [TestCase(513, ExpectedResult = 531, TestName = "513_Should_Be_531")]
        [TestCase(2017, ExpectedResult = 2071, TestName = "2017_Should_Be_2071")]
        [TestCase(414, ExpectedResult = 441, TestName = "414_Should_Be_441")]
        [TestCase(495, ExpectedResult = 549, TestName = "495_Should_Be_549")]
        [TestCase(144, ExpectedResult = 414, TestName = "144_Should_Be_414")]
        [TestCase(2071, ExpectedResult = 2107, TestName = "2071_Should_Be_2107")]
        [TestCase(9281, ExpectedResult = 9812, TestName = "9281_Should_Be_9812")]
        [TestCase(89281, ExpectedResult = 89812, TestName = "89281_Should_Be_89812")]
        [TestCase(89999, ExpectedResult = 98999, TestName = "89999_Should_Be_98999")]
        [TestCase(98999, ExpectedResult = 99899, TestName = "98999_Should_Be_99899")]
        [TestCase(88988, ExpectedResult = 89888, TestName = "88988_Should_Be_89888")]
        [TestCase(111188, ExpectedResult = 111818, TestName = "111188_Should_Be_111818")]
        [TestCase(131316994, ExpectedResult = 131319469, TestName = "131316994_Should_Be_131319469")]
        [TestCase(19131316994, ExpectedResult = 19131319469, TestName = "19131316994_Should_Be_19131319469")]
        [TestCase(919131316994, ExpectedResult = 919131319469, TestName = "919131316994_Should_Be_919131319469")]
        [TestCase(59884848459853, ExpectedResult = 59884848483559, TestName = "59884848459853_Should_Be_59884848483559")]
        public long SampleTests(long input)
        {
            return _kata.Next(input);
        }
    }
}