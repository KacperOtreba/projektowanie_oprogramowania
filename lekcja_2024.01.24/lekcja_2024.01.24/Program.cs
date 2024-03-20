namespace lekcja_2024._01._24
{
    class Wierzchołek
    {
        List<int> Połączenia = new List<int>();
        
        public void DodajPołączenie(int w)
        {
            Połączenia.Add(w);
        }

        public void WypiszPołączenia()
        {
            foreach (var item in Połączenia)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }

        public List<int> PobierzPołączenia()
        {
            return this.Połączenia;
        }
    }
    class Graf
    {
        List<Wierzchołek> Wierzchołki = new List<Wierzchołek>();

        public Graf(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Wierzchołki.Add(new Wierzchołek());
            }
        }

        public void DodajKrawędź(int w, params int[] połącz)
        {
            foreach (var item in połącz)
            {
                Wierzchołki[w].DodajPołączenie(item);
            }
        }

        public void WypiszKrawędzie(int w)
        {
            
            foreach (var item in Wierzchołki[w].PobierzPołączenia())
            {
                
                Console.Write($"{w}-{item} ");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Graf G = new Graf(6);
            G.DodajKrawędź(0, 1, 2 );
            G.DodajKrawędź(1, 0, 3 );
            G.DodajKrawędź(2, 0, 3, 5);
            G.DodajKrawędź(3, 1, 2, 5);
            G.DodajKrawędź(5, 2, 3);

            for (int i = 0; i < 6; i++)  // 0-1, 0-2
            {
                G.WypiszKrawędzie(i);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}