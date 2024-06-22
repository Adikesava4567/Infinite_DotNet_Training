using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_3
{
    public class Program
    {
        static int data1;
        string str;
        public float fvar = 22.5f;
        public static string s = "hello all";
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(data1 + " ",p.str + " ",p.fvar + " " + s);
            Console.Read();
        }
    }
}
