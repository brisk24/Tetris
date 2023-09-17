using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    class Board
    {
        int sizeX = 10;
        int sizeY = 20;

        PictureBox[,] box;
        Panel panel;
        public Board(Panel panel)
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
                    picture.BackColor = SystemColors.ControlLightLight;
                    picture.BorderStyle = BorderStyle.FixedSingle;

                    panel.Controls.Add(picture);
                    box[x, y] = picture;
                }       
        }
    }
}
