namespace Játékbolt;

class Program
{
    static void Main(string[] args)
    {
        Jatek jatek1 = new Jatek("The Witcher 3", "RPG", 12000);
        Jatek jatek2 = new Jatek("FIFA 23", "Sport", 18000);
        Jatek jatek3 = new Jatek("Cyberpunk 2077", "RPG", 15000);

        JatekBolt bolt = new JatekBolt();
        bolt.JatekHozzaadas(jatek1);
        bolt.JatekHozzaadas(jatek2);
        bolt.JatekHozzaadas(jatek3);

        Felhasznalo adam = new Felhasznalo("Ádám", 20000);
        bolt.FelhasznaloHozzaadas(adam);
        Jatek witcher = bolt.KeresJatek("The Witcher 3");
        if (adam.Vasarlas(witcher))
        {
            Console.WriteLine("The Witcher 3 sikeresen megvásárolva!");
        }
        
        adam.Feltoltes(10000);
        Jatek Cyberpunk = bolt.KeresJatek("Cyberpunk 2077");
        if (adam.Vasarlas(Cyberpunk))
        {
            Console.WriteLine("Cyberpunk 2077 sikeresen megvásárolva!");
        }
        
        adam.KonyvtarMegtekintes();
    }
}