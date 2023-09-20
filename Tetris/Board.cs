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
        Figure figure;
        Coord statPosition = new Coord(4, 1);
        Coord position = new Coord(0, 0);
        public Board(Panel panel)
        {
            this.panel = panel;
            InitMap();
            AddFigureOnBoard();
            RefreshBoard();
        }

        void InitMap()
        {
            box = new PictureBox[sizeX, sizeY];
            map = new int[sizeX, sizeY];
            mapBack = new int[sizeX, sizeY];
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
            if(figure != null)
            {
                foreach (Coord coord in figure.coord)
                {
                    map[position.x + coord.x, position.y + coord.y] = 0;
                    mapBack[position.x + coord.x, position.y + coord.y] = figure.nr;
                }
            }

            figure = new Figure();
            position = statPosition;


            Step(0, 0);

        }

        void RefreshBoard()
        {
            for (int x = 0; x < sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                    box[x, y].BackColor = figure.ColorFig(map[x, y] > 0 ? map[x, y] : mapBack[x, y]);
        }
        public void Step(int sx, int sy)
        {
            foreach(Coord coord in figure.coord)
            {
                if (position.x + coord.x + sx < 0 || 
                    position.x + coord.x + sx >= sizeX ||
                    mapBack[position.x + coord.x + sx, position.y + coord.y] > 0)
                    return;

                if(position.y + coord.y + sy >= sizeY || mapBack[position.x + coord.x, position.y + coord.y + sy] > 0)
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
    }
}
