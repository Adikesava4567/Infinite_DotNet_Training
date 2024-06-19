using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first Number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("3. Write a c# program that takes 2 numbers from the user, and then performs (+,/,-,*) on them and display the results seperately");

            int add = n1 + n2;
            Console.WriteLine($"addition of n1 and n2 is {add}");
            int sub = n1 - n2;
            Console.WriteLine($"Subtraction of n1 and n2 is {sub}");
            int prod = n1 * n2;
            Console.WriteLine($"Multiplication of n1 and n2 is {prod}");
            int div = n1 / n2;
            Console.WriteLine($"division of n1 and n2 is {div}");

            //Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("2. Write a C# program to check whether a given number is positive or negative?");
            //Console.ReadLine();

            Console.WriteLine("Enter third Number : ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n3 < 0)
                Console.WriteLine("given third number is negative");
            else if (n3 > 0)
                Console.WriteLine("given third number is positive");
            else
                Console.WriteLine("given third number is neither pos nor neg");
            //Console.ReadLine();

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1. Write a C# program to accept 2 integers and check whether they are equal?");

            Console.WriteLine("Enter fourth Number : ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter five Number : ");
            int n5 = Convert.ToInt32(Console.ReadLine());
            if (n4 == n5)
                Console.WriteLine("Both Numbers are Equal");
            else
                Console.WriteLine("Both Numbers are not Equal");
            

            Console.WriteLine("please click on ENTER to exit.......");

            Console.ReadLine();


        }
    }


}
