using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Cercle : Forme, IEstDans, ICercle
    {
        #region VARIABLES MEMBRES
        public int ray;
        #endregion

        #region PROPRIETES
        public int _ray
        {
            get { return ray; }
            set { ray = value; }
        }
        public override string ToString()
        {
            string s = $"({ray})";
            return s;
        }
        #endregion

        #region CONSTRUCTEURS
        public Cercle(int l)
        {
            ray = l;
        }

        public Cercle()
        {
            Cercle c = new Cercle(0);
        }
        #endregion

        public override void Affiche()
        {
            Console.WriteLine("Voici le rayon du cercle : " + ToString());

        }

        public bool CoordonneesEstDans(Coordonnees p)
        {
            int distanceAuCarre = (p.x - this.coor.x) * (p.x - this.coor.x) + (p.y - this.coor.y) * (p.y - this.coor.y);
            int rayonAuCarre = this.ray * this.ray;
            return distanceAuCarre <= rayonAuCarre;

        }
    }
}
