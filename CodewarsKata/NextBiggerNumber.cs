using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsKata
{
    public class NextBiggerNumber
    {
        public long Next(long input)
        {
            var values = input.ToString().ToArray();
            if (IsMaxString(values))
            {
                return -1;
            }
            for (var rightCharNumber = 2; rightCharNumber <= values.Length; rightCharNumber++)
            {
                var others = values.Skip(values.Length - rightCharNumber).ToList();
                if (IsMaxString(others))
                {
                    continue;
                }
                var head = values.Take(values.Length - rightCharNumber);
                var first = values[values.Length - rightCharNumber];
                first = others.Where(x => x > first).Min();
                others.Remove(first);
                return long.Parse(new string(head.Concat(new char[] { first }).Concat(others.OrderBy(x => x)).ToArray()));
            }

            return 0;
        }

        private bool IsMaxString(IEnumerable<char> charArray)
        {
            return new string(charArray.ToArray()) == new string(charArray.OrderByDescending(x => x).ToArray());
        }
    }
}