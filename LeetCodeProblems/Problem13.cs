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
            I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000, IV = 4, IX = 9, XL = 40, XC = 90, CD = 400, CM = 900
        }
        public int RomanToInt(string s)
        {
            return RomanNumeralsConverterToNumbers(s).Sum();
        }
        public int[] RomanNumeralsConverterToNumbers(string s)
        {
            int[] romanNumeralsAsNumbers = new int[s.Length];
            StringBuilder sb1 = new StringBuilder(s);

            int i = s.Length - 1;
            int j = i;
            int k = 0;
            while (i > 0)
            {
                StringBuilder sb2 = new StringBuilder();
                sb2.Append(s[i - 1].ToString() + s[i].ToString());

                switch (sb2.ToString())
                {
                    case "IV":
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.IV;
                        k++;
                        sb1.Remove(i - 1, 2);
                        i -= 2;
                        j -= 2;
                        break;
                    case "IX":
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.IX;
                        k++;
                        sb1.Remove(i - 1, 2);
                        i -= 2;
                        j -= 2;
                        break;
                    case "XL":
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.XL;
                        k++;
                        sb1.Remove(i - 1, 2);
                        i -= 2;
                        j -= 2;
                        break;
                    case "XC":
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.XC;
                        k++;
                        sb1.Remove(i - 1, 2);
                        i -= 2;
                        j -= 2;
                        break;
                    case "CD":
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.CD;
                        k++;
                        sb1.Remove(i - 1, 2);
                        i -= 2;
                        j -= 2;
                        break;
                    case "CM":
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.CM;
                        k++;
                        sb1.Remove(i - 1, 2);
                        i -= 2;
                        j -= 2;
                        break;
                    default:
                        i--;
                        break;
                }
            }
            while (j >= 0)
            {
                switch (sb1[j])
                {
                    case 'I':
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.I;
                        k++;
                        j--;
                        break;
                    case 'V':
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.V;
                        k++;
                        j--;
                        break;
                    case 'X':
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.X;
                        k++;
                        j--;
                        break;
                    case 'L':
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.L;
                        k++;
                        j--;
                        break;
                    case 'C':
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.C;
                        k++; 
                        j--;
                        break;
                    case 'D':
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.D;
                        k++;
                        j--;
                        break;
                    case 'M':
                        romanNumeralsAsNumbers[k] = (int)RomanNumerals.M;
                        k++;
                        j--;
                        break;
                    default:
                        break;
                }
            }
            return romanNumeralsAsNumbers;
        }
    }
}
