class Sample
{
    static void Main()
    {
        // inputs
        int inches = 7;
        int feet = 5;

        // process
        int totalInches = (feet * 12) + inches;
        double centimeters = totalInches * 2.54;

        // output
        System.Console.WriteLine(centimeters + "cm");
        System.Console.ReadKey();
    }
}