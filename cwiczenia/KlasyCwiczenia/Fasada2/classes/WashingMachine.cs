namespace Fasada2.classes;

class Client
{
    public WashingMachine washingMachine;
    public Client(WashingMachine wm)
    {
        washingMachine = wm;
    }
}

class WashingMachine
{

    public void method1() {}

    public Washing washing;
    public Rinsing rinsing;
    public Spinning spinning;

    public WashingMachine()
    {
        washing = new Washing();
        rinsing = new Rinsing();
        spinning = new Spinning();
    }
    public void startWashing() {
        washing.wash();
        rinsing.rinse();
        spinning.spin();
    }
}

class Washing
{
    public void wash()
    {
        System.Console.WriteLine("Mycie");
    }
}

class Rinsing
{
    public void rinse()
    {
        System.Console.WriteLine("Płukanie");
    }
}

class Spinning
{
    public void spin()
    {
        System.Console.WriteLine("Wirowanie");
    }
}