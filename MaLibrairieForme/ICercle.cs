namespace MaLibrairieForme
{
    public interface ICercle
    {
        int _ray { get; set; }

        void Affiche();
        bool CoordonneesEstDans(Coordonnees p);
        string ToString();
    }
}