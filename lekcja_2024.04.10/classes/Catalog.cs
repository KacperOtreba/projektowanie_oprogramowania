namespace UML.classes
{
    class Catalog : IWęzeł
    {
        List<IWęzeł> węzły = new List<IWęzeł> ();
        public string Name { get; set;}
        public void wyświetl() {
            System.Console.WriteLine(Name);
            foreach (var item in węzły)
            {
                System.Console.Write("|--");
                item.wyświetl();
            }
        }

        public void dodaj(IWęzeł w) 
        {
            węzły.Add(w);
        }
    }
}