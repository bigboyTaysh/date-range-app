using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ConvertDate
    {
        public void ParseDates(string[] dates)
        {

            DateTime date1, date2;

            try
            {
                date1 = ParseDate(dates[0]);
                date2 = ParseDate(dates[1]);
            } 
            catch (FormatException)
            {
                throw new IncorrectFormatException("Wrong date format");
            }
        }

        public DateTime ParseDate(string dateFrom)
        {
            string format = "dd.MM.yyyy";
            return DateTime.ParseExact(dateFrom, format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
        }
    }
}
