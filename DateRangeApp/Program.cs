using System;
using System.Collections.Generic;
using ClassLibrary;

namespace DateRangeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertDate converter = new ConvertDate();

            if (args.Length == 1 && args[0] == "--help")
            {
                Info.WriteHelp();
            }
            else if (args.Length == 2)
            {
                try
                {
                    DateTime date1 = converter.ParseDate(args[0]),
                        date2 = converter.ParseDate(args[1]);

                    converter.CheckDates(date1, date2);

                    Console.WriteLine(converter.GetDateRange(date1, date2));
                }
                catch (IncorrectFormatException e)
                {
                    Console.WriteLine(e.Message);
                    Info.RunInfo();
                }
                catch (IncorrectRelationshipException e)
                {
                    Console.WriteLine(e.Message);
                    Info.RunInfo();
                }
            } 
            else
            {
                Info.IncorrectNumberOfParameters(args);
            }
        }
    }
}
