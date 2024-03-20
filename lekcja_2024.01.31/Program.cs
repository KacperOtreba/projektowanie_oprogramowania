// namespace lekcja_2024._01._31;

// class Vertex
// {
//     List<int> neighbours = new List<int>();
//     public void addNeighbours(int nei)
//     {
//         neighbours.Add(nei);
//     }
// }
// class Graph
// {
//     List<Vertex> vertices = new List<Vertex>();

//     public Graph(int n)
//     {
//         for (int i = 0; i <= n; i++)
//         {
//             vertices.Add(new Vertex());
//         }
//     }
//     public void AddNeighbours(int v, int nei)
//     {
//         vertices[v].Add(nei);
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         int a, b;
//         List<string> list = Console.ReadLine().Split().ToList();
//         int n = int.Parse(list[0]);
//         int m = int.Parse(list[1]);

//         Graph graph = new Graph(n);
        
        
//         for (int i = 0; i < m; i++)
//         {
//             list = Console.ReadLine().Split().ToList();
//             a = int.Parse(list[0]);
//             b = int.Parse(list[1]);
//             graph.AddNeighbours(a,b);
//         }

//         graph.DisplayGraph();
//     }
// }
