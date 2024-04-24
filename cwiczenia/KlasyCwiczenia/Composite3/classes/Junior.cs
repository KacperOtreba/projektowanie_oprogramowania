namespace Composite3.classes;

class Junior : IEmployee
{
    public string Name { get; set; }

    public void getName()
    {
        System.Console.WriteLine(Name);
    }

    public void setName(string name)
    {
        Name = name;
    }
}