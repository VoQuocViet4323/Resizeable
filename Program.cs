using System;

public class Program
{
    public static void Main()
    {
        Random random = new Random();
        Resizeable[] shapes = new Resizeable[]
        {
            new Circle(5.0),
            new Rectangle(4.0, 6.0),
            new Square(3.0)
        };

        foreach (var shape in shapes)
        {
            double randomPercent = random.Next(1, 101); 
            Console.WriteLine("Trước khi resize:");

            if (shape is Circle circle)
            {
                Console.WriteLine($"Hình tròn có diện tích: {circle.GetArea():0.00}");
            }
            else if (shape is Rectangle rectangle)
            {
                Console.WriteLine($"Hình chữ nhật có diện tích: {rectangle.GetArea():0.00}");
            }
            else if (shape is Square square)
            {
                Console.WriteLine($"Hình vuông có diện tích: {square.GetArea():0.00}");
            }

            shape.Resize(randomPercent);

            Console.WriteLine($"\nTăng kích thước theo tỷ lệ: {randomPercent}%");
            Console.WriteLine("Sau khi resize:");

            if (shape is Circle resizedCircle)
            {
                Console.WriteLine($"Hình tròn có diện tích mới: {resizedCircle.GetArea():0.00}");
            }
            else if (shape is Rectangle resizedRectangle)
            {
                Console.WriteLine($"Hình chữ nhật có diện tích mới: {resizedRectangle.GetArea():0.00}");
            }
            else if (shape is Square resizedSquare)
            {
                Console.WriteLine($"Hình vuông có diện tích mới: {resizedSquare.GetArea():0.00}");
            }

            Console.WriteLine("-----------------------------------");
        }
    }
}
