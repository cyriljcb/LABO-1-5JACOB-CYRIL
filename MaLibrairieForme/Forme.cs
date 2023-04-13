using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace MaLibrairieForme
{
    public abstract class Forme : IForme
    {
        protected Coordonnees pointAccroche;

        protected Forme()
        {
            pointAccroche = new Coordonnees();
        }

        public ICoordonnees PointAccroche
        {
            get => pointAccroche;
            set => pointAccroche = (Coordonnees)value;
        }

        public abstract void Affiche();

    }
}
