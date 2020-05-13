using System;
using System.Runtime.InteropServices.ComTypes;


namespace Stringmanipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter the string:");
            name = Console.ReadLine();
            string leadingspace;
            string trailinspace;
            string underscore;
            string uppercase;
            if (name.Contains(" ")) {

                underscore = name.Replace(" ", "_");
                Console.WriteLine("The string with removing space with underscore:");
                Console.WriteLine(underscore);
            }
        
            uppercase = name.ToUpper();
            Console.WriteLine("The string with upper case:");
            Console.WriteLine(uppercase);
            Console.WriteLine("The string with leading spaces:");
            leadingspace = name.TrimStart();
            Console.WriteLine(leadingspace);
            Console.WriteLine("The string with trailing spaces:");
            trailinspace = name.TrimEnd();
            Console.WriteLine(trailinspace);
            Console.Read();
        }
    }
}
