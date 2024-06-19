using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter position to remove: ");
            int position;
            bool isValidPosition = int.TryParse(Console.ReadLine(), out position);

            if (isValidPosition && position >=0 && position < inputString.Length)
            {
                string result = RemoveCharAtPosition(inputString, position);
                Console.WriteLine("Resulting String: " + result);
            }
            else
            {
                Console.WriteLine("Invalid position");
            }
            Console.Read();
        }

        static string RemoveCharAtPosition(string str, int pos)
        {
            return str.Substring(0, pos) + str.Substring(pos + 1);
        }
    }
}
