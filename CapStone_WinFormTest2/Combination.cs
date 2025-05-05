using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapStone_WinFormTest2
{
    public class Combination
    {
        // Define the set of 10 elements
        private int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //private List<int> elements;
        private List<int[]> combinations = new List<int[]>();
        private int CombinationsCount;

        public Combination()
        {
            GenerateCombinations(elements, 0, new List<int>(), combinations, 3);
            CombinationsCount = combinations.Count;
        }

        public int GetCombinationsCount()
        {
            return combinations.Count;
        }

        private void GenerateCombinations(int[] elements, int start, List<int> current, List<int[]> combinations, int length)
        {
            // Base case: When the current combination reaches the desired length
            if (current.Count == length)
            {
                combinations.Add(current.ToArray());
                return;
            }

            // Recursive case: Add elements starting from 'start' index
            for (int i = start; i < elements.Length; i++)
            {
                current.Add(elements[i]);
                GenerateCombinations(elements, i + 1, current, combinations, length);
                current.RemoveAt(current.Count - 1); // Backtrack
            }

        }

        private int GenerateRandomNumber(int Max)
        {
            Random random = new Random();
            int RandomNumber = 0;

            RandomNumber = random.Next(0, Max);
            return RandomNumber;

        }

        public int[] GetCombination()
        {
            if (combinations.Count == 0)
                return null;

            int Index = GenerateRandomNumber(combinations.Count);
            var CombinationPicked = combinations[Index];

            combinations.RemoveAt(Index);

            return CombinationPicked;
        }
    }
}
