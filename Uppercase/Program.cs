using System;
using System.Text;

namespace Uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            //This passes whatever the user entered into the literal string.
            //Then, it is assigned to a new string called result.
            Console.WriteLine("Type a sentence. {0} ", "");
            string result = Console.ReadLine();

            StringBuilder mystring = new StringBuilder();
            //The stringbuilder variable concatenates the result with to upper, making what the user entered all uppercase.
            mystring.Append(result.ToUpper());

            //This what the user entered in all uppercase letters to the console.
            Console.WriteLine(mystring);
            Console.ReadLine();
        }
    }
}
