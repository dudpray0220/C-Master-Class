class Program
{
    static void Main()
    {
        char gradeLetter = 'A';
        string gradeDescription;

        switch (gradeLetter)
        {
            case 'O': gradeDescription = "Outstanding"; break;
            case 'A': gradeDescription = "Excellent"; break ;
            case 'B': gradeDescription = "Good"; break;
            case 'C': gradeDescription = "Bad"; break;
            case 'F': gradeDescription = "Fail"; break;
            default: gradeDescription = "Non"; break;
        }
        System.Console.WriteLine(gradeDescription);
        System.Console.ReadKey();
    }
}