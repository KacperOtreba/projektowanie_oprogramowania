using System.Collections;

namespace lekcja_2024._02._28;

class Program
{

    static int fibo(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 1;
        return fibo(n-1) + fibo(n-2);
    }
    static void Main(string[] args)
    {
        // Zadanie 1
        // int[] T1 = new int[115];
        // T1[0] = 3;
        // for (int i = 1; i < T1.Length; i++)
        // {
        //     T1[i] = T1[i-1] + 4;
        // }

        // Zadanie 2
        // StreamReader sr = new StreamReader(@"E:\projektowanie_oprogramowania\lekcja_2024.02.28\osoby.txt");
        // string[] linia = new string[3];
        // Osoba[] Osoby = new Osoba[5];
        // int licznik = 0;

        // while (!sr.EndOfStream)
        // {
        //     linia = sr.ReadLine().Split(";");
            
        //     Osoba os = new Osoba();
        //     os.imie = linia[0];
        //     os.nazwisko = linia[1];
        //     os.wiek = Convert.ToInt32(linia[2]);
        //     // System.Console.WriteLine($"{os.imie} {os.nazwisko} {os.wiek}");
        //     Osoby[licznik] = os;
        //     licznik++;
        // }
        // sr.Close();
        // foreach (var item in Osoby)
        // {
        //     System.Console.Write(item.imie + " " + item.nazwisko + " " + item.wiek + "\n");
        // }


        // Zadanie 3
        // List<char> samogloski = new List<char>{'a', 'e', 'i', 'o', 'u', 'y'};
        // List<string> slowa = new List<string>();

        // Random r = new Random();
        // string slowo;
        // int liczba;

        // for (int i = 0; i < 6; i++)
        // {
        //     List<char> samogloskiC = new List<char>(samogloski);
        //     slowo = "";
        //     for (int j = 0; j < 3; j++)
        //     {
        //         liczba = r.Next(0,samogloskiC.Count);
        //         slowo += samogloskiC[liczba];
        //         samogloskiC.RemoveAt(liczba);
        //     }
        //     slowa.Add(slowo);

        //     samogloskiC = samogloski;
        // }

        // foreach (var item in slowa)
        // {
        //     System.Console.Write(item + " ");
        // }



        // Zadanie 4
        // ArrayList FIBO = new ArrayList();
        // int x = 1;
        // while (fibo(x) < 100)
        // {
        //     FIBO.Add(fibo(x));
        //     x++;

        // }

        // foreach (var item in FIBO)
        // {
        //     System.Console.Write(item + " ");
        // }

        // Random rand = new Random();
        // Queue q = new Queue();
        // int nr;
        // for (int i = 0; i < 4; i++)
        // {
        //     q.Enqueue(FIBO[rand.Next(0, FIBO.Count)]);
        // }

        // foreach (var item in q)
        // {
        //     System.Console.Write(item+" ");
        // }
        // System.Console.WriteLine("\n");

        // foreach (var item in q)
        // {
        //     System.Console.Write(item+" ");
        // }
        // System.Console.WriteLine();
        // q.Dequeue();
        // q.Dequeue();
        // foreach (var item in q)
        // {
        //     System.Console.Write(item+" ");
        // }


        // Zadanie 5
        int[] T = new int[] {11,13,17,19,23};
        
        Stack<int> s = new Stack<int>();
        for (int i = 0; i < 5; i++)
        {
            s.Push(T[i]);
        }

        foreach (var item in s)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine("\n");

        s.Pop();
        s.Pop();
        s.Pop();

        foreach (var item in s)
        {
            System.Console.Write(item + " ");
        }
    }
    struct Osoba
    {
        public string imie;
        public string nazwisko;
        public int wiek;
    }
}
