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
            Console.WriteLine("Application prints date range in console.");
            Console.WriteLine("accepts two input parameters: \"./DateRangeApp.exe [date1] [date2]\"");
            Console.WriteLine(" date1: ");
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
