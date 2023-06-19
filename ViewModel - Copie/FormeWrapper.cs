using Infrastructure;
using MaLibrairieForme;

namespace ViewModel
{
    public abstract class FormeWrapper : WrapperBase
    {
        private Forme ContentForme => (Forme)Content;
        public CoordonneesWrapper PointAccroche { get; set; }

        protected FormeWrapper(object content) : base(content)
        {
            PointAccroche = new CoordonneesWrapper(ContentForme.PointAccroche);
        }

        public abstract double Area { get; }

        public override string ToString()
        {
            return Content.ToString();
        }
    }
}
