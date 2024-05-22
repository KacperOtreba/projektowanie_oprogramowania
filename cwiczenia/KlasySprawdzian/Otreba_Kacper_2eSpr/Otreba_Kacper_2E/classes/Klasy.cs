using System.ComponentModel.Design;

namespace Otreba_Kacper_2E.classes;

public class Zadanie : IRobotny
{
    public string Robota { get; set; }
    public void Działaj(Zadanie z)
    {
        System.Console.WriteLine($"Wykonuje zadanie: "+z);
    }

    public void planuj()
    {
        System.Console.WriteLine("Zaplanowałem zadanie");
    }
}

public interface IRobotny
{
    
    string Robota { get; set;}
    void planuj();


    void Działaj(Zadanie zadanie);
}

class Klasa
{
    public string numerKlasy { get; set; }
    protected List<IRobotny> ListaRobotnych { get; set; }
    private Teknikum teknikum;

    public Klasa()
    {
        teknikum = new();
    }

    public void dodajDoListy(IRobotny rob)
    {
        ListaRobotnych.Add(rob);
    }
}

class Narzędzie : Rekin
{
    public string NazwaNarzędzia { get; set; }
}

class Rekin : IRobotny
{
    public string Robota { get; set; }
    private string imie { get; set; }
    private string nazwisko { get; set; }

    public void Działaj(Zadanie z)
    {
        System.Console.WriteLine($"Wykonuje zadanie: "+z);
    }

    public void planuj()
    {
        System.Console.WriteLine("Zaplanowałem zadanie");
    }

    protected void dobierzNarzędzie(Narzędzie n)
    {
        System.Console.WriteLine("Dobieram narzędzie: "+n.NazwaNarzędzia);
    }
}

class Leszcz : IRobotny
{
    public string Robota { get; set; }
    private string imie;
    private string odmiana;

    protected void wymyślajWymówki()
    {
        System.Console.WriteLine("Jestem bardzo chory.");
    }

    private void czekaj()
    {
        System.Console.WriteLine("Czekam");
    }

    public void udawaj()
    {
        System.Console.WriteLine("Jestem bardzo chory. (Nie jestem)");
    }

    public void planuj()
    {
        System.Console.WriteLine("Zaplanowałem zadanie");
    }

    public void Działaj(Zadanie z)
    {
        System.Console.WriteLine($"Wykonuje zadanie: "+z);
    }
}

class Gracz : IRobotny
{
    private string imie;
    private int poziom;

    public string Robota { get; set; }

    protected void idęGrać()
    {
        System.Console.WriteLine("Teraz idę grać");
    }

    private void jem()
    {
        System.Console.WriteLine("Teraz jem.");
    }

    private bool wydalam()
    {
        System.Console.WriteLine("Aktualnie wydalam.");
        return true;
    }
    
    protected char znówIdęGrać()
    {
        return 'T';
    }

    public void planuj()
    {
        System.Console.WriteLine("Zaplanowałem zadanie");
    }

    public void Działaj(Zadanie z)
    {
        System.Console.WriteLine($"Wykonuje zadanie: "+z);
    }
}



class Szkoła
{
    private string kraj;
    private List<Szkoła> szkoły;
    
    protected Szkoła()
    {
    }

    public void stwórzSzkołę()
    {
        szkoły = new();
    } 
}

class Teknikum : Szkoła
{
    private string nazwa;

    public string podajNazwę { get; set; }
}