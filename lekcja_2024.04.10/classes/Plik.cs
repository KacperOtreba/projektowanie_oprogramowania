namespace UML.classes
{
    class Plik : IWęzeł
    {
        public string Name { get; set;}
        public void wyświetl()
        {
            System.Console.WriteLine("->"+Name);
        }
    }
}