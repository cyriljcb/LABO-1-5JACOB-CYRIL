using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class FormeAbscisseComparer : IComparer<Forme>
    {
        public int Compare(Forme f1, Forme f2)
        {
            if (f1 == null || f2 == null)
            {
                return 0;
            }

            int x1 = f1.coor._x;
            int x2 = f2.coor._x;

            return x1.CompareTo(x2);
        }
    }
}
