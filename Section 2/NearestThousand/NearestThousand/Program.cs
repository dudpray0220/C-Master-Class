class Sample
{
    static void Main()
    {
        // if the number's last three digits are greater than or equal to 500; it should "round up" the number.
        // If the number's last three digits are less than 500; it should "round down" the number.
        // If the number is less than 500; it should round up to 1000.
        //  Eg:
        //  Input: 499  Output: 1000
        //  Input: 500  Output: 1000
        //  Input: 999  Output: 1000
        //  Input: 1000 Output: 1000
        //  Input: 1499 Output: 1000
        //  Input: 1500 Output: 2000

        // 일단 last three digits와 천의 자리로 쪼개야 함
        // inputs
        int number = 3852, number2 = 1499;
        decimal decimal_number = (decimal)number; // 나누는 데 분수가 나올 수 있으므로 decimal로 업 캐스팅 (converting)
        decimal decimal_number2 = (decimal)number2; // 나누는 데 분수가 나올 수 있으므로 decimal로 업 캐스팅 (converting)

        // process 1
        int previous_thousand = number / 1000 * 1000;   // 3000
        int last_threeDigits = number % 1000; // 852

        int answer = (number <= 1000) ? 1000 : (last_threeDigits >= 500) ? previous_thousand + 1000 : previous_thousand;


        // process 2
        int previous_thousand2 = number2 / 1000 * 1000;
        decimal last_threeDigits_x = decimal_number2 / 1000; // 3.852
        decimal last_threeDigits_y = number2 / 1000; // 3
        decimal last_threeDigits2 = last_threeDigits_x - last_threeDigits_y * 1000; // 852

        int roundingValue = (last_threeDigits2 >= 500) ? 1000 : 0;
        int is_less_than_fiveHundred = (number2 < 500) ? 1000 : 0;
        int nearestThousand = previous_thousand2 + roundingValue + is_less_than_fiveHundred;

        System.Console.WriteLine(answer);
        System.Console.WriteLine(nearestThousand);
        System.Console.ReadKey();
    }
}