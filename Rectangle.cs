public class Rectangle : Resizeable
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public void Resize(double percent)
    {
        Width += Width * percent / 100;
        Height += Height * percent / 100;
    }
}
