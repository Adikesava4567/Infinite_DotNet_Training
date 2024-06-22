using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_3
{
    class Distance
    {
        public int dist1;
        public Distance(int d)
        {
            dist1=d;
        }

        //overloading ++
        public static Distance operator ++(Distance dis1)
        {
            Distance temp = new Distance(1);
            temp.dist1 = dis1.dist1 + 1;
            return temp;


        }


  

        static void Main(string[] args)
        {
            Distance d1 = new Distance(5);
            d1++;
            Console.WriteLine(d1.dist1);
            Console.Read();
            
        
        }


    }

}
