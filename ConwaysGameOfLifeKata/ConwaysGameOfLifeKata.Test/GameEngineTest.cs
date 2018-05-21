using System.ComponentModel.DataAnnotations;
using ConwaysGameOfLifeKata.Kata;
using Xunit;

namespace ConwaysGameOfLifeKata.Test
{
    public class GameEngineTest
    {
        [Fact]
        public void GivenEmptyWorldWithNoCellsWhenWorldIsIteratedThenReturnAsEmpty()
        {
            var gameEngine = new GameEngine();
            var result = gameEngine.Evolve();
            
            Assert.True(result.IsEmpty); 
        }
        
        [Fact]
        public void GivenEmptyWorldWithACellsWhenWorldIsIteratedThenReturnAsEmpty()
        {
            var gameEngine = new GameEngine();
            var cellLocation = new CellLocation();
            gameEngine.gameWorld.AddCell(cellLocation);
            var result = gameEngine.Evolve();
            Assert.True(result.IsEmpty); 
        }

        [Fact]
        public void GivenWorldWithThreeCellsWhenWorldIsIteratedReturnAsNotEmpty()
        {
            var gameEngine = new GameEngine();
            var bottomCellLocation = new CellLocation(1,1);
            var cellLocation = new CellLocation(1,2);
            

            gameEngine.gameWorld.AddCell(bottomCellLocation);
            gameEngine.gameWorld.AddCell(cellLocation);
           
            var result = gameEngine.Evolve().LocationOfCellsInWorld.Values.Count;
            Assert.Equal(0,result);
        }

        [Fact]
        public void GivenThreeCellLocationThenReturnNewBlinker()
        {
            var gameEngine = new GameEngine();
            var loc1 = new CellLocation(1, 1);
            gameEngine.gameWorld.AddCell(loc1);
            gameEngine.gameWorld.AddCell(new CellLocation(1,2));
            gameEngine.gameWorld.AddCell(new CellLocation(1,3));
            
            var newNeighbour1 = new CellLocation(0,2);
            var newNeighbour2 = new CellLocation(2,2);

            
            
            Assert.False(gameEngine.Evolve().LocationOfCellsInWorld.ContainsValue(loc1));

        }
    }
}




