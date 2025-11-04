using System;

namespace BirthdateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a DateTime variable for birthdate
            DateTime birthDate = new DateTime(2005, 10, 28); //  birthdate 

            // Create a DateTime variable for current date and time
            DateTime currentDate = DateTime.Now;

            // Calculate age using TimeSpan
            TimeSpan ageSpan = currentDate - birthDate;
            int ageInYears = (int)(ageSpan.TotalDays / 365.25); // Approximate years including leap years

            // Print birthdate, current date, and age
            Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Age: {ageInYears} years");

            // Add 10 days to birthdate and print
            DateTime newDate = birthDate.AddDays(10);
            Console.WriteLine($"Birthdate plus 10 days: {newDate.ToShortDateString()}");
        }
    }
}
