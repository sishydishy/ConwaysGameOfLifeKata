using ConwaysGameOfLife.Kata;
using ConwaysGameOfLifeKata.Kata;
using Xunit;

namespace ConwaysGameOfLifeKata.Test
{
    public class EvolutionRulesTests
    {
        private readonly LiveEvolutionRules _liveEvolutionRules;

        public EvolutionRulesTests()
        {
            _liveEvolutionRules = new LiveEvolutionRules();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void GivenALiveCellWithTwoOrThreeNeighboursThenLiveCellShouldLive(int neighbour)
        {
            var result = _liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(neighbour);

            Assert.True(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        public void GivenALiveCellWithLessThanTwoOrMoreThanThreeNeighboursThenLiveCellShouldDie(int neighbour)
        {
            var result = _liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(neighbour);

            Assert.False(result);
        }

        [Fact]
        public void GivenADeadCellWithThreeNeighboursThenDeadCellShouldLive()
        {
            var deadEvolutionRules = new DeadEvolutionRules();
            var result = deadEvolutionRules.CellStateBasedOnNumberOfNeighbours(3);
            
            Assert.True(result);
        }
    }
}