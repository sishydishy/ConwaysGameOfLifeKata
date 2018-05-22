using ConwaysGameOfLifeKata.Kata;
using Xunit;
using Xunit.Sdk;

namespace ConwaysGameOfLifeKata.Test
{
    public class GameWorldTest
    {
        private readonly GameWorld _gameWorld;

        public GameWorldTest()
        {
            _gameWorld = new GameWorld();
        }

        [Fact]
        public void GivenEmptyWorldThenReturnAsTrue()
        {
            var result = _gameWorld.IsEmpty;
            
            Assert.True(result);
        }

        [Fact]
        public void GivenACellWhenAddedToWorldThenReturnAsTrue()
        {
            _gameWorld.AddCell(new CellLocation());
            
            Assert.Equal(true, !_gameWorld.IsEmpty);
        }
        
        [Fact]
        public void GivenACellLocationThenGetCellLocationOfNeighbours()
        {
            var cellLocation = new CellLocation(1,1);
            _gameWorld.AddCell(cellLocation);
            _gameWorld.AddCell(new CellLocation(1,2));
            _gameWorld.AddCell(new CellLocation());
            _gameWorld.AddCell(new CellLocation(0,1));
            var result = _gameWorld.CountNeighboursOf(cellLocation);
            
            Assert.Equal(3, result);
        }
       
    }
}