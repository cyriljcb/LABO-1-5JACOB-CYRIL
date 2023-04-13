using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class FormeAbscisseComparer : IComparer<Forme>
    {
        public int Compare(Forme? forme1, Forme? forme2)
        {
            return forme1.PointAccroche.X - forme2.PointAccroche.X;
        }
    }
}
