using AdventOfCode2019.Day3;
using Xunit;

namespace AdventOfCode2019.Test
{
    public class DayThreeTests
    {
        [Fact]
        public void TestPartOne()
        {
            var inputs = new string[] { "R8,U5,L5,D3", "U7,R6,D4,L4" };

            var dayThree = new DayThree();

            var result = dayThree.PartOne(inputs);

            Assert.Equal(6, result);
        }
    }
}
