using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    class Board
    {
        int sizeX = 10;
        int sizeY = 20;

        PictureBox[,] box;
        int[,] map, mapBack;
        Panel panel;
        Figure figure, newFigure;
        Coord statPosition = new Coord(4, 1);
        Coord position = new Coord(0, 0);
        BoardMini boardMini;
        public int score { private set; get; }
        deShowWin showWin;
        public Board(Panel panel, Panel panelMini, deShowWin deShowWin)
        {
            this.panel = panel;
            score = 0;
            showWin= deShowWin;
            boardMini = new BoardMini(panelMini);
            InitMap();
            AddFigureOnBoard();
            RefreshBoard();
        }

        void InitMap()
        {
            box = new PictureBox[sizeX, sizeY];
            map = new int[sizeX, sizeY];
            mapBack = new int[sizeX, sizeY];

            panel.Controls.Clear();

            int boxSize = panel.Width / sizeX;

            for (int x = 0; x < sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.Location = new Point(x * boxSize - 1, y * boxSize - 1);
                    picture.Size = new Size(boxSize, boxSize);
                    picture.BackColor = SystemColors.ControlLightLight;
                    picture.BorderStyle = BorderStyle.FixedSingle;

                    panel.Controls.Add(picture);
                    box[x, y] = picture;
                    map[x, y] = mapBack[x, y] = 0;
                }
        }

        void AddFigureOnBoard()
        {
            if (figure != null)
            {
                foreach (Coord coord in figure.coord)
                {
                    map[position.x + coord.x, position.y + coord.y] = 0;
                    mapBack[position.x + coord.x, position.y + coord.y] = figure.nr;
                }
            }

            figure = newFigure ?? new Figure();

            foreach(Coord coord1in in figure.coord)
            {
                if(mapBack[statPosition.x + coord1in.x, statPosition.y + coord1in.y] > 0)
                {
                    showWin(false);
                    return;
                }
                
            }

                
            newFigure = new Figure();
            boardMini.RefreshBoard(newFigure);

            position = statPosition;


            Step(0, 0);

        }

        void RefreshBoard()
        {
            bool fire;
            for (int y = 0; y < sizeY; y++)
            {
                fire = true;
                for (int x = 0; x < sizeX; x++)
                {
                    if (mapBack[x, y] == 0) fire = false;
                }
                if (fire)
                {
                    DelLines(); break;
                }
            }

            for (int x = 0; x < sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                    box[x, y].BackColor = figure.ColorFig(map[x, y] > 0 ? map[x, y] : mapBack[x, y]);
        }

        private void DelLines()
        {
            int kol_now = 0;
            bool fire;
            for (int y = 0; y < sizeY; y++)
            {
                fire = true;
                for (int x = 0; x < sizeX; x++)
                {
                    if (mapBack[x, y] == 0) fire = false;
                }
                if (fire)
                {
                    mapBack = AddRow(TrimArray(mapBack, y));
                    kol_now++;
                }
            }
            switch (kol_now)
            {
                case 1: score += 100; break;
                case 2: score += 300; break;
                case 3: score += 700; break;
                case 4: score += 1500; break;
                default: score += 0; break;
            }
        }

        public void Step(int sx, int sy)
        {
            foreach (Coord coord in figure.coord)
            {
                if (position.x + coord.x + sx < 0 ||
                    position.x + coord.x + sx >= sizeX ||
                    mapBack[position.x + coord.x + sx, position.y + coord.y] > 0)
                    return;

                if (position.y + coord.y + sy >= sizeY || mapBack[position.x + coord.x, position.y + coord.y + sy] > 0)
                {
                    AddFigureOnBoard();
                    return;
                }
            }


            foreach (Coord coord in figure.coord)
                map[position.x + coord.x, position.y + coord.y] = 0;

            foreach (Coord coord in figure.coord)
                map[position.x + coord.x + sx, position.y + coord.y + sy] = figure.nr;

            position.x += sx;
            position.y += sy;

            RefreshBoard();
        }
        public void Turn()
        {
            foreach (Coord coord in figure.coord)
            {
                map[position.x + coord.x, position.y + coord.y] = 0;
            }
            figure.Turn();

            foreach(Coord coord in figure.coord)
            {
                while (position.x + coord.x < 0)
                    position.x++;
                while(position.x+ coord.x>= sizeX)
                    position.x--;
                while(position.y+ coord.y < 0)
                    position.y++;
                while (mapBack[position.x + coord.x, position.y+ coord.y]>0)
                    position.y--;
            }

            foreach (Coord coord in figure.coord)
            {
                map[position.x + coord.x, position.y + coord.y] = figure.nr;
            }
            RefreshBoard();
        }

        private int[,] TrimArray(int[,] massiv, int rowToRemove)
        {
            int[,] result = new int[sizeX, sizeY - 1];
            for (int y = 0, y1 = 0; y < sizeY; y++)
                if (y == rowToRemove)
                    continue;
                else
                {
                    for (int x = 0; x < sizeX; x++)
                        result[x, y1] = massiv[x, y];
                    y1++;
                }
            return result;
        }

        private int[,] AddRow(int[,] massiv)
        {
            int[,] result = new int[sizeX, sizeY];
            int y = sizeY - 1;
            while (y >= 0)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    if (y == 0)
                        result[x, y] = 0;
                    else
                        result[x, y] = massiv[x, y - 1];
                }
                y--;
            }
            return result;
        }
    }
}
