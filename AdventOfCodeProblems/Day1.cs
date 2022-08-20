using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeProblems
{
    public class Day1
    {
        public int Solver()
        {
            List<int> data = GetData();
            int counter = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (i != 0 && data[i] > data[i - 1])
                {
                    counter++;
                }
            }
            int j = 0;
            var asd = data.Skip(1).Count(x => x > data[++j - 1]);
            return counter;
        }

        public int SolverSecondPart()
        {
            List<int> data = GetData();
            int counter = 0;
            List<int> sumList = new List<int>();
            int sum = 0;
            int j = 0;
            for (int i = 0; i < data.Count; i++)
            {
                j = i;
                while (j < i+3 && j < 2000)
                {
                    sum += data[j];                    
                    j++;
                }
                sumList.Add(sum);
                sum = 0;
            }

            for (int i = 1; i < sumList.Count; i++)
            {
                if (sumList[i] > sumList[i - 1])
                {
                    counter++;
                }
            }
            return counter;
        }

        private List<int> GetData()
        {
            return File.ReadAllLines("input.txt").Select(x => int.Parse(x)).ToList();

            //string[] lines = File.ReadAllLines("input.txt");
            //List<int> inputsAsInt = new List<int>();

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    inputsAsInt.Add(int.Parse(lines[i]));
            //}

            //return inputsAsInt;
        }
    }
}
