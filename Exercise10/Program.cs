using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            string file; 

            if (args.Length == 0)
            {
                file = File.ReadAllText(@"../../teaTimeFile.txt");
            }
            else
            {
                file = File.ReadAllText(args[0]);
            }
            Console.WriteLine(Directory.GetCurrentDirectory());

            //checks for pattern
            //match if string ends in e or t
            Int64 matchCount = Regex.Matches(file, "([te])(?![a-z])", RegexOptions.Multiline | RegexOptions.IgnoreCase).Count;

            //display results to console
            Console.WriteLine("There are " + matchCount + " words that end in t or e");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}