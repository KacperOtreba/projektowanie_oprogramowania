using UML.classes;
namespace UML;

class Program
{
    static void Main(string[] args)
    {
        Plik z1 = new Plik();
        z1.Name = "foto1";
        Plik z2 = new Plik();
        z2.Name = "foto2";

        Plik p1 = new Plik();
        p1.Name = "praca1";
        Plik p2 = new Plik();
        p2.Name = "praca2";

        Catalog k2 = new Catalog();
        k2.Name = "Prace";
        k2.dodaj(p1);
        k2.dodaj(p2);

        Catalog k1 = new Catalog();
        k1.Name = "Zdjęcia";



        k1.dodaj(z1);
        k1.dodaj(z2);

        Catalog d1 = new Catalog();
        d1.Name = "Disk";

        d1.dodaj(k2);
        d1.dodaj(k1);

        d1.wyświetl();
    }
}
