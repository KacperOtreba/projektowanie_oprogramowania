namespace Fasada3Cars
{
    interface ICar
    {
        void build();
    }
    class Chevrolet : ICar
    {
        public void build() { }
    }
    class BMW : ICar
    {
        public void build() { }
    }
    class Renault : ICar
    {
        public void build() { }
    }

    class FacadeForCar
    {
        public ICar s1;
        public ICar s2;
        public ICar s3;
        public FacadeForCar() { 
            s1 = new Chevrolet();
        }

        public void buildChevy() { }
        public void buildBMW() { }
        public void buildRenault() { }
    }

    class Program
    {
        public static void main(string[] args)
        {
            FacadeForCar f1 = new();
            f1.s1.build();
        }
    }
}