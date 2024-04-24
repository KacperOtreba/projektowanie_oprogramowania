using Fasada2.classes;
namespace Fasada2;

class Program
{
    static void Main(string[] args)
    {
        WashingMachine pralka = new WashingMachine();
        Client baba = new Client(pralka);
        baba.washingMachine.startWashing();
    }
}
