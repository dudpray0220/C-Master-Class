class Program
{
    static void Main()
    {
        int i = 1;
        System.Console.WriteLine("a");
        System.Console.WriteLine("b");

    mylabel:
        System.Console.WriteLine("c");
        System.Console.WriteLine("d");
        System.Console.WriteLine("e");
        System.Console.WriteLine("f");
        i++;

        if (i <= 5)
        {
            goto mylabel;
        }

        System.Console.WriteLine("g");
        System.Console.WriteLine("h");

        System.Console.ReadKey();
    }
}