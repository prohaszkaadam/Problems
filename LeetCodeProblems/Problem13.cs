using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem13
    {
        enum RomanNumerals
        {
            I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000
        }
        public int RomanToInt(string s)
        {
            int[] toInt = new int[s.Length];
            ;
            for (int i = 0; i < s.Length; i++)
            {
                toInt[i] = s[i];
            }
            ;
            return 0;
        }
    }
}
