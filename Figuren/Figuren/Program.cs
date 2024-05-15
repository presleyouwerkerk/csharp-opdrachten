namespace Figuren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle("rood", 10);
            Circle circle2 = new Circle("blauw", 15);

            Square square1 = new Square("groen", 5);
            Square square2 = new Square("geel", 8);

            Triangle triangle1 = new Triangle("oranje", 7, 9);
            Triangle triangle2 = new Triangle("paars", 6, 12);

            Rectangle rectangle1 = new Rectangle("wit", 10, 20);
            Rectangle rectangle2 = new Rectangle("zwart", 15, 25);

            Console.WriteLine(circle1.Draw());
            Console.WriteLine(circle2.Draw());
            Console.WriteLine(square1.Draw());
            Console.WriteLine(square2.Draw());
            Console.WriteLine(triangle1.Draw());
            Console.WriteLine(triangle2.Draw());
            Console.WriteLine(rectangle1.Draw());
            Console.WriteLine(rectangle2.Draw());

            Console.WriteLine("Gemaakt door Presley");
            Console.ReadKey();
        }
    }
}
