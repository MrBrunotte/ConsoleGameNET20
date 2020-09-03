using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleGameNET20
{
    internal class Game
    {
        private Map map;
        private Hero hero;
        internal void Run()
        {
            Initialize();
            Play();
        }

        private void Play()
        {
            bool gameInProgress = true;
            do
            {
                Drawmap();
                // Draw map
                // Get command from user, walk, pick up etc.
                // execute
                // Draw map
                // enemy actions
                // Draw map

                Console.ReadKey();
            } while (gameInProgress);
        }

        private void Drawmap()
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(y, x);
                    Console.Write(cell.Symbol);
                }
                Console.WriteLine();
            }
        }

        private void Initialize()
        {
            // ToDo: Read from config (sök på tasklist)
            map = new Map(width: 10,height: 10);
            hero = new Hero();
        }
    }
}
