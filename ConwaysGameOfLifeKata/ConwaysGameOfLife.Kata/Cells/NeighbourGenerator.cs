using System.Collections.Generic;
using ConwaysGameOfLifeKata.Kata;

namespace ConwaysGameOfLifeKata.Test
{
    public class NeighbourGenerator
    {
        public string CreateKeyFrom(CellLocation cellLocation)
        {
            return cellLocation.ToString();
        }
        
        public Dictionary<string,CellLocation> GenerateSurroundingCellLocations(CellLocation cellLocation)
        {
            var cellLocationOfNeighbouringCells = new Dictionary<string, CellLocation>();
            IterateXAndYCoordinates(cellLocation, cellLocationOfNeighbouringCells);
            return cellLocationOfNeighbouringCells;
        }
                
        private void IterateXAndYCoordinates(CellLocation cellLocation,
            IDictionary<string, CellLocation> cellLocationOfNeighbouringCells)
        {
            for (var x = -1; x < 2; x++)
            {
                for (var y = -1; y < 2; y++)
                {
                    var newCellLocation = new CellLocation(cellLocation.X + x, cellLocation.Y + y);
                    AddsNewCellLocation(cellLocation, newCellLocation, cellLocationOfNeighbouringCells);
                }
            }
        }

        private void AddsNewCellLocation(CellLocation cellLocation, CellLocation newCellLocation,
            IDictionary<string, CellLocation> cellLocationOfNeighbouringCells)
        {
            if (DoesNewCellLocationEqualToCurrentCellLocation(cellLocation, newCellLocation))
            {
                cellLocationOfNeighbouringCells.Add(CreateKeyFrom(newCellLocation), newCellLocation);
            }
        }

        private bool DoesNewCellLocationEqualToCurrentCellLocation(CellLocation cellLocation, CellLocation newCellLocation)
        {
            return !CreateKeyFrom(cellLocation).Equals(CreateKeyFrom(newCellLocation));
        }
    }
}