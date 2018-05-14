using System.Collections.Generic;
using ConwaysGameOfLifeKata.Kata;

namespace ConwaysGameOfLifeKata.Test
{
    public class GeneratingNeighbours
    {
        public List<CellLocation> GenerateSurroundingCells(CellLocation cellLocation, List<CellLocation> existingCellLocations)
        {
            var listofNeighbours = new List<CellLocation>();
            IterateThroughXAndYCoordinates(cellLocation, existingCellLocations, listofNeighbours);

            return listofNeighbours;
        }

        private static void IterateThroughXAndYCoordinates(CellLocation cellLocation, List<CellLocation> existingCellLocations,
            List<CellLocation> listofNeighbours)
        {
            for (int x = -1; x < 2; x++)
            {
                for (int y = -1; y < 2; y++)
                {
                    var newCellLocation = new CellLocation(cellLocation.X + x, cellLocation.Y + y);
                    AddNewCellLocationToListOfNeighbours(existingCellLocations, newCellLocation, listofNeighbours);
                }
            }
        }

        private static void AddNewCellLocationToListOfNeighbours(List<CellLocation> existingCellLocations, CellLocation newCellLocation,
            List<CellLocation> listofNeighbours)
        {
            if (IfNewCellLocationIsNotInExistingCellLocationList(existingCellLocations, newCellLocation))
            {
                listofNeighbours.Add(newCellLocation);
            }
        }

        private static bool IfNewCellLocationIsNotInExistingCellLocationList(List<CellLocation> existingCellLocations, CellLocation newCellLocation)
        {
            return !existingCellLocations.Contains(newCellLocation);
        }
    }
}