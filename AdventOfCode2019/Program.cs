using System;
using System.IO;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("01.txt");

            var totalPartOne = PartOne(lines);

            var totalPartTwo = PartTwo(lines);

            Console.WriteLine($"Part 1 - Total = {totalPartOne}");

            Console.WriteLine($"Part 2 - Total = {totalPartTwo}");
            Console.ReadKey();
        }

        private static int PartOne(string[] lines)
        {
            var total = 0;
            foreach (var line in lines)
            {
                total += CalculateFuel(int.Parse(line));
            }
            return total;
        }

        private static int PartTwo(string[] lines)
        {
            var total = 0;
            foreach (var line in lines)
            {
                total += CalculateFuelSum(int.Parse(line));
            }
            return total;
        }

        private static int CalculateFuel(int mass)
        {
            return (mass/3) - 2;
        }

        private static int CalculateFuelSum(int mass)
        {
            var fuel = CalculateFuel(mass);

            return fuel > 0 ? fuel + CalculateFuelSum(fuel) : 0;
        }
    }
}
