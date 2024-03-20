using System.Net.Http.Headers;
using System.Collections;
namespace lekcja_2024._03._20;

class Program
{
    static void Main(string[] args)
    {
        /* 1. Wpisz do tablicy T 5 losowych liczb dwucyfrowych. 
        Stwórz tablicę W liczb parzystych znajdujących się między 
        minimalną i maksymalną wartością z tablicy T.*/
        System.Console.WriteLine("Zadanie 1");
        Random r = new Random();
        int[] T = new int[5];
        for (int i = 0; i < T.Length; i++)
        {
            T[i] = r.Next(10,100);
        }

        int max = T[0];
        for (int i = 0; i < T.Length; i++)
        {
            if (T[i] > max)
            {
                max = T[i];
            }
        }

        int mini = T[0];
        for (int i = 0; i < T.Length; i++)
        {
            if (T[i] < mini)
            {
                mini = T[i];
            }
        }

        foreach (var item in T)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine("\n");
        System.Console.WriteLine(max);
        System.Console.WriteLine(mini);
        // 12 22 56 64 96
        
        int[] W = new int[(max-mini)/2];
        int index = 0;
        for (int i = mini + 1; i < max; i++)
        {
            if (i % 2 == 0)
            {
                W[index] = i;
                index++;
            }
        }

        foreach (var item in W)
        {
            System.Console.Write(item + ", ");
        }
        System.Console.WriteLine("\n");

        /*2. Utwórz ArrayListę A zawierającą 10 losowych słów 3-literowych. 
        Wypisz słowo o najwiekszej sumie kodów ASCII jego liter*/
        System.Console.WriteLine("Zadanie 2");
        ArrayList A = new ArrayList();
        List<int> sumaASCII = new();
        string alfabet =  "ABCDEFGHIJKLMNOPRSTUWZYZ";
        for (int i = 0; i < 10; i++)
        {
            string slowko = "";
            int sumka = 0;
            for (int j = 0; j < 3; j++)
            {
                int los = r.Next(0,alfabet.Length);
                string literka = Convert.ToString(alfabet[los]);
                slowko += literka;
                sumka += Convert.ToChar(literka);
            }
            A.Add(slowko);
            sumaASCII.Add(sumka);
        }
        foreach (var item in A)
        {
            System.Console.Write(item + ", ");
        }
        int najchar = sumaASCII.Max();
        int indeks = sumaASCII.IndexOf(najchar);
        string slowo = A[indeks]!.ToString()!;
        System.Console.WriteLine("Najwięcej: "+sumaASCII.Max()+ " Słowo: "+slowo);

        System.Console.WriteLine("\n");


        // 4. Stwórz słownik D z kluczami i = 1, 2, 3 ... n (user podaje n) 
        // oraz wartościami w postaci listy maksymalnie (i-1)-cyfrowych dzielników 
        // liczby 10 do potęgi i dla każdego z kluczy.
        System.Console.WriteLine("Zadanie 4");
        int n = int.Parse(Console.ReadLine()!);

        Dictionary<int, List<int>>  D = new Dictionary<int, List<int>>();
        List<int> TL = new();

        for (int i = 1; i <= n; i++)
        {
            // gdy i == 2 to Math.Pow da 10
            TL = new();
            for (int j = 1; j < Math.Pow(10,i-1); j++)
            {
                if (Math.Pow(10,i) % j == 0)
                {
                    TL.Add(j);
                }
            }
            D.Add(i, TL);
        }

        foreach (var item in D)
        {
            System.Console.Write(item.Key + " => ");
            foreach (var item1 in item.Value)
            {
                System.Console.Write(item1 + " ");
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine();
        
        // 5. Korzystając ze słownika utwórz graf G zbudowany 
        // z n wierzchołków i k krawędzi. 
        // Policz wierzchołki nie mające żadnych sąsiadów.
        System.Console.WriteLine("Zadanie 5");
    }
}
