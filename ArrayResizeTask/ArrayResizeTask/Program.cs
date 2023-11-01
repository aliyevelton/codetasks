int[] numbers = { 1, 2, 3, 4, 5, 6 };
int newSize;

Console.WriteLine("Enter a new size for the array: ");
newSize = Convert.ToInt32(Console.ReadLine());

int[] numbersResized = new int[newSize];

int[] ResizeArray( ref int[] numbers, int newSize)
{
       if(newSize > numbers.Length)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbersResized[i] = numbers[i];
        }
    } else
    {
        for (int i = 0; i < newSize; i++)
        {
            numbersResized[i] = numbers[i];
        }
    }
       return numbersResized;
}
Console.WriteLine("The new array is: ");
foreach (int number in ResizeArray(ref numbers, newSize))
{
    Console.WriteLine(number);
}