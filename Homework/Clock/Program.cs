using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("### Clock angle app ###");
                Console.WriteLine();
                Console.WriteLine("Enter hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter minutes: ");
                int minutes = int.Parse(Console.ReadLine());

                Calculator calculator = new Calculator(hours, minutes);

                Console.WriteLine();
                Console.WriteLine($"Arrows angle is: {calculator.GetArrowsAngle()}°");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
