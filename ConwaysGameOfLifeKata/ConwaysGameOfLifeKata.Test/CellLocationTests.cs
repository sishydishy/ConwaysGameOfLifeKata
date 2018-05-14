using ConwaysGameOfLifeKata.Kata;
using Xunit;

namespace ConwaysGameOfLifeKata.Test
{
    public class CellLocationTests
    {
        [Fact]
        public void GivenCellLocationThenReturnCellLocation()
        {
            var cellLocation = new CellLocation(1,2);
            var result = cellLocation.ToString();
            
            Assert.Equal( "1,2", result );
        }
        
        [Fact]
        public void GivenEmptyCellLocationThenReturnDefualtCellLocation()
        {
            var cellLocation = new CellLocation();
            var result = cellLocation.ToString();
            
            Assert.Equal( "0,0", result );
        }

        [Fact]
        public void GivenACellLocationThenReturnNewCellLocation()
        {
            var cellLocation = new CellLocation(1,1);

            var newCellLocation = new CellLocation(cellLocation, -1, -1);
            
            Assert.Equal("0,0", newCellLocation.ToString());
 
            
        }
        
        
        
    }
}