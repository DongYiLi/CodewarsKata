using System;
using System.Linq;
using System.Collections.Generic;

namespace CodewarsKata
{
    public class ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var result = nums.Select((x, index) => new { Index = index, Value = x }).GroupBy(x => x.Value)
                .Where(x => x.Count() > 1)
                .Select(x => x.Aggregate(new Index
                {
                    Now = x.First().Index - x.Max(y => y.Index),
                    Min = k + 1
                }, (accumulate, y) =>
                {
                    accumulate.Min = Math.Min(y.Index - accumulate.Now, accumulate.Min);
                    accumulate.Now = y.Index;
                    return accumulate;
                }, acct => acct.Min)).Any(x => x <= k);
            return result;
        }

        public class Index
        {
            public int Min { get; set; }
            public int Now { get; set; }
        }
    }
}