using System;

namespace DateTime_test
{
    public class Time
    {
        // private member variables
        private int Year;
        private int Month;
        private int Date;
        private int Hour;
        private int Minute;
        private int Second;

        // constructor
        public Time(System.DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }

        // public accessor methods
        public void DisplayCurrentTime()
        {
            Console.WriteLine($"{Date}/{Month}/{Year} {Hour}:{Minute}:{Second}");
        }
        public int GetHour()
        {
            return Hour;
        }

        public void GetTime(ref int h, ref int m, ref int s)
        {
            h = Hour;
            m = Minute;
            s = Second;
        }
    }
    public class Tester
    {
        static void Main()
        {
            System.DateTime currentTime = System.DateTime.Now;
            Time t = new Time(currentTime);
            t.DisplayCurrentTime();
            int theHour = 0;
            int theMinute = 0;
            int theSecond = 0;
            t.GetTime(ref theHour, ref theMinute, ref theSecond);
            Console.WriteLine($"Current time: {theHour}:{theMinute}:{theSecond}");
        }
    }
}
