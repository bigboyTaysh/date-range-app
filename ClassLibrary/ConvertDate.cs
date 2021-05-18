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
            } 
            catch (FormatException)
            {
                throw new IncorrectFormatException(dates[0]);
            }
        }

        public DateTime ParseDate(string dateFrom)
        {
            string format = "dd.MM.yyyy";
            return DateTime.ParseExact(dateFrom, format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
        }
    }
}
