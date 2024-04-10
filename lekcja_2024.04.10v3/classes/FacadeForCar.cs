namespace autko.classes
{
    class FacadeForCar
    {
        private ICar Bmw;
        private ICar Chevrolet;
        private ICar Renault;

        public FacadeForCar(Bmw bmw, Chevrolet chevrolet, Renault renault)
        {
            Bmw = bmw;
            Chevrolet = chevrolet;
            Renault = renault;
        }

        public void buildBmw()
        {
            Bmw.build();
        }
        public void buildChevrolet()
        {
            Chevrolet.build();
        }
        public void buildRenault()
        {
            Renault.build();
        }
    }
}