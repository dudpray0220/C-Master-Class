class Program
{
    static void Main()
    {
        //  num1 = 60
        //  num2 = 45
        //  num3 = 123
        //  Output: 123
        int input1 = 60, input2 = 45, input3 = 123;
        int biggestNum;

        if (input1 > input2)
        {
            if (input1 > input3)
            {
                biggestNum = input1;
            }
            else
            {
                biggestNum = input3;
            }
        }
        else // input1 < input2 
        {
            if (input2 > input3)
            {
                biggestNum = input2;
            }
            else
            {
                biggestNum = input3;
            }
        }

        System.Console.WriteLine(biggestNum);
        System.Console.ReadKey();
    }
}