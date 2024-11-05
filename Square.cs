public class Square : Resizeable
{
    public double Side { get; private set; }

    public Square(double side)
    {
        Side = side;
    }

    public double GetArea()
    {
        return Side * Side;
    }

    public void Resize(double percent)
    {
        Side += Side * percent / 100;
    }
}
