using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLibrairieForme;

namespace ViewModel
{
    public class CercleWrapper : FormeWrapper
    {
        private Cercle CercleContent => (Cercle)Content;
        public CercleWrapper(Cercle cercle) : base(cercle)
        {
        }

        public int Rayon
        {
            get => CercleContent.Rayon;
            set
            {
                if (value == CercleContent.Rayon) return;
                CercleContent.Rayon = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }

        public override double Area => Math.PI * Rayon * Rayon;
    }
}
