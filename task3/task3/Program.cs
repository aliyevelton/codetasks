class Program
{

    static int sum(int a)
    {
        int sum = 0;
        int i = 0;

        while (sum < a)
        {
            if (sum + i > a)
                break;
            else
                sum += i;
                i++;
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine(sum(22));
    }
}