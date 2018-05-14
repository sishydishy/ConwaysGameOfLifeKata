using ConwaysGameOfLifeKata.Kata;
using Xunit;

namespace ConwaysGameOfLifeKata.Test
{
    public class GameWorldTest
    {
        [Fact]
        public void GivenEmptyWorldThenReturnAsTrue()
        {
            var world = new GameWorld();
            var result = world.IsEmpty;
            Assert.True(result);

        }
    }
}