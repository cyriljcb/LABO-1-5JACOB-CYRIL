using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLibrairieForme;

namespace ViewModel
{
    public class RectangleWrapper : FormeWrapper
    {
        private Rectangle RectangleContent => (Rectangle)Content;
        public RectangleWrapper(Rectangle content) : base(content)
        {
        }

        public int Longueur
        {
            get => RectangleContent.Longueur;
            set
            {
                if (value == RectangleContent.Longueur) return;
                RectangleContent.Longueur = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }

        public int Largeur
        {
            get => RectangleContent.Largeur;
            set
            {
                if (value == RectangleContent.Largeur) return;
                RectangleContent.Largeur = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }


        public override double Area => Longueur * Largeur;
    }
}
