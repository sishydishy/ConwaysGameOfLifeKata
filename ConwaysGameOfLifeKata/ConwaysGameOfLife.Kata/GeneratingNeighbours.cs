using System.Collections.Generic;
using ConwaysGameOfLifeKata.Kata;

namespace ConwaysGameOfLifeKata.Test
{
    public class GeneratingNeighbours
    {

        public Dictionary<string,CellLocation> GenerateSurroundingCells(CellLocation cellLocation)
        {
            var cellLocationOfNeighbouringCells = new Dictionary<string, CellLocation>();
            IterateXAndYCoordinatesForNeighbouringCellLocations(cellLocation, cellLocationOfNeighbouringCells);

            return cellLocationOfNeighbouringCells;
        }

        private void IterateXAndYCoordinatesForNeighbouringCellLocations(CellLocation cellLocation,
            IDictionary<string, CellLocation> cellLocationOfNeighbouringCells)
        {
            for (var x = -1; x < 2; x++)
            {
                for (var y = -1; y < 2; y++)
                {
                    var newCellLocation = new CellLocation(cellLocation.X + x, cellLocation.Y + y);
                    AddsNewCellLocationToDictionary(cellLocation, newCellLocation, cellLocationOfNeighbouringCells);
                }
            }
        }

        private void AddsNewCellLocationToDictionary(CellLocation cellLocation, CellLocation newCellLocation,
            IDictionary<string, CellLocation> cellLocationOfNeighbouringCells)
        {
            if (ChecksIfNewCellLocationIsNotEqualToCurrentCellLocation(cellLocation, newCellLocation))
            {
                cellLocationOfNeighbouringCells.Add(CreateKey(newCellLocation), newCellLocation);
            }
        }

        private bool ChecksIfNewCellLocationIsNotEqualToCurrentCellLocation(CellLocation cellLocation, CellLocation newCellLocation)
        {
            return !CreateKey(cellLocation).Equals(CreateKey(newCellLocation));
        }

        private string CreateKey(CellLocation cellLocation)
        {
            return cellLocation.ToString();
        }
    }
}