using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputString))
            {
                string newString = ExchangeFirstAndLastCharacters(inputString);
                Console.WriteLine($"New string : {newString}");
            }
            else
            {
                Console.WriteLine("Input string is empty");
            }
            Console.Read();
        }
        static string ExchangeFirstAndLastCharacters(string input)
        {
            if (input.Length < 2)
            {
                return input;
            }

            char firstChar = input[0];
            char lastChar = input[input.Length - 1];

            string newstring = lastChar + input.Substring(1, input.Length - 2) + firstChar;
            return newstring;
        }
    }
}
