using ConwaysGameOfLifeKata.Kata;
using Xunit;

namespace ConwaysGameOfLifeKata.Test
{
    public class EvolutionRulesTests
    {
        [Fact]
        public void GivenALiveCellWithTwoNeighboursThenLiveCellShouldLive()
        {
            var liveEvolutionRules = new LiveEvolutionRules();


            var result = liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(2);

            Assert.True(result);
        }
        
        
        [Fact]
        public void GivenALiveCellWithThreeNeighboursThenLiveCellShouldLive()
        {
            var liveEvolutionRules = new LiveEvolutionRules();


            var result = liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(3);

            Assert.True(result);
        }
        
        [Fact]
        public void GivenALiveCellWithLessThanTwoNeighboursThenLiveCellShouldDie()
        {
            var liveEvolutionRules = new LiveEvolutionRules();


            var result = liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(1);

            Assert.False(result);
        }
        
        [Fact]
        public void GivenALiveCellWithMoreThanThreeNeighboursThenLiveCellShouldDie()
        {
            var liveEvolutionRules = new LiveEvolutionRules();


            var result = liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(4);

            Assert.False(result);
        }
    }
}