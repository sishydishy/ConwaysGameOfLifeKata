using ConwaysGameOfLifeKata.Kata;
using Xunit;
using Xunit.Sdk;

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

        [Fact]
        public void GivenACellWhenAddedToWorldThenReturnAsTrue()
        {
            var world = new GameWorld();
            world.AddCell(new CellLocation());
            Assert.Equal(true, !world.IsEmpty);
        }
        [Fact]
        public void GivenACellLocationThenGetCellLocationOfNeighbours()
        {
            var world = new GameWorld();
            var cellLocation = new CellLocation(1,1);
            world.AddCell(cellLocation);
            var result = world.GetCellLocationsOfNeighbouringCells(cellLocation);
            Assert.Equal(9, result);
        }
       
    }
}