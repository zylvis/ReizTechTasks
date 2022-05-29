using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    static class Start
    {
        public static void StartProgram()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Enter hours: ");
                bool isHours = int.TryParse(Console.ReadLine(), out int hours);
                Console.WriteLine("Enter minutes: ");
                bool isMinutes = int.TryParse(Console.ReadLine(), out int minutes);
                if (!isMinutes || !isHours)
                {
                    throw new Exception("Wrong format. Enter correct format in numbers and not empty.");
                }

                Calculator calculator = new Calculator(hours, minutes);
                Console.WriteLine();
                Console.WriteLine($"Arrows angle is: {calculator.GetArrowsAngle()}°");
            }
            catch (Exception error)
            {
                Console.WriteLine();
                Console.WriteLine(error.Message);
                StartProgram();
            }
        }
    }
}
