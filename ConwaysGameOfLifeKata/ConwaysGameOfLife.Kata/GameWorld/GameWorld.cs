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
            if (WorldDoesNotHaveCellAt(cellLocation))
            {
                LocationOfLivingCellsInWorld.Add(_generateCellLocationOfNeighbouringCells.CreateKeyFrom(cellLocation), cellLocation);
            }
        }

        public int CountNeighboursOf(CellLocation cellLocation)
        {
            var numberOfNeighbouringCells = _generateCellLocationOfNeighbouringCells.GenerateSurroundingCells(cellLocation);
            return numberOfNeighbouringCells.Keys.Intersect(LocationOfLivingCellsInWorld.Keys).Count();
        }
        
        private bool WorldDoesNotHaveCellAt(CellLocation cellLocation)
        {
            return !LocationOfLivingCellsInWorld.ContainsKey(_generateCellLocationOfNeighbouringCells.CreateKeyFrom(cellLocation));
        }
    }
}