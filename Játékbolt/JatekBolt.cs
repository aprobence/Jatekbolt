namespace Játékbolt;

internal class JatekBolt
{
    public List<Jatek> Jatekok { get; set; }
    public List<Felhasznalo> Felhasznalok { get; set; }

    public JatekBolt()
    {
        Jatekok = new List<Jatek>();
        Felhasznalok = new List<Felhasznalo>();
    }

    public void JatekHozzaadas(Jatek jatek)
    {
        Jatekok.Add(jatek);
    }

    public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)
    {
        Felhasznalok.Add(felhasznalo);
    }

    public Jatek KeresJatek(string cim)
    {
        foreach (var j in Jatekok)
        {
            if (j.Cim == cim)
            {
                return j;
            }
        }
        return null;
    }

    public Felhasznalo KeresFelhasznalo(string cim)
    {
        foreach (var f in Felhasznalok)
        {
            if (f.Nev == cim)
            {
                return f;
            }
        }
        return null;
    }
}