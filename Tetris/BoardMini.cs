using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class BoardMini
    {
        int sizeX = 4;
        int sizeY = 4;

        PictureBox[,] box;
        Panel panel;
        Coord position = new Coord(1, 1);
        Color backColor = Color.WhiteSmoke;

        public BoardMini(Panel panel)
        {
            this.panel = panel;
            InitMap();
        }

        void InitMap()
        {
            box = new PictureBox[sizeX, sizeY];
           
            int boxSize = panel.Width / sizeX;

            for (int x = 0; x < sizeX; x++)
                for (int y = 0; y < sizeY; y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.Location = new Point(x * boxSize - 1, y * boxSize - 1);
                    picture.Size = new Size(boxSize, boxSize);
                    picture.BackColor = backColor;
                    picture.BorderStyle = BorderStyle.FixedSingle;
                    panel.Controls.Add(picture);
                    box[x, y] = picture;                  
                }
        }

        public void RefreshBoard(Figure figure)
        {
            foreach(PictureBox picture in box)
            {
                picture.BackColor = backColor;
            }
            foreach(Coord coord in figure.coord)
            {
                box[position.x + coord.x, position.y + coord.y].BackColor = figure.ColorFig(figure.nr);
            }
        }
    }
}
