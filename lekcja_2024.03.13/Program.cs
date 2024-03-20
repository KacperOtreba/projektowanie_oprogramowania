#pragma warning disable
namespace lekcja_2024._03._13{
/*
class Przyklad1{
    //pola
    private int wiek;
    public string imie;
    private int wzrost;

    // public private protected internal
    // właściwości
    
    public int Wzrost
    {
        get
        {
            return wzrost;
        }
        set
        {
            wzrost = value;
        }
    }
    // metoda
    public int getWiek()
    {
        return wiek;
    }
    public void setWiek(int Wiek)
    {
        wiek = wiek;
    }
}


//--------------AGREGACJA
class KołoZapas {}

class Auto
{
    KołoZapas koło;
    public void setKoło(KołoZapas Koło)
    {
        koło = Koło;
    }
}

//--------ASOCJACJA
class Nauczyciel {}

class Szkoła
{
    Nauczyciel nau;
    void PrzyjmijNauczycielaDoPracy(Nauczyciel Nau)
    {
        nau = Nau;
    }
}
*/

class Klient {}
class Produkt {}
class Dostawa {}

class Zamówienie{
    Klient k;
    Produkt p;
    Dostawa d;

    public void setKlient(Klient K)
    {
        K = k;
    }

    public void setProdukt(Produkt P)
    {
        P = p;
    }

    public void PrzypiszDostawe(Dostawa D)
    {
        D = d;
    }
}

interface iKomfort
{
    void włączKlime();
}

class Samochód : iKomfort
{
    public void włączKlime()
    {
        System.Console.WriteLine("Chłodzenie włączone.");
    }
}
class Program
{
    
    static void Main(string[] args)
    {
        /*System.Console.WriteLine("Zadanie 1"); // Zadania zrobić w domu

        System.Console.Write("Podaj długość tablicy");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Podaj liczbę: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }*/

        // Przyklad1 p1 = new Przyklad1();

        // p1.Wzrost = 178;
        
        
    }
}
}