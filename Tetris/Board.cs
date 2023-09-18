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
            mapBack[2, 3] = mapBack[2, 4] = mapBack[2, 5] = 1;
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
