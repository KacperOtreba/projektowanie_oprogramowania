namespace Fasada.classes
{
    class WashingMachine
    {
        Washing w;
        Rinsing r;
        Spinning s;

        public void StartWashing(){}
        public void inicjujPraniePralko(Washing wa, Rinsing ri, Spinning sp)
        {
            this.w = wa;
            this.r = ri;
            this.s = sp;
        }
    }
}