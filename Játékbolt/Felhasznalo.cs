namespace Játékbolt;

internal class Felhasznalo
{
    public string Nev { get; set; }
    public int Egyenleg { get; set; }
    public List<Jatek> Konyvtar { get; set; }

    public Felhasznalo(string nev, int egyenleg)
    {
        Nev = nev;
        Egyenleg = egyenleg;
        Konyvtar = new List<Jatek>();
    }

    public bool Vasarlas(Jatek jatek)
    {
        foreach (var j in Konyvtar)
        {
            if (j == jatek || Egyenleg < jatek.Ar)
            {
                return false;
            }
        }
        Konyvtar.Add(jatek);
        return true;
    }

    public void KonyvtarMegtekintes()
    {
        Console.WriteLine($"A megvásárolt játékok:");
        foreach (var j in Konyvtar)
        {
            Console.WriteLine($"- {j.Cim}");
        }
    }

    public void Feltoltes(int osszeg)
    {
        Egyenleg += osszeg;
        Console.WriteLine($"A feltöltés megtörtént: +{osszeg} Ft");
    }
}