using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Carre : Forme, IEstDans, ISommets, IComparable<Carre>
    {
        #region VARIABLES MEMBRES
        private int lon;
        #endregion

        #region PROPRIETES
        public int Longueur
        {
            get { return lon; }
            set { lon = value; }
        }

        public override string ToString()
        {
            string s = $"({lon},{lon})";
            return s;
        }

        public int NbSommet
        {
            get { return 4; }
        }

        #endregion

        #region CONSTRUCTEURS
        public Carre(int l)
        {
            coor = new Coordonnees();
            lon = l;
        }

        public Carre() : this(0)
        {
        }
        #endregion 

        public int NbSommets => throw new NotImplementedException();
        public override void Affiche()
        {
            Console.WriteLine("Voici les longueurs des côtés du carré : " + ToString());
        }

        public bool CoordonneesEstDans(Coordonnees p)
        {

            if (this.coor.x + this.lon < p.x || this.coor.x > p.x)
                return false;
            if (this.coor.y + this.lon < p.y || this.coor.y > p.y)
                return false;

            return true;
        }

        public int CompareTo(Carre other)
        {
            if (other == null)
            {
                return 1;
            }
            return -lon.CompareTo(other.Longueur);
        }
    }
}