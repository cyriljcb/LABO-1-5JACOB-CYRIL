using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface ICarre : IForme
    {
        int Longueur { get; set; }

        string Couleur { get; set; }
        string Course { get; set; }
    }
}
