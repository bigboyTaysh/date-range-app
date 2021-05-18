using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Info
    {
        public static void WriteHelp()
        {
            Console.WriteLine("Application prints date range in console \n" +
                "accepts two input parameters: \"./DateRangeApp.exe [date1] [date2]\" \n" + 
                "[date1] and [date2] arguments must contain  \n" +
                "the representation of a date dd.MM.yyyy like '01.01.2021' \n" +
                "   [date1]: representation of a date that is earlier than [date2] \n" +
                "   [date2]: representation of a date that is later than [date1]: \n");
        }

        public static void IncorrectNumberOfParameters(string[] args)
        {
            Console.WriteLine($"Incorrect number of parameters: {args.Length}");
            RunInfo();
        }

        public static void IncorrectParameter(string arg)
        {
            Console.WriteLine($"Incorrect parameter: {arg}");
            RunInfo();
        }

        public static void RunInfo()
        {
            Console.WriteLine("For more detailed help run \"./DateRangeApp.exe --help\"");
        }
    }
}
