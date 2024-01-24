namespace lekcja_2023._12._06;

class Program
{
    static void Main(string[] args)
    {
        // System.Console.WriteLine(r7e(5));
        // System.Console.WriteLine(Suma(34));
        // System.Console.WriteLine(SumaR(56));
        // System.Console.WriteLine(DecBin(23));
        // System.Console.WriteLine(DecBinR(23));
        // DecBinR2(23);
        
    }

    static int r7d(int n){
        if (n==1) return 2;
        if (n==2) return 3;
        if (n==3) return 4;
        return r7d(n-1) - r7d(n-2) - r7d(n-3);
    }

    static int r7e(int n){
        if (n == 1) return 1;
        if (n==2) return 4;
        if (n%2==0) return r7e(n-2)*4;
        return r7e(n-2) + 2;
    }

    static int Suma(int liczba){
        int suma = 0;
        while (liczba > 0){
            suma += liczba % 10;
            liczba = liczba / 10;
        }
        return suma;
    }

    static int SumaR(int n){
        if (n == 0) return 0;
        return SumaR(n/10) + n%10;
    }

    static string DecBin(int n){
        string bin = "";
        while (n > 0){
            bin = n%2 + bin;
            n /= 2;
        }
        return bin;
    }

    static int DecBinR(int n){
        if (n == 0) return 0;
        return n % 2 + 10 * DecBinR(n/2);
    }

    static void DecBinR2(int n){
        if (n==0) return;
        DecBinR2(n/2);
        System.Console.WriteLine(n%2);
    }
    
}
