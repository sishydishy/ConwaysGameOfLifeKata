using ConwaysGameOfLife.Kata;
using ConwaysGameOfLifeKata.Kata;
using ConwaysGameOfLifeKata.Test;

namespace ConwaysGameOfLifeKata.Kata
{
    public class GameEngine
    {
        private readonly LiveEvolutionRules _liveEvolutionRules;
        private readonly DeadEvolutionRules _deadEvolutionRules;
        public GameWorld gameWorld  { get; set; }
        private readonly GeneratingNeighbours _generatingNeighbours = new GeneratingNeighbours();
        
        
        
        public GameEngine()
        {
            gameWorld = new GameWorld();
            _liveEvolutionRules = new LiveEvolutionRules();
            _deadEvolutionRules = new DeadEvolutionRules();
        }
        public GameWorld Evolve()
        {
            var newWorld = new GameWorld();
            Iterate(newWorld);
            return newWorld;


        }

        private void Iterate(GameWorld newWorld)
        {
            foreach (var cellLocation in gameWorld.LocationOfCellsInWorld)
            {
                var neighours = gameWorld.GetCellLocationsOfNeighbouringCells(cellLocation.Value);
                if (_liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(neighours) )
                {
                    newWorld.AddCell(cellLocation.Value);
                }

                var noCellsInLocation = _generatingNeighbours.GenerateSurroundingCells(cellLocation.Value);
                foreach (var cells in noCellsInLocation)
                {
                    var deadNeighours = gameWorld.GetCellLocationsOfNeighbouringCells(cells.Value);
                    if (_deadEvolutionRules.CellStateBasedOnNumberOfNeighbours(deadNeighours)) 
                    
                    {
                        newWorld.AddCell(cells.Value);
                    }
                }
            }
            
            
        }
        
    }
}






