using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Calculator
    {
        private const int hoursDegreeStep = 30;
        private const int minutesDegreeStep = 6;
        private const double HVsMinStep = 0.5;

        private int Hours { get; set; }
        private int Minutes { get; set; }

        public Calculator(int hours, int minutes)
        {
            if (hours > 12 || hours < 1)
            {
                throw new Exception("Entered hours are not in 1-12 range, please enter correct hours");
            }
            else
            {
                this.Hours = hours;
            }
            if (minutes > 60 || minutes < 0)
            {
                throw new Exception("Entered minutes are not in 0-60 range, please enter correct minutes");
            }
            else
            {
                this.Minutes = minutes;
            }
        }

        public (double, int) GetDegrees()
        {
            double hoursDegrees = hoursDegreeStep * Hours + HVsMinStep * Minutes;
            int minutesDegrees = minutesDegreeStep * Minutes;
            return (hoursDegrees, minutesDegrees);
        }

        public double GetArrowsAngle()
        {
            double degrees = Math.Abs(360 - GetDegrees().Item1 + GetDegrees().Item2 - 360);
            if (degrees > 180)
            {
                degrees = 360 - GetDegrees().Item1 + GetDegrees().Item2;
            }
            return degrees;
        }
    }
}
