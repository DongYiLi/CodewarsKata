using System;
using System.Linq;

namespace CodewarsKata
{
    public class DeadAnts
    {
        public int DeadAntCount(string ants)
        {
            if (string.IsNullOrEmpty(ants))
            {
                return 0;
            }
            var ant = "ant";
            ants = ants.Replace(ant, string.Empty)
                        .Replace(".", string.Empty)
                        .Replace(" ", string.Empty);
            if (string.IsNullOrEmpty(ants))
            {
                return 0;
            }

            return ants.Where(x => ant.Contains(x))
                        .GroupBy(x => x)
                        .Max(x => x.Count());
        }
    }
}