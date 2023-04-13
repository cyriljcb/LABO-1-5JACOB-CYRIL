namespace MaLibrairieForme
{
    public interface ICoordonnees
    {
        int _x { get; set; }
        int _y { get; set; }

        int CompareTo(Coordonnees other);
        string ToString();
    }
}