using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Threading;
using ConwaysGameOfLifeKata.Kata;

namespace ConwaysGameOfLife.Kata
{
    class Program
    {
        static void Main()
        {
            ExecuteConwaysGameOfLife();
        }

        private static void ExecuteConwaysGameOfLife()
        {
            var myGame = new GameEngine();
            CreateBlinkerPattern(myGame, new CellLocation(100, 20));
            CreateBlinkerPattern(myGame, new CellLocation(25, 10));
            CreateBlinkerPattern(myGame, new CellLocation(5, 15));
            CreateGliderPattern(myGame, new CellLocation(15, 1));
            CreateGliderPattern(myGame, new CellLocation(7, 14));
            CreateBlockerPattern(myGame, new CellLocation(20, 10));
            CreateBlockerPattern(myGame, new CellLocation(20, 23));
            CreateBlockerPattern(myGame, new CellLocation(93, 25));
            CreateToadPattern(myGame, new CellLocation(90,25));
            
            while (true)
            {
                myGame.gameWorld = myGame.Evolve();
                Draw(myGame.gameWorld);
                Thread.Sleep(50);
            }
        }

        private static void CreateBlinkerPattern(GameEngine myGame, CellLocation location)
        {
            myGame.gameWorld.AddCell(new CellLocation(location, 1, 1));
            myGame.gameWorld.AddCell(new CellLocation(location, 1, 2));
            myGame.gameWorld.AddCell(new CellLocation(location, 1, 3));
        }

        private static void CreateBlockerPattern(GameEngine myGame, CellLocation location)
        {
            myGame.gameWorld.AddCell(new CellLocation(location, 0, 0));
            myGame.gameWorld.AddCell(new CellLocation(location, 1, 0));
            myGame.gameWorld.AddCell(new CellLocation(location, 0, -1));
            myGame.gameWorld.AddCell(new CellLocation(location, 1, -1));
        }

        private static void CreateToadPattern(GameEngine myGame, CellLocation location)
        {
            myGame.gameWorld.AddCell(new CellLocation(location, 0, 0));
            myGame.gameWorld.AddCell(new CellLocation(location, 0, 1));
            myGame.gameWorld.AddCell(new CellLocation(location, 0, 2));
            myGame.gameWorld.AddCell(new CellLocation(location, -1, 1));
            myGame.gameWorld.AddCell(new CellLocation(location, -1, 2));
            myGame.gameWorld.AddCell(new CellLocation(location, -1, 3));
        }

        private static void CreateGliderPattern(GameEngine myGame, CellLocation location)
        {
            myGame.gameWorld.AddCell(new CellLocation(location, 3, 1));
            myGame.gameWorld.AddCell(new CellLocation(location, 1, 2));
            myGame.gameWorld.AddCell(new CellLocation(location, 3, 2));
            myGame.gameWorld.AddCell(new CellLocation(location, 2, 3));
            myGame.gameWorld.AddCell(new CellLocation(location, 3, 3));
        }

        private static void Draw(GameWorld world)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.CursorVisible = false;

            foreach (var cellLocation in world.LocationOfLivingCellsInWorld.Values)
            {
                if ((cellLocation.X <= -1) || (cellLocation.Y <= -1)) continue;
                Console.SetCursorPosition(cellLocation.X, cellLocation.Y);
                Console.WriteLine("\u25A0");
            }
        }
    }
}