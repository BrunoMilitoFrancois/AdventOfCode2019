using AdventOfCode2019.Day2;
using Xunit;

namespace AdventOfCode2019.Test
{
    public class DayTwoTests
    {
        [Fact]
        public void TestPartOne()
        {
            var inputs = new string[] { "1,9,10,3,2,3,11,0,99,30,40,50" };

            var dayTwo = new DayTwo();

            var result = dayTwo.PartOne(inputs);

            Assert.Equal(3500, result);
        }
    }
}
