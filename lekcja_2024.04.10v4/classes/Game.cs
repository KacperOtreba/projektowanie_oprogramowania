namespace MetodaSzablonowa.classes
{
    abstract class Szablonowa
    {
        protected abstract void attack();
    }

    abstract class Game : Szablonowa
    {
        protected sealed override void attack()
        {
            buildStructures();
            buildUnits();
            sendScouts();
            sendWarriors();
        }

        public abstract void buildStructures();
        public abstract void buildUnits();
        public abstract void sendScouts();
        public abstract void sendWarriors();
        public virtual void takeTurn() { }
        public virtual void collectResource() { }
    }
}