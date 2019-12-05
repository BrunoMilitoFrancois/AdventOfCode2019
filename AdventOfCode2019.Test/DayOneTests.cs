using AdventOfCode2019.Day1;
using Xunit;

namespace AdventOfCode2019.Test
{
    public class DayOneTests
    {
        [Fact]
        public void TestPartOne()
        {
            var firstInput = new string[] { "1969" };
            var secondInput = new string[] { "100756" };

            var dayOne = new DayOne();

            var firstResult = dayOne.PartOne(firstInput);
            var secondResult = dayOne.PartOne(secondInput);

            Assert.Equal(654, firstResult);
            Assert.Equal(33583, secondResult);
        }

        [Fact]
        public void TestPartTwo()
        {
            var input = new string[] { "100756" };

            var dayOne = new DayOne();

            var result = dayOne.PartTwo(input);

            Assert.Equal(50346, result);
        }
    }
}
