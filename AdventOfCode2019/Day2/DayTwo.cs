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

            numbers[1] = 12;
            numbers[2] = 2;

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

                if(operation == 1)
                {
                    numbers[outputPosition] = predicateOne + predicateTwo;
                }
                else if(operation == 2)
                {
                    numbers[outputPosition] = predicateOne * predicateTwo;
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
