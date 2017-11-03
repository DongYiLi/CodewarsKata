using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsKata
{
    public class BowlingGame
    {
        public int Calculate(int[] nums)
        {
            var rounds = new List<Round>();
            for (int i = 0; i < nums.Length && i < 23; i = i + 2)
            {
                rounds.Add(new Round() { First = nums[i], Second = nums[i + 1] });
            }
            return rounds.Select((x, i) =>
            {
                if (x.Status == Status.Spare)
                {
                    return x.NormalScore + rounds[i + 1].First;
                }
                return x.NormalScore;
            }).Sum();
        }

        public enum Status
        {
            Normal,
            Spare,
            Strike
        }

        public class Round
        {
            public int First { get; set; }

            public int NormalScore => First + Second;

            public int Second { get; set; }

            public Status Status
            {
                get
                {
                    if (First == 10)
                    {
                        return Status.Strike;
                    }
                    return First + Second == 10 ? Status.Spare : Status.Normal;
                }
            }

            public int Third { get; set; }
        }
    }
}