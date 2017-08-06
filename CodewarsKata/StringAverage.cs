using System;
using System.Linq;

namespace CodewarsKata
{
    public class StringAverage
    {
        public string AverageString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "n/a";
            }

            var numberList = input.Split(' ');
            var num = Numbers.zero;

            if (numberList.Any(x => !Enum.TryParse(x, out num)))
            {
                return "n/a";
            }

            var list = numberList.Select(x => (int)Enum.Parse(typeof(Numbers), x));

            return ((Numbers)Math.Floor(list.Average())).ToString();
        }

        public enum Numbers
        {
            zero,
            one,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine
        }
    }
}