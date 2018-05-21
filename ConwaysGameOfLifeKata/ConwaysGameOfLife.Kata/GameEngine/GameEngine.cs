using System.Collections.Generic;
using ConwaysGameOfLife.Kata;
using ConwaysGameOfLifeKata.Test;

namespace ConwaysGameOfLifeKata.Kata
{
    public class GameEngine
    {
        private readonly LiveEvolutionRules _liveEvolutionRules;
        private readonly DeadEvolutionRules _deadEvolutionRules;
        public GameWorld gameWorld { get; set; }
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
            foreach (var cellLocation in gameWorld.LocationOfLivingCellsInWorld)
            {
                CheckLivingCellAgainstLiveEvolutionRules(newWorld, cellLocation);
                DeadCellsOfCurrenCellAndCheckAgainstDeadEvolutionRules(newWorld, cellLocation);
            }
        }

        private void CheckLivingCellAgainstLiveEvolutionRules(GameWorld newWorld, KeyValuePair<string, CellLocation> cellLocation)
        {
            var neighours =
                gameWorld.FindsIntersectingCellLocationsOfCurrentCellFromGeneratedNeighboursAndLivingCellsInTheWorld(
                    cellLocation.Value);

            if (_liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(neighours))
            {
                newWorld.AddCell(cellLocation.Value);
            }
        }

        private void DeadCellsOfCurrenCellAndCheckAgainstDeadEvolutionRules(GameWorld newWorld, KeyValuePair<string, CellLocation> cellLocation)
        {
            var noCellsInLocation = _generatingNeighbours.GenerateSurroundingCells(cellLocation.Value);
            foreach (var cells in noCellsInLocation)
            {
                var deadNeighours =
                    gameWorld.FindsIntersectingCellLocationsOfCurrentCellFromGeneratedNeighboursAndLivingCellsInTheWorld(
                        cells.Value);

                if (_deadEvolutionRules.CellStateBasedOnNumberOfNeighbours(deadNeighours))
                {
                    newWorld.AddCell(cells.Value);
                }
            }
        }
    }
}