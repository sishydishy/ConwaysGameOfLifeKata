using System.Collections.Generic;
using System.Linq;
using ConwaysGameOfLifeKata.Test;

namespace ConwaysGameOfLifeKata.Kata

{
    public class GameWorld
    {
        private readonly GeneratingNeighbours _generateCellLocationOfNeighbouringCells;
        private Dictionary<string, CellLocation> LocationOfCellsInWorld;
        public GameWorld()
        {
            _generateCellLocationOfNeighbouringCells = new GeneratingNeighbours();
            LocationOfCellsInWorld = new Dictionary<string,CellLocation>();
        }
        public bool IsEmpty => !LocationOfCellsInWorld.Any();
    }
}