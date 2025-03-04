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
    }

    public bool Vasarlas(Jatek jatek)
    {
        foreach (var j in Konyvtar)
        {
            if (j == jatek  | Egyenleg < jatek.Ar)
            {
                return false;
            }
        }
        return true;
    }

    public void KonyvtarMegtekintes()
    {
        Console.WriteLine($"{Nev} játékai:");
        foreach (var j in Konyvtar)
        {
            Console.Write($"{j} ");
        }
    }

    public void Feltoltes(int osszeg)
    {
        Egyenleg += osszeg;
        Console.WriteLine($"A feltöltés megtörtént, {Egyenleg} összeg van az egyenlegeden.");
    }
}