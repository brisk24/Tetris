using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public struct Coord
    {
        public int x, y;

        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Figure
    {
        public Coord[] coord { private set; get; }
        static Random rnd = new Random();
        public int nr { private set; get; }

        Color[] figureColor = new Color[]
        {
            Color.WhiteSmoke,
            Color.Green,
            Color.Red,
            Color.Black,
            Color.OrangeRed,
            Color.Purple,
            Color.DarkBlue,
            Color.Gold
        };

        int polFigure;
        public Figure()
        {
            nr = rnd.Next(1, 8);
            polFigure = rnd.Next(0, 5);

            Turn();

        }
        public void Turn()
        {
            switch (nr)
            {
                case 1: Figure_I(); break;
                case 2: Figure_O(); break;
                case 3: Figure_L(); break;
                case 4: Figure_J(); break;
                case 5: Figure_T(); break;
                case 6: Figure_Z(); break;
                case 7: Figure_S(); break;
                default: coord = null; break;
            }
        }
        void Figure_I()
        {
            if (polFigure >= 2)
                polFigure = 0;

            polFigure++;

            switch (polFigure)
            {
                case 1:
                    coord = new Coord[]
                {
                     new Coord(1, 0),
                     new Coord(1, 1),
                     new Coord(1, 2),
                     new Coord(1, 3),
                };
                break;

                case 2:
                    coord = new Coord[]
                {
                     new Coord(-1, 0),
                     new Coord(0, 0),
                     new Coord(1, 0),
                     new Coord(2, 0),
                };
                break;
            }

        }

        void Figure_O()
        {
            if (polFigure >= 1)
                polFigure = 0;

            polFigure++;

            switch (polFigure)
            {
                case 1:

                    coord = new Coord[]
                    {
                       new Coord(0,0),
                       new Coord(1,0),
                       new Coord(0,1),
                       new Coord(1,1),
                    }; 
                break;
            };

        }



        //todo: Написать повороты для остальных фигур
        void Figure_L()
        {
            coord = new Coord[]
            {
                new Coord(0, 0),
                new Coord(0, 1),
                new Coord(0, 2),
                new Coord(1, 2),
            };
        }

        void Figure_J()
        {
            coord = new Coord[]
            {
                new Coord(1,0),
                new Coord(1,1),
                new Coord(1,2),
                new Coord(0,2),
            };
        }

        void Figure_T()
        {
            coord = new Coord[]
            {
                new Coord(1, 0),
                new Coord(1, 1),
                new Coord(0, 1),
                new Coord(2, 1),
            };
        }

        void Figure_Z()
        {
            coord = new Coord[]
            {
                new Coord(0, 0),
                new Coord(1, 0),
                new Coord(1, 1),
                new Coord(2, 1),
            };
        }

        void Figure_S()
        {
            coord = new Coord[]
           {
                new Coord(0, 0),
                new Coord(1, 0),
                new Coord(0, 1),
                new Coord(-1, 1),
           };
        }

        public Color ColorFig(int number)
        {
            return figureColor[number];
        }

    }
}
