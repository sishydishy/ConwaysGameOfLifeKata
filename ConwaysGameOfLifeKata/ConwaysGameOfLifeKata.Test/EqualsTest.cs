using System.Collections.Generic;
using ConwaysGameOfLifeKata.Kata;
using Xunit;

namespace ConwaysGameOfLifeKata.Test
{
    public class EqualsTest
    {
        [Fact]
        public void GivenObjectAAndObjectBAreEqualThenReturnAsTrue()
        {
            var cellA = new List<CellLocation>
            {
                new CellLocation(1, 1)
            };
 
            var cellB = new List<CellLocation>
            {
                new CellLocation(1,1)
                
            };
            
           
            
            Assert.Equal(cellA, cellB);
        }
    }
}