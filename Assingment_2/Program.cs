using System;

namespace Assingment_2
{
    using System;
    using static System.Console;
    using System.Globalization;
    class MoveEstimator
    {
        static void Main()
        {
            const double baseRate = 200;
            const double hourlyRate = 150;
            const double perMile = 2;

            double hours;
            double miles;
            double moveEstimate;

            string inputValue;

            WriteLine("Please enter hours below:");
            inputValue = ReadLine();
            hours = double.Parse(inputValue);

            WriteLine("Please enter miles below:");
            inputValue = ReadLine();
            miles = double.Parse(inputValue);

            moveEstimate = (hourlyRate + hours) + (perMile + miles) + baseRate;

            WriteLine("For " + hours + " hours with mile rate of " + miles + ',' + " total cost is " + '$' + moveEstimate + '.');
        }
    }
}
