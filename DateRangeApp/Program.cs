using System;
using ClassLibrary;

namespace DateRangeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1 && args[0] == "--help")
            {
                Info.WriteHelp();
            }
            else if (args.Length == 2)
            {
                Info.IncorrectParameters();
            } 
            else
            {
                Info.IncorrectNumberOfParameters();
            }
        }
    }
}
