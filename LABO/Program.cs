using MaLibrairieForme;
using System.Runtime.CompilerServices;

Rectangle r = new Rectangle();
Rectangle r1 = new Rectangle(1,2);

Carre ca = new Carre();
Carre ca1 = new Carre(2);

Cercle c = new Cercle();
Cercle c1 = new Cercle(2);

r.Affiche();
r1.Affiche();
ca.Affiche();
ca1.Affiche();
c.Affiche();
c1.Affiche();

List<Forme> liste = new List<Forme>();
liste.Add(r);
liste.Add(r1);
liste.Add(ca);
liste.Add(ca1);
liste.Add(c);
liste.Add(c1);

foreach (Forme forme in liste)
{
    Console.WriteLine("les coordonnées de la forme: "+forme);
    //Console.WriteLine($"{forme} ");
    
}

Console.WriteLine("\n--- Affichage de la liste avec les objects implémentant ISommets ---\n");

foreach (Forme s in liste)
{
    if (s is ISommets)
    {
        Console.WriteLine(s);
    }
}

Console.WriteLine("\n--- Affichage de la liste avec les objects n'implémentant pas ISommets ---\n");

foreach (Forme s in liste)
{
    if (!(s is ISommets))
    {
        Console.WriteLine(s);
    }
}

List<Carre> carrelist = new List<Carre>();
Carre car1 = new Carre(1);
Carre car2 = new Carre();
Carre car3 = new Carre(5);
Carre car4 = new Carre(-1);
Carre car5 = new Carre(-3);

carrelist.Add(car1);
carrelist.Add(car2);
carrelist.Add(car3);
carrelist.Add(car4);
carrelist.Add(car5);

Console.WriteLine("\n--- avant le sort() ---");
foreach(Carre car in carrelist)
{
    Console.WriteLine(car);
}
//carrelist.Sort();
Console.WriteLine("\n--- apres le sort() ---");
foreach (Carre car in carrelist)
{ Console.WriteLine(car); }

Console.WriteLine("Liste de formes avant tri :");
foreach (Forme forme in liste)
{
    Console.WriteLine(forme);
}

FormeAbscisseComparer comparer = new FormeAbscisseComparer();
liste.Sort(comparer);

Console.WriteLine("\nListe de formes après tri :");
foreach (Forme forme in liste)
{
    Console.WriteLine(forme);
}