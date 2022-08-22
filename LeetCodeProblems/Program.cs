using LeetCodeProblems;
using LeetCodeProblems.Array101;

Problem13 problem = new Problem13();

problem.RomanToInt("MCMXIV");

MaxConsecutiveOnes max = new MaxConsecutiveOnes();

int[] nums = new int[11] { 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1 };

max.FindMax(nums);

FindNumbersWithEvenNumberOfDigits find = new FindNumbersWithEvenNumberOfDigits();

int[] nums2 = new int[] { 12, 345, 2, 6, 7896 };

find.FindNumbers(nums2);
find.FindNumbersWithLinq(nums2);

SquaresOfASortedArray squares = new SquaresOfASortedArray();

int[] nums3 = new int[] { -4, -1, 0, 3, 10 };

var ads = squares.SortedSquares(nums3);

DuplicateZeros duplicateZeros = new DuplicateZeros();

//int[] nums4 = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
//int[] nums4 = new int[] { 8, 5, 0, 9, 0, 3, 4, 7 };
//int[] nums4 = new int[] { 0, 1, 7, 6, 0, 2, 0, 7 };
int[] nums4 = new int[] { 0, 0, 0, 0, 0, 0, 0 };

duplicateZeros.DupeZeros(nums4);