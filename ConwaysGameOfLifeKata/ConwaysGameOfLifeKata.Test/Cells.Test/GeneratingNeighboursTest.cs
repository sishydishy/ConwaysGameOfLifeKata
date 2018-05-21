using System.Collections.Generic;
using ConwaysGameOfLifeKata.Kata;
using Xunit;

namespace ConwaysGameOfLifeKata.Test
{
    public class GeneratingNeighboursTest
    {

        [Fact]
        public void GivenLiveCellThenGenerateAllSurroundingNeighbours()
        {
            var generatingNeighbours = new NeighbourGenerator();
            var cellLocation = new CellLocation(1, 1);
            var result = generatingNeighbours.GenerateSurroundingCellLocations(cellLocation);
            Assert.Equal(8, result.Count);
        } 
}
}