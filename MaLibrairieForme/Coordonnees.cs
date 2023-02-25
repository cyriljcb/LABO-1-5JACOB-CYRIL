using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Coordonnees : IComparable<Coordonnees>
    {
        #region VARIABLES MEMBRES
        public int x;
        public int y;
        #endregion

        #region PROPRIETES
        public int _x
        {
            get { return x; }
            set { x = value; }
        }
        public int _y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            //string s = $"({x},{y})";
            string s = $"({_x},{_y})";
            return s;
        }
        #endregion

        #region CONSTRUCTEURS
        public Coordonnees(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public Coordonnees()
        {
            /* Coordonnees(0,0);*/
            Coordonnees c = new Coordonnees(0, 0);
        }
        #endregion
        public int CompareTo(Coordonnees other)
        {
            return x.CompareTo(other.x);
        }


    }
}
