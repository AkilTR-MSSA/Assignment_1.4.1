class Point
{
    public double x;
    public double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(3, 7);
        Point p2 = new Point(8.75, 9.26);

        if (p1.x > p2.x)
        {
            Console.WriteLine("p1 is to the right!");
        } else
        {
            Console.WriteLine("p1 is to the left!");
        }
    }
}