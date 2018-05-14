using System.Collections.Generic;
using ConwaysGameOfLifeKata.Kata;

namespace ConwaysGameOfLifeKata.Test
{
    public class GeneratingNeighbours
    {

        public Dictionary<string,CellLocation> GenerateSurroundingCells1(CellLocation cellLocation)
        {
            var cellLocationOfNeighbouringCells = new Dictionary<string, CellLocation>();
            for (var x = -1; x < 2; x++)
            {
                for (var y = -1; y < 2; y++)
                {
                    var newCellLocation = new CellLocation(cellLocation.X +x, cellLocation.Y+y);
                    if (!CreateKey(cellLocation).Equals(CreateKey(newCellLocation)))
                    {
                       cellLocationOfNeighbouringCells.Add(CreateKey(newCellLocation),newCellLocation); 
                        
                    }

                }
                
            }

            return cellLocationOfNeighbouringCells;
        }

        private string CreateKey(CellLocation cellLocation)
        {
            return cellLocation.ToString();
        }
    }
}