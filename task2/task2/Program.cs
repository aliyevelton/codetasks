class Program
{
    public static void Main()
    {
        Console.WriteLine(Area(2));
    }

    static int Area(int r)
    {
        return 3 * r * r; // pi * r * r;
    }
    static int Area(int a, int b)
    {
        return a * b;
    }

    static int Area(int a, int b, int c, int r)
    {
        int p = (a + b + c) / 2;
        return p * r;
    }
}