using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan firstTimeSpan = new TimeSpan(2, 4, 30, 11);
            TimeSpan aspitHours = new TimeSpan(6, 45, 0);
            DateTime rightNow = DateTime.Now;
            DateTime wakeUpTime = new DateTime(2019, 12, 11, 7, 20, 00);
            TimeSpan timeSinceWakeUp = rightNow.Subtract(wakeUpTime);
            string format = "hh\\:mm\\:ss";
            TimeSpan minutes = new TimeSpan(0, 30, 2);
            TimeSpan days = new TimeSpan(18, 0, 0, 0);
            TimeSpan everything = new TimeSpan(28, 7, 16, 3);

            Console.WriteLine(firstTimeSpan.ToString());
            Console.WriteLine($"Længden på en skoledag på AspIT: {aspitHours.ToString()}");
            Console.WriteLine($"Hvor længe siden jeg stod op: {timeSinceWakeUp.ToString(format)}");
            Console.WriteLine(minutes.ToString());
            Console.WriteLine(days.ToString());
            Console.WriteLine(everything.ToString());
            Console.ReadLine();
        }
    }
}
