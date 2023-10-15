using OOP.Enums;

namespace OOP.Extensions
{
    public static class ExtesionsDays
    {
        /// <summary>
        /// Get the length of Enum EDays used to count the next and prev days.
        /// </summary>
        /// <returns>Length of total days which is 7.</returns>
        public static int GetLength() => Enum.GetValues(typeof(EDays)).Length;

        /// <summary>
        /// Move to the next day.
        /// </summary>
        /// <param name="EDaysday"></param>
        /// <returns>the next day.</returns>
        public static EDays GetNextDay(this EDays day)
        {
            int actualDay = (int)day;
            int nextDay = (actualDay + 1) % GetLength();
            return (EDays)nextDay;
        }


        /// <summary>
        /// Move to the previous day.
        /// </summary>
        /// <param name="EDaysday"></param>
        /// <returns>the previous day.</returns>
        public static EDays GetPrevDay(this EDays day)
        {
            int actualDay = (int)day;
            int prevDay = (actualDay + GetLength() - 1) % GetLength();
            return (EDays)prevDay;
        }
    }
}
