class Program
{
    static void Main()
    {
        // 초기화
        int i = 80;
        // while Loop
        do
        {
            System.Console.Write(i + " ");
            i++;
        } while (i <= 10) ;
            System.Console.WriteLine(); 

        // 초기화
        int a = 0;
        // while Loop
        do
        {
            System.Console.Write(a + " ");
            a++;
        } while (a < 10) ;
            System.Console.WriteLine();

        // 초기화
        int b = 9;
        // while Loop
        do
        {
            System.Console.Write(b + " ");
            b--;
        } while (b >= 0) ;
            System.Console.ReadKey();
    }
}