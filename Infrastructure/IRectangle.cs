using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IRectangle : IForme
    {
        int Longueur { get; set; }
        int Largeur { get; set; }
    }
}
