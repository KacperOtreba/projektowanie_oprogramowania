using System.IO.Pipes;

namespace lekcja_2023._12._13;

class Program
{
    static void Main(string[] args)
    {
        // 1. Zapisz iteracyjnie i rekurencyjnie obliczanie sumy kodów ASCII wpisanego przez usera słowa
        // string input = Console.ReadLine();
        // int suma = 0;
        // foreach (char item in input)
        // {
        //     suma += item;
        // }
        // System.Console.WriteLine(suma);
        // System.Console.WriteLine(SumaASCII("AAA"));
        // 2. Napisz iteracyjnie i rekurencyjnie obliczenie x^n (x do potęgi n)
        System.Console.WriteLine(rekuodej(16,20));
    }
    public static int SumaASCII(string input){
        // 1. Zapisz iteracyjnie i rekurencyjnie obliczanie sumy kodów ASCII wpisanego przez usera słowa
        if (input == "") return 0;
        return SumaASCII(input.Substring(1)) + (int)input[0];

    }

    public static int Potega(int x, int n){
        if (n == 0) return 1;
        return Potega(x, n-1*x);
    }

    public static void EuklidesOdej(int x, int y){
        if (x == y){
            System.Console.WriteLine(x);
            return;
        }     
        if ( x > y) EuklidesOdej(x- y, y);
        else EuklidesOdej(x, y-x);
    }

    static int OdejmowanieEuklidesa(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return OdejmowanieEuklidesa(b, a % b);
        }
    }
}
