using ConwaysGameOfLife.Kata;
using ConwaysGameOfLifeKata.Test;

namespace ConwaysGameOfLifeKata.Kata
{
    public class GameEngine
    {
        private readonly LiveEvolutionRules _liveEvolutionRules;
        private readonly DeadEvolutionRules _deadEvolutionRules;
        public GameWorld initialGameWorld { get; set; }
        private readonly NeighbourGenerator _neighbourGenerator = new NeighbourGenerator();

        public GameEngine()
        {
            initialGameWorld = new GameWorld();
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
            foreach (var cellLocation in initialGameWorld.CellLocationsOfLivingCells.Values)
            {
                CheckLivingCellAgainstLiveEvolutionRules(newWorld, cellLocation);
                CheckAgainstDeadEvolutionRules(newWorld, cellLocation);
            }
        }

        private void CheckLivingCellAgainstLiveEvolutionRules(GameWorld newWorld, CellLocation cellLocation)
        {
            var neighours =
                initialGameWorld.CountNeighboursOf(
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
                    initialGameWorld.CountNeighboursOf(
                        cells);

                if (_deadEvolutionRules.CellStateBasedOnNumberOfNeighbours(deadNeighours))
                {
                    newWorld.AddCell(cells);
                }
            }
        }
    }
}