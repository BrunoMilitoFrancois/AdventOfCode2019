using AdventOfCode2019.Day1;
using AdventOfCode2019.Day2;
using AdventOfCode2019.Day3;
using System;
using System.IO;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayOneInput = File.ReadAllLines("01.txt");

            var dayOne = new DayOne();

            Console.WriteLine($"Day 01 - Part 1 - Total = {dayOne.PartOne(dayOneInput)}");
            Console.WriteLine($"Day 01 - Part 2 - Total = {dayOne.PartTwo(dayOneInput)}");

            var dayTwo = new DayTwo();

            var dayTwoInputs = File.ReadAllLines("02.txt");

            Console.WriteLine($"Day 02 - Part 1 - Total = {dayTwo.PartOne(dayTwoInputs)}");
            Console.WriteLine($"Day 02 - Part 2 - Total = {dayTwo.PartTwo(dayTwoInputs)}");

            var dayThreeInputs = File.ReadAllLines("03.txt");

            var dayThree = new DayThree();

            Console.WriteLine($"Day 03 - Part 1 - Total = {dayThree.PartOne(dayThreeInputs)}");

            Console.ReadKey();
        }
    }
}
