using System;

namespace Opgave2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast to tidspunkter, og se hvor langt der er mellem dem: (klokkeslæt skal skrives sådan: ('timetal':'minuttal')");
                Console.Write("Indtast første tidspunkt: ");
                string input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime firstTime);

                Console.Write("Indtast andet tidspunkt: ");
                input = Console.ReadLine();
                DateTime.TryParse(input, out DateTime secondTime);
                DateTime falseTime = new DateTime(0001, 01, 01);

                string format = ("d\\d\\ h\\t\\ m\\m\\ ");
                if(firstTime == falseTime || secondTime == falseTime)
                {
                    Console.WriteLine("Et af tidspunkterne er ugyldige! prøv igen");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    if(firstTime != secondTime)
                    {
                        TimeSpan timeSpan = firstTime.Subtract(secondTime);
                        Console.WriteLine($"Forskellen mellem de to tidspunkter er på: {timeSpan.ToString(format)}");
                    }
                    else if(firstTime == secondTime)
                    {
                        Console.WriteLine("De to tidspunkter er ens");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
