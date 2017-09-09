using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsKata
{
    public class ThreeSum
    {
        public IList<IList<int>> Calculate(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            int start;
            int end;
            int sum;
            for (var i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                sum = 0 - nums[i];
                start = i + 1;
                end = nums.Length - 1;
                while (start < end)
                {
                    if (nums[start] + nums[end] == sum)
                    {
                        result.Add(new List<int> { nums[i], nums[start], nums[end] });
                        start = MoveStartElement(nums, start, end);
                        end = MoveEndElement(nums, start, end);
                    }
                    else if (nums[start] + nums[end] < sum)
                    {
                        start = MoveStartElement(nums, start, end);
                    }
                    else
                    {
                        end = MoveEndElement(nums, start, end);
                    }
                }
            }
            return result;
        }

        private int MoveEndElement(int[] nums, int start, int end)
        {
            while (nums[end] == nums[--end] && start < end) { }

            return end;
        }

        private int MoveStartElement(int[] nums, int start, int end)
        {
            while (nums[start] == nums[++start] && start < end) { }

            return start;
        }
    }
}