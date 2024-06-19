using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            FindLargestNumber(num1, num2, num3);
        }

        static void FindLargestNumber(int num1,int num2, int num3)
        {
            int Largest = num1;
            if (num2 > Largest)
            {
                Largest = num2;
            }
            if (num3 > Largest)
            {
                Largest = num3;
            }

            Console.WriteLine($"The largest Number is :{Largest}");
            Console.ReadLine();
        }
    }
}
