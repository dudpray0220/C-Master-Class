class Sample
{
    static void Main()
    {
        //  seconds = 288970
        //  The given number of seconds is equivalent to "3 days, 8 hours, 16 minutes, 10 seconds"
        //  Output: 3 days, 8 hours, 16 minutes, 10 seconds

        // 1 day = 24 hours / 1 hours = 60 min / 1min = 60 sec
        int seconds = 288970;
        int remaining_seconds = seconds;  //copying the actual input; so that, the original input will be persisted

        int seconds_per_minute = 60; // 1min = 60sec
        int seconds_per_hour = 60 * 60; // 1hour = 60min
        int seconds_per_day = 60 * 60 * 24; // 1 day = 24hour  

        // process
        int days = remaining_seconds / seconds_per_day;
        remaining_seconds -= days * seconds_per_day;

        int hours = remaining_seconds / seconds_per_hour;
        remaining_seconds -= hours * seconds_per_hour;

        int minutes = remaining_seconds / seconds_per_minute;
        remaining_seconds -= minutes * seconds_per_minute;

        string output = days + " days, " + hours + " hours, " + minutes + " minutes, " + remaining_seconds + " seconds";

        System.Console.WriteLine(output);
        System.Console.ReadKey();
    }
}