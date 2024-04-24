namespace Composite3.classes;

class Manager : IEmployee
{
    public string Name { get; set; }
    public List<IEmployee> Employees = new();


    public void getName()
    {
        System.Console.WriteLine(Name);
    }

    public void setName(string name)
    {
        Name = name;
    }

    public void addEmployee(IEmployee employee)
    {
        Employees.Add(employee);
    }

    public void removeEmployee(IEmployee employee)
    {
        Employees.Remove(employee);
    }
}