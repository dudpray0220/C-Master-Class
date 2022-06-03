class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        int j = 9;
        for (; j >= 0; j--)
        {
            System.Console.Write(j + " ");
        }
        System.Console.ReadKey();
    }
}