using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNet_3;

namespace DotNet_Day3_Another
{
    class CallingProgram
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.fvar = 22.58756565f;
            program.s = "world";
        }
    }
}
