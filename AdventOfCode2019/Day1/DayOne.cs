namespace AdventOfCode2019.Day1
{
    public class DayOne
    {
        public int PartOne(string[] lines)
        {
            var total = 0;
            foreach (var line in lines)
            {
                total += CalculateFuel(int.Parse(line));
            }
            return total;
        }

        public int PartTwo(string[] lines)
        {
            var total = 0;
            foreach (var line in lines)
            {
                total += CalculateFuelSum(int.Parse(line));
            }
            return total;
        }

        private int CalculateFuel(int mass)
        {
            return (mass / 3) - 2;
        }

        private int CalculateFuelSum(int mass)
        {
            var fuel = CalculateFuel(mass);

            return fuel > 0 ? fuel + CalculateFuelSum(fuel) : 0;
        }
    }
}
