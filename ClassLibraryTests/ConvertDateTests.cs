using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class ConvertDateTests
    {
        [TestMethod()]
        [ExpectedException(typeof(IncorrectFormatException))]
        [DataRow("letter_in_date_2020")]
        [DataRow("01/01/2021")]
        public void ParseIncorrectDateTest(string date)
        {
            var converter = new ConvertDate();
            converter.ParseDate(date);
        }

        [TestMethod()]
        [DataRow("01.01.2021")]
        public void ParseGoodDateTest(string date)
        {
            var converter = new ConvertDate();
            converter.ParseDate(date);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void CheckIncorrectDatesTest()
        {
            var converter = new ConvertDate();
            DateTime date1, date2;
            string format = "dd.MM.yyyy";

            // same date
            try
            {
                date1 = DateTime.ParseExact("01.01.2021", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                date2 = DateTime.ParseExact("01.01.2021", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);

                converter.CheckDates(date1, date2);
            }
            catch (IncorrectRelationshipException) { }
            catch (Exception) { Assert.Fail(); }

            // greater day
            try
            {
                date1 = DateTime.ParseExact("02.01.2021", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                date2 = DateTime.ParseExact("01.01.2021", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);

                converter.CheckDates(date1, date2);
            }
            catch (IncorrectRelationshipException) { }
            catch (Exception) { Assert.Fail(); }

            // greater month
            try
            {
                date1 = DateTime.ParseExact("01.02.2021", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                date2 = DateTime.ParseExact("01.01.2021", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);

                converter.CheckDates(date1, date2);
            }
            catch (IncorrectRelationshipException) { }
            catch (Exception) { Assert.Fail(); }

            // greater year
            try
            {
                date1 = DateTime.ParseExact("01.01.2022", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
                date2 = DateTime.ParseExact("01.01.2021", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);

                converter.CheckDates(date1, date2);
            }
            catch (IncorrectRelationshipException) { }
            catch (Exception) { Assert.Fail(); }

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetDateRangeTest()
        {
            var converter = new ConvertDate();
            DateTime date1, date2;
            string format = "dd.MM.yyyy";

            //same month and year
            date1 = DateTime.ParseExact("01.01.2017", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
            date2 = DateTime.ParseExact("05.01.2017", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);

            Assert.AreEqual("01-05.01.2017", converter.GetDateRange(date1, date2));

            //same year
            date1 = DateTime.ParseExact("01.01.2017", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
            date2 = DateTime.ParseExact("05.02.2017", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);

            Assert.AreEqual("01.01-05.02.2017", converter.GetDateRange(date1, date2));

            //different dates
            date1 = DateTime.ParseExact("01.01.2016", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
            date2 = DateTime.ParseExact("05.01.2017", format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);

            Assert.AreEqual("01.01.2016-05.01.2017", converter.GetDateRange(date1, date2));
        }
    }
}