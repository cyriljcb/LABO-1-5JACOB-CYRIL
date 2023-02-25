using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Rectangle : Forme, IEstDans, ISommets
    {

        #region VARIABLES MEMBRES
        public int Lon;
        public int larg;
        #endregion

        #region PROPRIETES
        public int _Lon
        {
            get { return Lon; }
            set { Lon = value; }
        }

        public int NbSommets => throw new NotImplementedException();

        public override string ToString()
        {
            string s = $"({Lon},{larg})";
            return s;
        }
        #endregion

        #region CONSTRUCTEURS
        public Rectangle(int l, int la)
        {
            Lon = l;
            larg = la;
        }

        public Rectangle()
        {
            Rectangle c = new Rectangle(0, 0);
        }
        #endregion

        public override void Affiche()
        {
            Console.WriteLine("Voici la longueur et la largeur des côtés du rectangle: " + ToString());

        }
        public int NbSommet
        {
            get { return 4; }
        }

        public bool CoordonneesEstDans(Coordonnees p)
        {
            if (p.x >= coor.x && p.x <= coor.x + Lon && p.y >= coor.y && p.y <= coor.x - larg)
                return true;
            else
                return false;
        }
    }
}
