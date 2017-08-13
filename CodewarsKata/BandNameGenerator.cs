using System;
using System.Linq;

namespace CodewarsKata
{
    public class BandNameGenerator
    {
        public string Generator(string input)
        {
            input = input.ToLower();
            var firstLetter = input.Substring(0, 1);
            var otherLetters = input.Substring(1);
            if (input.EndsWith(firstLetter))
            {
                return string.Concat(firstLetter.ToUpper(), otherLetters, otherLetters);
            }
            else
            {
                return string.Concat("The ", firstLetter.ToUpper(), otherLetters);
            }
        }
    }
}