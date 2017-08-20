using System;
using System.Linq;

namespace CodewarsKata
{
    public class CountingDuplicates
    {
        public int DuplicateCount(string input)
        {
            return input.ToLower()
                        .GroupBy(x => x)
                        .Count(x => x.Count() > 1);
        }
    }
}