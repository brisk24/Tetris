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
            figure = new Figure();
            position = statPosition;


            foreach (Coord coord in figure.coord)
                mapBack[position.x + coord.x, position.y + coord.y] = 1;
            RefreshBoard();
        }

        void RefreshBoard()
        {
            for (int x = 0; x < sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                {
                    box[x, y].BackColor = mapBack[x, y] == 0 ? SystemColors.ControlLightLight : Color.Black;
                }
        }

    }
}
