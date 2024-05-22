using System.Linq.Expressions;

namespace Drugie_zadanie.classes;

class Przystanek
{
    protected List<Przystanek> przystanki;

    protected List<string> autobusy;

    private void addAutobus(string linia)
    {
        autobusy.Add(linia);
    }

    protected bool MaZadaszenie(bool ma)
    {
        if (ma)
        {return true;}
        else
        {return false;}
    }

    protected bool MaBiletomat(bool ma)
    {
        if(ma)
        {return true;}
        else
        {return false;}
    }

}

class PrzystanekNaŻądanie : Przystanek
{

}

class PunktCentralny : Przystanek
{

}

class Pętla : Przystanek
{

}

class Biletomat
{}

