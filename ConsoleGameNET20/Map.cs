using System;

namespace ConsoleGameNET20
{
    internal class Map
    {
        // fält får inte var public
        public int Width { get; }
        public int Height { get; }

        // 
        private readonly Cell[,] cells;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;

            // instanciera cell object (skapa objectet i minnet)
            cells = new Cell[height, width];

            // skapa object celler
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    cells[y, x] = new Cell();
                }
            }
        }

        internal Cell GetCell(int y, int x)
        {
            return cells[y, x];
        }
    }
}