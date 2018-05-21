using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;
using System.Threading;
using ConwaysGameOfLifeKata.Test;

namespace ConwaysGameOfLifeKata.Kata
{
    public class GameWorld
    {
        private readonly NeighbourGenerator _surroundingCellLocations;
        public readonly Dictionary<string, CellLocation> CellLocationsOfLivingCells;
        public bool IsEmpty => !CellLocationsOfLivingCells.Any();
        
        public GameWorld()
        {
            _surroundingCellLocations = new NeighbourGenerator();
            CellLocationsOfLivingCells = new Dictionary<string,CellLocation>();
        }
        
        public void AddCell(CellLocation cellLocation)
        {
            if (WorldDoesNotHaveCellAt(cellLocation))
            {
                CellLocationsOfLivingCells.Add(_surroundingCellLocations.CreateKeyFrom(cellLocation), cellLocation);
            }
        }

        public int CountNeighboursOf(CellLocation cellLocation)
        {
            var numberOfNeighbouringCells = _surroundingCellLocations.GenerateSurroundingCellLocations(cellLocation);
            return numberOfNeighbouringCells.Keys.Intersect(CellLocationsOfLivingCells.Keys).Count();
        }
        
        private bool WorldDoesNotHaveCellAt(CellLocation cellLocation)
        {
            return !CellLocationsOfLivingCells.ContainsKey(_surroundingCellLocations.CreateKeyFrom(cellLocation));
        }
    }
}