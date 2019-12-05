using System;
using System.Linq;

namespace AdventOfCode2019.Day2
{
    public class DayTwo
    {
        public int PartOne(string[] inputs)
        {
            var input = inputs.First();

            var separated = input.Split(',');

            var numbers = separated.Select(s => int.Parse(s.ToString())).ToArray();

            return CalculateOutput(numbers, 12, 2);
        }

        public int PartTwo(string[] inputs)
        {
            var input = inputs.First();

            var separated = input.Split(',');

            var numbers = separated.Select(s => int.Parse(s.ToString())).ToArray();

            for (int i = 0; i <= 99; i++)
            {
                for (int j = 0; j <= 99; j++)
                {
                    var copy = new int[numbers.Length];
                    Array.Copy(numbers, copy, numbers.Length);
                    if (CalculateOutput(copy , copy[i], copy[j]) == 19690720)
                    {
                        return (100 * i) + j;
                    }
                }
            }
            return 0;
        }

        private int CalculateOutput(int[] numbers, int noun, int verb)
        {
            numbers[1] = noun;
            numbers[2] = verb;

            for (int i = 0; i < numbers.Length; i += 4)
            {
                var operation = numbers[i];
                if (operation == 99)
                {
                    return numbers[0];
                }
                var predicateOne = numbers[numbers[i + 1]];
                var predicateTwo = numbers[numbers[i + 2]];
                var outputPosition = numbers[i + 3];

                if (operation == 1)
                {
                    numbers[outputPosition] = predicateOne + predicateTwo;
                }
                else if (operation == 2)
                {
                    numbers[outputPosition] = predicateOne * predicateTwo;
                }
                else if (numbers[0] == 19690720)
                {
                    return 100 * predicateOne + predicateTwo;
                }
                else
                {
                    throw new ArgumentException("Invalid Operation");
                }

            }
            return 0;
        }
    }
}
