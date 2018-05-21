﻿using System.Collections.Generic;
using ConwaysGameOfLifeKata.Kata;

namespace ConwaysGameOfLifeKata.Test
{
    public class GeneratingNeighbours
    {
        public string CreateKeyFrom(CellLocation cellLocation)
        {
            return cellLocation.ToString();
        }
        
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
                cellLocationOfNeighbouringCells.Add(CreateKeyFrom(newCellLocation), newCellLocation);
            }
        }

        private bool ChecksIfNewCellLocationIsNotEqualToCurrentCellLocation(CellLocation cellLocation, CellLocation newCellLocation)
        {
            return !CreateKeyFrom(cellLocation).Equals(CreateKeyFrom(newCellLocation));
        }
    }
}