using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public abstract class Forme
    {
        #region VARIABLES MEMBRES
        public Coordonnees coor;
        #endregion  

        #region PROPRIETES
        public abstract void Affiche();

        #endregion

        #region CONSTRUCTEURS
        public Forme()
        {
            coor = new Coordonnees();
        }
        #endregion
    }
}
