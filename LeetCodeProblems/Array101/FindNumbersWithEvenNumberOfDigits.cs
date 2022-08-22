using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array101
{
    public class FindNumbersWithEvenNumberOfDigits
    {

        public int FindNumbers(int[] nums)
        {
            int counter = 0;
            foreach (var num in nums)
            {
                if (num.ToString().Length % 2 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public int FindNumbersWithLinq(int[] nums)
        {
            return nums.Where(x => x.ToString().Length % 2 == 0).Count();
        }
    }
}
