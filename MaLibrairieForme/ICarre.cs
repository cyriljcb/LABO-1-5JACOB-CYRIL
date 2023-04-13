namespace MaLibrairieForme
{
    public interface ICarre
    {
        int Longueur { get; set; }
        int NbSommet { get; }
        int NbSommets { get; }

        void Affiche();
        int CompareTo(Carre other);
        bool CoordonneesEstDans(Coordonnees p);
        string ToString();
    }
}