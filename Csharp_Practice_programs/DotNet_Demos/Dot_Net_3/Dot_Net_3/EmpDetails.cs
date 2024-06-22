using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_3
{
    class EmpDetails
    {
        int Empid;
        string EmpName;
        DateTime doj;
        float salary;

        public void GetEmpDetails()
        {
            Console.WriteLine("Enter id, name, doj, salary :");
            Empid = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            doj = Convert.ToDateTime(Console.ReadLine());
            salary = Convert.ToSingle(Console.ReadLine());
        }

        public void ShowEmpDetails()
        {
            Console.WriteLine($"Employee Id {Empid}, Employee Name {EmpName}, Date of Joining {doj}, salary of Employee {salary}");
        }

    }
    class EmployeeTest
    {
        public static void Main()
        {
            EmpDetails empdetails = new EmpDetails();
            empdetails.GetEmpDetails();
            empdetails.ShowEmpDetails();
            Console.Read();
        }

    }
}


