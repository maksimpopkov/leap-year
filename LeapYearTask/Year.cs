using System;

namespace LeapYearTask
{
    public static class Year
    {
        /// <summary>
        /// Report if given year is a leap year.
        /// </summary>
        /// <param name="year">Given year.</param>
        /// <returns>True if given year is leap, false otherwise.</returns>
        public static bool IsLeapYear(int year)
        {
            bool answer = false;
            for (int i = 0; i < 10; i++)
            {
                if (year % 4 == 0 && year % 100 != 0)
                {
                    answer = true;
                }
                else if (year % 400 == 0)
                {
                    answer = true;
                }
            }

            return answer;
        }
    }
}
