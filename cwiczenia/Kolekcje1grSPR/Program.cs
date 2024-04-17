using System.Collections;

namespace Kolekcje
{
    static class Program
    {
        static void Main(string[] args)
        {
        // 0. User wczytuje do tablicy 11 dowolnych cyfr zapisujac je w jednej lini oddzielajac spacjami.
        // Napisz program, ktory stwierdzi czy tablica jest WIELKOMIEJSKA czy MALOROLNA.
        // Wielkomiejska jest wtedy kiedy wiecej elementow ma wartosc powyzej sredniej wartosci liczb w tej talicy,
        // a molorolna gdy wiecej elementow ma wartosc ponizej sredniej
        // Czy istnieje tablica malomiasteczkowa, czyli taka, ktora mialaby tyle samo elementow powyzej i ponizej sredniej?  NIE
        // Jesli tak zadeklaruj ja w programi z reki

        System.Console.WriteLine("Zadanie 0");
        string[] cyfrystr = Console.ReadLine()!.Split(" ");

        int[] cyfry = Array.ConvertAll(cyfrystr, int.Parse);

        // 1 1 1 1 1 1 1 1 1 9 9 
        double avg = cyfry.Sum() / 11;

        int ileW = 0;
        int ileM = 0;
        foreach (var item in cyfry)
        {
            if (item > avg)
            {
                ileW++;
            }
            if (item < avg)
            {
                ileM++;
            }
        }

        if (ileW > cyfry.Length / 2)
        {
            Console.WriteLine("Wielkomiejska");
        }
        if (ileM > cyfry.Length / 2)
        {
            Console.WriteLine("Malorolna");
        }
        if (ileW == ileM)
        {
            System.Console.WriteLine("Malomiasteczkowa");
        }

        Console.WriteLine();


        // 1. Stworz losowa tablice 30 liczb trzycyfrowych. Znajdz w niej najdluzszy spojny podciag ROSNACY. Podaj sume elementow w tym podciagu, element poczatkowy oraz koncowy.
        // Jesli jest kilka takich podciagow o tej samej dlugosci podaj ten, kory wystepuje w niej jako pierwszy z prawej.
        // Wyswietla: cala tablice, element poczatkowy podciagu, element koncowy podciagu i sume elemenentow w tym podciagu
            System.Console.WriteLine("Zadanie 1");
            Random random = new Random();
            int[] array = new int[30];

            for (int i = 0; i < 30; i++)
            {
                array[i] = random.Next(100,1000);
                System.Console.Write(array[i] + " ");
            }

            List<List<int>> podciags = new List<List<int>>();
            List<int> podciag = new List<int>();

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i-1] < array[i])
                {
                    podciag.Add(array[i-1]);
                    podciag.Add(array[i]);
                }
                else if (array[i-1] >= array[i] || i == array.Length - 1)
                {
                    podciags.Add(podciag.Distinct().ToList());
                    // foreach (var item in podciag.Distinct().ToList())
                    // {
                    //     System.Console.Write(item + " ");
                    // }
                    // System.Console.WriteLine();
                    podciag.Clear();
                    
                }
            }


            int najdluzszy = 0;
            int dlugosc = 0;

            for (int i = 0; i < podciags.Count; i++)
            {
                if (podciags[i].Count >= dlugosc)
                {
                    dlugosc = podciags[i].Count;
                    najdluzszy = i;
                }
            }

            System.Console.WriteLine();

            System.Console.WriteLine(podciags[najdluzszy].ElementAt(0));
            System.Console.WriteLine(podciags[najdluzszy].ElementAt(podciags[najdluzszy].Count -1));
            System.Console.WriteLine(podciags[najdluzszy].Sum());

            // 2. Zbior cyfr od 0 do 9. Stworz dwie losowe list 6-elementowe.
            // W jednej z nich ma wystepowac 6 roznych elementow np [1,2,3,4,5,6] z powtorzeniamiy,
            // a w drugiej 3 rozne elementy. PRZEMYSL DOBRZE GENEROWANIE DRUGIEJ Z LIST.
            // Stworz lsite wynikowa, ktora bedzie zawierala pojdedyncze elementy - wszystkie mozliwe cyfry takie ze:
            // - nie moze tam sie znalesc zaden element, ktory wystepuje lacznie tylko raz w dwoch powyzszych list.
            // - jesli elementy wystepuje lacznie w dwoch listach czesciej niz 2 razy to ma sie pojawic w wynikowej 2 razy
            // Dla powyzszych tablic tablica wynikowa sklada sie z [1,1,2,3,3,7,8,9]. 
            // Na wyjsciu wyswietl w 3 kolejnych wierszach wszystkie 3 listy.
            System.Console.WriteLine("Zadanie 2");
            List<int> lista1 = new();
            List<int> lista2 = new();
            
            for (int i = 0; i < 6;)
            {
                int cyfra = random.Next(0, 10); // może być od 1,10 ale cyfry są od 0
                if (!lista1.Contains(cyfra))
                {
                    lista1.Add(cyfra);
                    i++;
                }
            }

            int[] losoweC = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int cyfra1 = random.Next(0, 10); // może być od 1,10 ale cyfry są od 0
                if (!losoweC.Contains(cyfra1))
                {
                    losoweC[i] = cyfra1;
                }
            }

            for (int i = 0; i < 6; i++)
            {

                lista2.Add(losoweC[random.Next(0,3)]);
            }

            // lista1.Clear();
            // lista2.Clear();
            // lista1.Add(1);
            // lista1.Add(2);
            // lista1.Add(3);
            // lista1.Add(4);
            // lista1.Add(5);
            // lista1.Add(6);

            // lista2.Add(1);
            // lista2.Add(1);
            // lista2.Add(1);
            // lista2.Add(2);
            // lista2.Add(3);
            // lista2.Add(3);

            List<int> listaW = new();

            for (int i = 0; i < 10; i++) // jeśli cyfry są od 1 to tutaj też zmiana
            {
                int liczbaWystapien = 0;
                for (int j = 0; j < lista1.Count; j++)
                {
                    if (i == lista1[j])
                    {
                        liczbaWystapien++;
                    }
                    if (i == lista2[j])
                    {
                        liczbaWystapien++;
                    }
                }
                if (liczbaWystapien == 1) {}
                else if (liczbaWystapien > 2)
                {
                    listaW.Add(i);
                    listaW.Add(i);
                }
                else
                {
                    listaW.Add(i);
                }
                
            }

            foreach (var item in lista1)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
            
            foreach (var item in lista2)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();

            foreach (var item in listaW)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();

            // 3. 
            System.Console.WriteLine("Zadanie 3");
            string[] alfa = new string[] {"A","B","C","D"};
            
            ArrayList listaaa = new ArrayList();
            for (int i = 0; i < 30; i++)
            {
                string ciag = "";
                for (int j = 0; j < 3; j++)
                {
                    ciag += alfa[random.Next(0,3)];
                }
                listaaa.Add(ciag);
            }

            foreach (var item in listaaa)
            {
                System.Console.Write(item + " ");
            }

            List<string> pary = new();


            
            foreach (var item1 in listaaa)
            {
                string slowo1 = item1.ToString()!;
                foreach (var item2 in listaaa)
                {
                    string slowo2 = item2.ToString()!;
                    if (CzyAnagram(slowo1, slowo2) && slowo1 != slowo2)
                    {
                        pary.Add($"{slowo1} - {slowo2},");
                    }
                }
            }

            System.Console.WriteLine();
            foreach (var item in pary.Distinct().ToList())
            {
                System.Console.Write(item+" ");
            }
            System.Console.WriteLine(pary.Count);

        }
        
        static bool CzyAnagram(string slowo1, string slowo2)
        {
            char[] c1 = slowo1.ToCharArray();
            char[] c2 = slowo2.ToCharArray();
            Array.Sort(c1);
            Array.Sort(c2);
            for (int i = 0; i < slowo1.Length; i++)
            {
                if (c1[i] != c2[i])
                {
                    return false;
                }
            }
            return true;
        } 
    }

}