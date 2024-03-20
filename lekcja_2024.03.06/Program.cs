namespace lekcja_2024._03._06{
class Program
{
    static void Main(string[] args)
    {
        // 6. Stwórz jakiś prosty graf 1 => 2, 3 ; 2 => 3 ; 3 => 2, 5 ; 4 => null ; 5 => 3
        //    używając Dictionary
        // a) Oblicz sumę wierzchołków grafu
        // b) Podaj ilość wierzchołków bez sąsiadów
        // c) Sprawdź czy isnieje krawędź między a i b

        Dictionary<int,List<int>> graf = new ();
        System.Console.Write("Podaj ile chcesz podać wierzchołków: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            graf.Add(i+1, new List<int>());
        }

        System.Console.Write("Podaj ile będzie krawędzi: ");
        int k = Convert.ToInt32(Console.ReadLine());

        string[] liczby = new string[2];
        for (int i = 0; i < k; i++)
        {
            liczby = Console.ReadLine()!.Split();
            graf[int.Parse(liczby[0])].Add(int.Parse(liczby[1]));
            graf[int.Parse(liczby[1])].Add(int.Parse(liczby[0]));
        }
        
        foreach (var item in graf)
        {
            System.Console.WriteLine("Wierzchołek "+item.Key + " - "+ string.Join(" ", item.Value));
        }

        System.Console.WriteLine("6a");
        System.Console.WriteLine("Wierzchołki: "+graf.Keys.Count+"\n");

        System.Console.WriteLine("6b");
        int w = 0;

        foreach (var item in graf)
        {
            if (item.Value.Count == 0)
            {
                w++;
            }
        }

        System.Console.WriteLine("Ilość wierzchołków bez sąsiadów: "+w);
        System.Console.WriteLine("\n");

        System.Console.WriteLine("6c");
        System.Console.Write("Podaj wierzchołek a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Podaj wierzchołek b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (graf[a].Contains(b))
        {
            System.Console.WriteLine("Tak");
        }
        else{
            System.Console.WriteLine("Nie");
        }
    }
}
}