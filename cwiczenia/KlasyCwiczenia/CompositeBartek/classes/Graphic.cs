using System.Security.Cryptography.X509Certificates;

namespace Composite2.classes;

public interface IGraphic
{
    void move(int x, int y);
    void draw();

}

class Dot : IGraphic
{
    public int X;
    public int Y;

    public Dot(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public void draw() {}
}

class Circle : Dot
{
    public int Radius;

    public Circle(int x, int y, int radius) : base(x,y)
    {
        Radius = radius;
    }

    public void draw() {}
}

class CompoundGraphic : IGraphic
{
    private List<IGraphic> children = new List<IGraphic>();

    public void add(IGraphic child)
    {
        children.Add(child);
    }

    public void remove(IGraphic child)
    {
        children.Remove(child);
    }

    public void move(int x, int y){}
    public void draw() {}
}