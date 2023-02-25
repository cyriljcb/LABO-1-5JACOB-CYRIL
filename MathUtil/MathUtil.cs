using System;

namespace MaLibrairieMath
{
    public static class MathUtil
    {
        public static double CalculerSurfaceCarre(int cote)
        {
            return cote * cote;
        }

        public static double CalculerSurfaceRectangle(int L,int l)
        {
            return l * L;
        }

        public static double CalculerSurfaceCercle(int rayon)
        {
            return Math.PI * rayon * rayon;
        }

        public static bool EstComprisEntre(int valeur, int min, int max)
        {
            return valeur >= min && valeur <= max;
        }
    }
}
