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
            var generatingNeighbours = new GeneratingNeighbours();
            var cellLocation = new CellLocation(1, 1);
            var result = generatingNeighbours.GenerateSurroundingCells(cellLocation);
            Assert.Equal(8, result.Count);
        } 
}
}