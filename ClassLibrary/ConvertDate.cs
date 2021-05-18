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
        public DateTime ParseDate(string date)
        {
            DateTime parsedDate;
            string format = "dd.MM.yyyy";

            try
            {
                parsedDate = DateTime.ParseExact(date, format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
            } 
            catch (FormatException)
            {
                throw new IncorrectFormatException($"date '{date}'");
            }

            return parsedDate;
        }

        public void CheckDates(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);

            if (result == 0)
                throw new IncorrectRelationshipException(date1.ToShortDateString(), "is the same time as", date2.ToShortDateString());
            else if (result > 0)
                throw new IncorrectRelationshipException(date1.ToShortDateString(), "is later than", date2.ToShortDateString());
        }

        public string GetDateRange(DateTime date1, DateTime date2)
        {
            string part = "", day1 = "", month1 = "";

            if(date1.Year != date2.Year)
            {
                part = date1.ToShortDateString();
            } 
            else if (date1.Month != date2.Month)
            {
                day1 = date1.Day < 10 ? $"0{date1.Day}" : $"{date1.Day}";
                month1 += date1.Month < 10 ? $"0{date1.Month}" : $"{date1.Month}";

                part = $"{day1}.{month1}";
            }
            else
            {
                part = date1.Day < 10 ? $"0{date1.Day}" : $"{date1.Day}";
            }

            return $"{part}-{date2.ToShortDateString()}";
        }

    }
}
