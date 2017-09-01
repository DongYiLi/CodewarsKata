using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsKata
{
    public class TwoSum
    {
        public int[] Calculate(int[] nums, int target)
        {
            var differences = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (differences[j] == nums[i])
                    {
                        return new int[2] { j, i };
                    }
                }
                differences[i] = target - nums[i];
            }
            return new int[2] { 0, 0 };
        }
    }
}