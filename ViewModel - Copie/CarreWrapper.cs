using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLibrairieForme;

namespace ViewModel
{
    public class CarreWrapper : FormeWrapper
    {
        private Carre CarreContent => (Carre)Content;

        public CarreWrapper(Carre content) : base(content)
        {
        }

        public int Longueur
        {
            get => CarreContent.Longueur;
            set
            {
                if (value == CarreContent.Longueur) return;
                CarreContent.Longueur = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }

        public override double Area => Longueur * Longueur;
    }
}
