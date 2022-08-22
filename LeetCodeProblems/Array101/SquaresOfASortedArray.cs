using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array101
{
    public class SquaresOfASortedArray
    {

        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)Math.Pow(nums[i], 2);
            }
            Array.Sort(nums);
            //return MinSort(nums);
            return nums;
        }
        private int[] MinSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[min] > nums[j])
                    {
                        min = j;
                    }
                }
                int temp = nums[i];
                nums[i] = nums[min];
                nums[min] = temp;
            }
            return nums;
        }

        private void BubbleSortImproved(int[] nums)
        {
            int j = nums.Length;
            while (j >= 2)
            {
                int idx = 0;
                for (int i = 0; i < j - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                }
                j = idx;
            }
        }


    }
}
