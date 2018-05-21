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
        private readonly GeneratingNeighbours _generateCellLocationOfNeighbouringCells;
        public readonly Dictionary<string, CellLocation> LocationOfLivingCellsInWorld;
        public bool IsEmpty => !LocationOfLivingCellsInWorld.Any();
        
        public GameWorld()
        {
            _generateCellLocationOfNeighbouringCells = new GeneratingNeighbours();
            LocationOfLivingCellsInWorld = new Dictionary<string,CellLocation>();
        }
        
        public void AddCell(CellLocation cellLocation)
        {
            if (ChecksIfWorldAlreadyHasCellThatIsBeingAdded(cellLocation))
            {
                LocationOfLivingCellsInWorld.Add(_generateCellLocationOfNeighbouringCells.CreateKey(cellLocation), cellLocation);
            }
        }

        public int FindsIntersectingCellLocationsOfCurrentCellFromGeneratedNeighboursAndLivingCellsInTheWorld(CellLocation cellLocation)
        {
            var numberOfNeighbouringCells = _generateCellLocationOfNeighbouringCells.GenerateSurroundingCells(cellLocation);
            return numberOfNeighbouringCells.Keys.Intersect(LocationOfLivingCellsInWorld.Keys).Count();
        }
        
        private bool ChecksIfWorldAlreadyHasCellThatIsBeingAdded(CellLocation cellLocation)
        {
            return !LocationOfLivingCellsInWorld.ContainsKey(_generateCellLocationOfNeighbouringCells.CreateKey(cellLocation));
        }
    }
}