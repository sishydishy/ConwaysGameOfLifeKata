using ConwaysGameOfLifeKata.Kata;
using Xunit;

namespace ConwaysGameOfLifeKata.Test
{
    public class EvolutionRulesTests
    {
        
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void GivenALiveCellWithTwoOrThreeNeighboursThenLiveCellShouldLive(int neighbour)
        {
            var liveEvolutionRules = new LiveEvolutionRules();


            var result = liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(neighbour);

            Assert.True(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        public void GivenALiveCellWithLessThanTwoOrMoreThanThreeNeighboursThenLiveCellShouldLive1(int neighbour)
        {
            var liveEvolutionRules = new LiveEvolutionRules();


            var result = liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(neighbour);

            Assert.False(result);
        }
        
    }
}