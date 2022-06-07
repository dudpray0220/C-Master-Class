class Program
{
    static void Main()
    {
        // Write a C# program to print the following output by using 'for' loop, 'break' and 'continue' statements
        //  1 2 3 4 7 8 9 10
        //  1 2 3 4 7 8 9 10
        //  1 2 3 4 7 8 9 10
        //  10 9 8 7 6 5 4 3 2 1
        //  10 9 8 7 6 5 4 3 2 1
        //  10 9 8 7 6 5 4 3
        //  10 9 8 7 6 5 4 3 2 1
        //  1 2 3 4 5 6 7 9 10

        for (int i = 0; i < 8; i++)
        {
            if (i < 3)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 5 || j == 6)
                    {
                        continue;
                    }
                    System.Console.Write(j + " ");
                }
            }

            else if (i >= 3 && i <= 6)
            {
                for (int j = 10; j >= 1; j--)
                {
                    if (i == 5 && j < 3)
                    {
                        continue;
                    }
                    System.Console.Write(j + " ");
                }
            }

            else
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 8)
                    {
                        continue;
                    }
                    System.Console.Write(j + " ");
                }
            }
            System.Console.WriteLine();
        }
        System.Console.ReadKey();
    }
}