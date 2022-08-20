// See https://aka.ms/new-console-template for more information
using MathProblems;

Console.WriteLine("Hello, World!");

MultiplesOf3or5 multiplesOf3Or5 = new MultiplesOf3or5();

Console.WriteLine(multiplesOf3Or5.Calc());

FibonacciSequence fibonacci = new FibonacciSequence();

fibonacci.Calc();

LargestPrimeFactor lpf = new LargestPrimeFactor();

lpf.CalcNormal();
lpf.Calc();

LargestPalindromeProduct product = new LargestPalindromeProduct();
product.Calc();