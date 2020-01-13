using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = ("d\\d\\ h\\t\\ m\\m\\ ");
            DateTime today = DateTime.Now;

            DateTime christmasEve = new DateTime(2019, 12, 24, 18, 0, 0);
            TimeSpan timeUntilChristmas = christmasEve.Subtract(today);
            
            DateTime newYear = new DateTime(2020, 01, 01);
            TimeSpan timeUntilNewYear = newYear.Subtract(today);

            DateTime myBirthday = new DateTime(2000, 10, 20);
            TimeSpan timeSinceMyBirthday = today.Subtract(myBirthday);

            DateTime queensCoronation = new DateTime(1972, 1, 14);
            TimeSpan timeSinceQueensCoronation = today.Subtract(queensCoronation);

            DateTime tvNewsSaturday = new DateTime(2019, 12, 14, 18, 30, 00);
            TimeSpan timeUntilTvNewsSaturday = tvNewsSaturday.Subtract(today);
            Console.WriteLine($"Tid indtil Juleaften kl 18.00:            {timeUntilChristmas.ToString(format)}");
            Console.WriteLine($"Tid indtil det nye år:                    {timeUntilNewYear.ToString(format)}");
            Console.WriteLine($"Tid siden min fødselsdag:                 {timeSinceMyBirthday.ToString(format)}");
            Console.WriteLine($"Tid siden dronning Margrethe blev kronet: {timeSinceQueensCoronation.ToString(format)}");
            Console.WriteLine($"Tid indtil TV avisen på lørdag:           {timeUntilTvNewsSaturday.ToString(format)}");
            Console.ReadLine();           
        }
    }
}
