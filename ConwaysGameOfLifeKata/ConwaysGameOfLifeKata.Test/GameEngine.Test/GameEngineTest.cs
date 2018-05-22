using System.ComponentModel.DataAnnotations;
using ConwaysGameOfLifeKata.Kata;
using Xunit;

namespace ConwaysGameOfLifeKata.Test
{
    public class GameEngineTest
    {
        private readonly GameEngine _gameEngine;

        public GameEngineTest()
        {
            _gameEngine = new GameEngine();
        }

        [Fact]
        public void GivenEmptyWorldWithNoCellsWhenWorldIsIteratedThenReturnAsEmpty()
        {
            var result = _gameEngine.Evolve();
            
            Assert.True(result.IsEmpty); 
        }
        
        [Fact]
        public void GivenEmptyWorldWithACellsWhenWorldIsIteratedThenReturnAsEmpty()
        {
            var cellLocation = new CellLocation();
            _gameEngine.CurrentWorld.AddCell(cellLocation);
            var result = _gameEngine.Evolve();
            
            Assert.True(result.IsEmpty); 
        }

        [Fact]
        public void GivenWorldWithThreeCellsWhenWorldIsIteratedReturnAsNotEmpty()
        {
            var bottomCellLocation = new CellLocation(1,1);
            var cellLocation = new CellLocation(1,2);            
            _gameEngine.CurrentWorld.AddCell(bottomCellLocation);
            _gameEngine.CurrentWorld.AddCell(cellLocation);
            var result = _gameEngine.Evolve().CellLocationsOfLivingCells.Values.Count;
            
            Assert.Equal(0,result);
        }

        [Fact]
        public void GivenThreeCellLocationThenReturnNewBlinker()
        {
            var cellLocation1 = new CellLocation(1, 1);
            var cellLocation2 = new CellLocation(1,2);
            _gameEngine.CurrentWorld.AddCell(cellLocation1);
            _gameEngine.CurrentWorld.AddCell(cellLocation2);
            _gameEngine.CurrentWorld.AddCell(new CellLocation(1,3));
            
            var newNeighbour1 = "0,2";
            var newNeighbour2 = "2,2";
            
            Assert.True(_gameEngine.Evolve().CellLocationsOfLivingCells.ContainsValue(cellLocation2));
            Assert.True(_gameEngine.Evolve().CellLocationsOfLivingCells.ContainsKey(newNeighbour1));
            Assert.True(_gameEngine.Evolve().CellLocationsOfLivingCells.ContainsKey(newNeighbour2));
        }
    }
}




