using ConwaysGameOfLife.Kata;
using ConwaysGameOfLifeKata.Test;

namespace ConwaysGameOfLifeKata.Kata
{
    public class GameEngine
    {
        private readonly LiveEvolutionRules _liveEvolutionRules;
        private readonly DeadEvolutionRules _deadEvolutionRules;
        public GameWorld CurrentWorld { get; set; }
        private readonly NeighbourGenerator _neighbourGenerator = new NeighbourGenerator();

        public GameEngine()
        {
            CurrentWorld = new GameWorld();
            _liveEvolutionRules = new LiveEvolutionRules();
            _deadEvolutionRules = new DeadEvolutionRules();
        }

        public GameWorld Evolve()
        {
            var nextGenerationWorld = new GameWorld();
            Iterate(nextGenerationWorld);
            return nextGenerationWorld;
        }

        private void Iterate(GameWorld newWorld)
        {
            foreach (var cellLocation in CurrentWorld.CellLocationsOfLivingCells.Values)
            {
                CheckLivingCellAgainstLiveEvolutionRules(newWorld, cellLocation);
                CheckAgainstDeadEvolutionRules(newWorld, cellLocation);
            }
        }

        private void CheckLivingCellAgainstLiveEvolutionRules(GameWorld newWorld, CellLocation cellLocation)
        {
            var neighours =
                CurrentWorld.CountNeighboursOf(
                    cellLocation);

            if (_liveEvolutionRules.CellStateBasedOnNumberOfNeighbours(neighours))
            {
                newWorld.AddCell(cellLocation);
            }
        }

        private void CheckAgainstDeadEvolutionRules(GameWorld newWorld, CellLocation cellLocation)
        {
            var noCellsInLocation = _neighbourGenerator.GenerateSurroundingCellLocations(cellLocation);
            foreach (var cells in noCellsInLocation.Values)
            {
                var deadNeighours =
                    CurrentWorld.CountNeighboursOf(
                        cells);

                if (_deadEvolutionRules.CellStateBasedOnNumberOfNeighbours(deadNeighours))
                {
                    newWorld.AddCell(cells);
                }
            }
        }
    }
}