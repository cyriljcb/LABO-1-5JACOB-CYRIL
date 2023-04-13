using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace MaLibrairieForme
{
    public class Coordonnees : ICoordonnees
    {
        public Coordonnees() : this(0, 0) { }

        public Coordonnees(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
