using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array101
{
    public class MaxConsecutiveOnes
    {
        public int FindMax(int[] nums)
        {
            int counter = 0;
            int max = 0;
            foreach (var num in nums)
            {
                if (num == 1)
                {
                    counter++;
                }
                else
                {
                    if (max < counter)
                    {
                        max = counter;
                    }
                    counter = 0;
                }
            }
            if (max < counter)
            {
                max = counter;
            }
            return max;
        }
    }
}
