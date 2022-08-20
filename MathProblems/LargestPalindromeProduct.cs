using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblems
{
    public class LargestPalindromeProduct
    {
        public void Calc()
        {
            int largest3DigitProduct = 998001;
            string largest3DigitPalindrome = "";
            //9009

            bool isPalindrome = false;

            for (; largest3DigitProduct >= 10000; largest3DigitProduct--)
            {
                while (!isPalindrome)
                {
                    string asString = largest3DigitProduct.ToString();

                    string firstHalf = asString.Substring(0, asString.Length / 2);
                    string secondHalf = asString.Substring(asString.Length / 2, asString.Length / 2);

                    char[] secondHalfToChar = secondHalf.ToArray();
                    string reversedSecondHalf = "";
                    for (int j = secondHalfToChar.Length - 1; j >= 0; j--)
                    {
                        reversedSecondHalf += secondHalfToChar[j];
                    }

                    if (firstHalf == reversedSecondHalf)
                    {
                        isPalindrome = true;
                        largest3DigitPalindrome = firstHalf + secondHalf;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int largest3DigitNumber = 999;
            List<int> divisibleNumbers = new List<int>();

            for (; largest3DigitNumber >= 100; largest3DigitNumber--)
            {
                if (int.Parse(largest3DigitPalindrome) % largest3DigitNumber == 0)
                {
                    divisibleNumbers.Add(largest3DigitNumber);
                }
            }

            ;
        }
    }
}
