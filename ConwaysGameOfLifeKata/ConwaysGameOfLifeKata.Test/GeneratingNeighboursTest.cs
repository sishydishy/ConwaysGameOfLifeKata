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
            var listOfNeighbours = new List<CellLocation> {cellLocation};
            var result = generatingNeighbours.GenerateSurroundingCells(cellLocation, listOfNeighbours);
            
            Assert.Equal(8, result.Count);

        }
}

    public class GeneratingNeighbours
    {
        public List<CellLocation> GenerateSurroundingCells(CellLocation cellLocation, List<CellLocation> listOfNeighbours)
        {
            throw new System.NotImplementedException();
        }
    }
}