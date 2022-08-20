using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblems
{
    public class LargestPrimeFactor
    {
        public List<int> CalcNormal()
        {
            long number = 600851475143;

            List<int> primeNumbers = new List<int>();

            for (int i = 2; i < 10000; i++)
            {
                int j = 0;
                for (j = 0; !(j == primeNumbers.Count || i % primeNumbers[j] == 0); j++) ; // ha nem osztható egyikkel sem VAGY ha osztható az i-vel
                if (j == primeNumbers.Count) // ha igaz, akkor tudjuk, hogy a j az egy olyan szám, ami semmivel sem osztható -> prím
                {
                    primeNumbers.Add(i);
                }
            }

            primeNumbers.Reverse();
            List<int> factor = new List<int>();

            for (int i = 0; i < primeNumbers.Count; i++)
            {
                if (number % primeNumbers[i] == 0)
                {
                    factor.Add(primeNumbers[i]);
                }
            }

            return factor;
        }
        public long Calc()
        {
            PrimeGenerator primeGenerator = new PrimeGenerator(10001);

            return primeGenerator.RunToLimit();
        }
    }

    public class PrimeGenerator : IEnumerator<long>
    {
        public long Current { get; private set; }
        public List<long> PrimeNumbers { get; private set; }
        public int Limit { get; private set; }
        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            while (!(Current < 0))
            {
                int j = 0;
                for (j = 0; !(j == PrimeNumbers.Count || Current % PrimeNumbers[j] == 0); j++) ;
                if (j == PrimeNumbers.Count)
                {
                    PrimeNumbers.Add(Current);
                    return Limit != PrimeNumbers.Count;
                }
                Current++;
            }
            return false;
        }

        public long RunToLimit()
        {
            while (MoveNext())
            {
            }
            return Current;
        }

        public void Reset()
        {
            Current = 2;
            PrimeNumbers.Clear();
        }

        public PrimeGenerator(int limit)
        {
            Current = 2;
            Limit = limit;
            PrimeNumbers = new List<long>();
        }
    }
}
