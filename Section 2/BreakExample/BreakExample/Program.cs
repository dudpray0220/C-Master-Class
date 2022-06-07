class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 6)
            {
                break;
            }
            System.Console.Write(i + " ");
        }
        System.Console.ReadKey();
    }
}