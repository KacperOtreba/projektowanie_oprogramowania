namespace Otreba_Kacper_2e;

class Program
{
    static void Main(string[] args)
    {
        // Zadanie 0
        // Malomiasteczkowa to była by taka gdzie wszystkie cyfry są sobie równe czyli {3,3,3,3,3,3,3}
        // string[] cyfrystr = Console.ReadLine()!.Split("-");

        // int[] cyfry = Array.ConvertAll(cyfrystr,int.Parse);

        // bool Wielkomiejska = false;
        // for (int i = 1; i < cyfry.Length; i++)
        // {
        //     if (cyfry[i-1] <= cyfry[i]){
        //         Wielkomiejska = true;
        //     }
        //     else{
        //         Wielkomiejska = false;
        //         break;
        //     }
        // }
        
        
        // bool Malorolna = false;
        // for (int i = 1; i < cyfry.Length; i++)
        // {
        //     if (cyfry[i-1] >= cyfry[i]){
        //         Malorolna = true;
        //     }
        //     else{
        //         Malorolna = false;
        //         break;
        //     }
        // }
        
        // // 3 3 3 3 3 3 3
        // bool Malomiasteczkowa = false;
        // for (int i = 1; i < cyfry.Length; i++)
        // {
        //     if (cyfry[i-1] == cyfry[i]){
        //         Malomiasteczkowa = true;
        //     }
        //     else{
        //         Malomiasteczkowa = false;
        //         break;
        //     }
        // }
        // if(Malomiasteczkowa){
        //     System.Console.WriteLine("Tablica jest malomiasteczkowa");
        //     return;
        // }
        // if (Wielkomiejska){
        //     System.Console.WriteLine("Tablica jest Wielkomiejska");
        // }
        // if (Malorolna){}
        // {
        //     System.Console.WriteLine("Tablica jest Malorolna");
        // }

        // Zadanie 1
        // int[] array = new int[10];
        // Random r = new Random();

        // for (int i = 0; i < array.Length; i++)
        // {
        //     array[i] = r.Next(-9,10);
        //     System.Console.Write(array[i]+" ");
        // }

        // List<int> podciag = new();
        // List<List<int>> podciags = new();

        // for (int i = 1; i < array.Length; i++)
        // {
        //     if (array[i-1] < array[i])
        //     {
        //         podciag.Add(array[i-1]);
        //         podciag.Add(array[i]);
        //     }
        //     else if (array[i-1] > array[i] || array[i] == array.Length-1)
        //     {
        //         podciags.Add(podciag.Distinct().ToList());
        //         podciag.Clear();
        //     }
        // }

        // int index = 0;
        // int suma = 0;
        // for (int i = podciags.Count; i < 0; i--)
        // {
        //     if (podciags[i].Sum() > suma)
        //     {
        //         suma = podciags[i].Sum();
        //         index = i;
        //     }
        // }
        // System.Console.WriteLine();
        // System.Console.WriteLine(podciags[index].ElementAt(0));
        // System.Console.WriteLine(podciags[index].ElementAt(podciags[index].Count-1));
        // System.Console.WriteLine(podciags[index].Sum());

        // Zadanie 2
        System.Console.Write("Podaj liczbę nieparzystą większą lub równą 3: ");
        int n = Convert.ToInt32(Console.ReadLine());
        List<List<string>> szescian = new();
        Random r = new();

        


        // int[,,] szescian = new int[n,n,n];
        // for (int i = 0; i < szescian.Length; i++)
        // {
        //     for (int j = 0; j < szescian.Length; j++)
        //     {
        //         for (int k = 0; k < szescian.Length; k++)
        //         {
        //             szescian[i,j,k] = r.Next(1,100);
        //         }
        //     }
        // }
        
        

    } 
}
