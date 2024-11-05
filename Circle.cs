public class Circle : Resizeable
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public void Resize(double percent)
    {
        Radius += Radius * percent / 100;
    }
}
