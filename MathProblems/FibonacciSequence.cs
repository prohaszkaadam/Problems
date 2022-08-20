using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblems
{
    public class FibonacciSequence
    {
        public int Calc()
        {
            List<int> seq = new List<int>() { 1, 1 };
            int n = 100;
            int sum = 0;
            for (int i = 2; i < n; i++)
            {
                seq.Add(seq[i - 2] + seq[i - 1]);

                if (seq[i] % 2 == 0 && seq[i] <= 4000000)
                {                    
                    sum += seq[i];
                }

                if (seq[i] > 4000000)
                {
                    break;
                }
            }
            return sum;
            ;
        }
    }
}
