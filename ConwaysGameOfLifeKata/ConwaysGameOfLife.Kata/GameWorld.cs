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
        
        

        public readonly Dictionary<string, CellLocation> LocationOfCellsInWorld;
        public GameWorld()
        {
            _generateCellLocationOfNeighbouringCells = new GeneratingNeighbours();
            LocationOfCellsInWorld = new Dictionary<string,CellLocation>();
        }
        public bool IsEmpty => !LocationOfCellsInWorld.Any();

        public void AddCell(CellLocation cellLocation)
        {
            if (!LocationOfCellsInWorld.ContainsKey(_generateCellLocationOfNeighbouringCells.CreateKey(cellLocation)))
            {
                LocationOfCellsInWorld.Add(_generateCellLocationOfNeighbouringCells.CreateKey(cellLocation), cellLocation);
            }
            
            
     
        }

        public int GetCellLocationsOfNeighbouringCells(CellLocation cellLocation)
        {
            
            var numberOfNeighbouringCells = _generateCellLocationOfNeighbouringCells.GenerateSurroundingCells(cellLocation);
            return numberOfNeighbouringCells.Keys.Intersect(LocationOfCellsInWorld.Keys).Count();








        }
        
    }
}