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
        
    }
}
