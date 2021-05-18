using System;
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
                    converter.ParseDates(args);
                }
                catch (IncorrectFormatException e)
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
