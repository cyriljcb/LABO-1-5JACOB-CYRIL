using Infrastructure;
using MaLibrairieForme;

namespace ViewModel
{
    public class CoordonneesWrapper : WrapperBase
    {
        private Coordonnees CoordoneesContent => (Coordonnees)Content;
        public CoordonneesWrapper(): base(content) { }

        public int x
        {
            get => CoordoneesContent.x;
            set
            {
                if(CoordoneesContent.x ==value) 
                    return;
                CoordoneesContent.x = value;
                OnPropertyChanged();
            }
        }

        public int y
        {
            get => CoordoneesContent.y;
            set
            {
                if(CoordoneesContent.y == value)
                    return;
                CoordoneesContent.y = value;
                OnPropertyChanged();
            }
        }
    }
}
