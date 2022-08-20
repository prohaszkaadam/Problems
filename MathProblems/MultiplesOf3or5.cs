using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblems
{
    public class MultiplesOf3or5
    {
        public int Calc()
        {
            int[] nums = new int[1000];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                if (nums[i] != 0 && (nums[i] % 3 == 0 || nums[i] % 5 == 0))
                {
                    sum += nums[i];
                }
            }
            return sum;
        }
    }
}
