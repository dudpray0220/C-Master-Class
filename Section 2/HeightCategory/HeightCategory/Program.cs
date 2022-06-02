class Program
{
    static void Main()
    {
        // Write a program to find out "category of height" based on the given height of a person (in inches), using "if".
        //  Height is less than 150 cm = "Dwarf"
        //  Height is between 150 cm and 165 cm = "Average height"
        //  Height is between 165 cm and 195 cm = "Tall"
        //  Height is above 195 cm = "Abnormal height"
        //  1 inch = 2.54 centimeter
        //  You need to convert the input value(inches) into centimeters.

        int inch_height = 75;
        double cm_height = inch_height * 2.54;
        string result = null;   //initialize the 'result' variable

        if (cm_height < 150)
        {
            result = "Dwarf";
        }
        else if (150 <= cm_height && cm_height <165)
        {
            result = "Average height";
        }
        else if (165 <= cm_height && cm_height <195)
        {
            result = "Tall";
        }
        else
        {
            result = "super Tall";
        }

        System.Console.WriteLine(result);   
        System.Console.ReadKey();
    }
}