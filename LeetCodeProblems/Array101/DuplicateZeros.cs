using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array101
{
    public class DuplicateZeros
    {
        public void DupeZeros(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    Shift(arr, i);
                    i++;
                }

                //if (arr[i] == 0)
                //{
                //    if (i == 0)
                //    {
                //        c = 1;
                //    }
                //    else
                //    {
                //        c = -1;
                //    }

                //    k = i + 1;
                //    for (int j = arr.Length - k - c; j >= k; j--)
                //    {
                //        arr[j + 1] = arr[j];
                //    }
                //    if (k == arr.Length - 2)
                //    {
                //        arr[k + 1] = arr[k];
                //    }
                //    arr[i + 1] = 0;
                //    i++;
                //}
            }
            ;
        }

        public void Shift(int[] arr, int end)
        {
            for (int j = arr.Length - 2; j >= end; j--)
            {
                arr[j + 1] = arr[j];
            }
        }
    }
}
