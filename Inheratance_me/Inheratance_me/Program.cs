using System;
namespace Inheratance_me
{
    class Employee
    {
        public int EmployeeId;
        public String EmployeeName;
        public int EmployeeAge;
        public double EmployeeCotectNo;

    }
    class VisitingEmployee : Employee
    {
        public int VisitingSalary;
        public int Visitinghours;
    }
class PermanentEmployee : Employee
{
        public int PermanentSalary;
        public int Permanenthours;
    }

    class program
    {
        static void Main(String[] args)
        {
            PermanentEmployee Shu = new PermanentEmployee();
            Shu.EmployeeId = 105;
            Shu.EmployeeName = "Shubham Kumar Jha";
            Shu.EmployeeAge = 22;
            Shu.EmployeeCotectNo = 7549704574;
            Shu.PermanentSalary = 25000;
            Shu.Permanenthours = 100;

            VisitingEmployee Shi = new VisitingEmployee();
            Shi.EmployeeId = 102;
            Shi.EmployeeName = "Shivam Kumar Jha";
            Shi.EmployeeAge = 19;
            Shi.EmployeeCotectNo = 8056215632;
            Shi.VisitingSalary = 15000;
            Shi.Visitinghours = 50;

            Console.WriteLine("\tPermanent Employee Data : \n");
            Console.WriteLine("Employee Id : " + Shu.EmployeeId);
            Console.WriteLine("Employee Name : " + Shu.EmployeeName);
            Console.WriteLine("Employee Age : " + Shu.EmployeeAge);
            Console.WriteLine("Employee Cotect No : " + Shu.EmployeeCotectNo);
            Console.WriteLine("Permanent Salary : " + Shu.PermanentSalary);
            Console.WriteLine("Permanent hours : " +Shu.Permanenthours);
            
            Console.WriteLine("\n");

            Console.WriteLine("\tVisiting Employee Data : \n");
            Console.WriteLine("Employee Id : " + Shi.EmployeeId);
            Console.WriteLine("Employee Name : " + Shi.EmployeeName);
            Console.WriteLine("Employee Age : " + Shi.EmployeeAge);
            Console.WriteLine("Employee Cotect No : " + Shi.EmployeeCotectNo);
            Console.WriteLine("Visiting Salary : " + Shi.VisitingSalary);
            Console.WriteLine("Visiting hours : " + Shi.Visitinghours);
            Console.ReadLine();
        }
    }
}
