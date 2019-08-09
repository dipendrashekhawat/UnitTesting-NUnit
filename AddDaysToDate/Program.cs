using System;

namespace AddDaysToDate
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter date in the format dd-mm-yyyy");
                DateTime inputDate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter the number of days you want to add to the above date: ");
                int numberOfDays = Convert.ToInt32(Console.ReadLine());

                DateTime newDate = NumberOfDays(givenDate: inputDate, days: numberOfDays);

                Console.WriteLine("New date after adding {0} days to {1} is: {2} ", numberOfDays, inputDate, newDate.ToShortDateString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while adding days :" + ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Add number of days to a given date
        /// </summary>
        /// <param name="days">Number of days</param>
        /// <param name="givenDate">Date in mm-dd-yyyy format</param>
        /// <returns>New date with the days added</returns>
        public static DateTime NumberOfDays(int days, DateTime givenDate)
        {
            DateTime newDate = givenDate.AddDays(days);
            return newDate;
        }

    }
}
