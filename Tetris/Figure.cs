using System;
using System.Collections.Generic;
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
        public Figure()
        {
            Figure_I();
        }

        void Figure_I()
        {
            coord = new Coord[]
            {
                new Coord(-1, 0),
                new Coord(0, 0),
                new Coord(1, 0),
                new Coord(2, 0),
            };
        }
    }
//todo: Добавить методы для создания всех фигур
    // I O L J T Z S
}
