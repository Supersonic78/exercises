using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            employee e1 = new employee("Nisse ","Nilsson"," 700409-2334",150);
            employee e2 = new employee("Bartil ", "Bartilsson", " 60409-2334", 150);
            employee e3 = new employee("Gösta ", "Göstasson", " 500409-2334", 150);
            employee e4 = new employee("Ingrid ", "Ingridsson", " 400409-2334", 150);
            employee e5 = new employee("Gunlög ", "Gunlögsson", " 300409-2334", 150);
            List<employee> EmployeeList = new List<employee>();
            EmployeeList.Add(e1);
            EmployeeList.Add(e2);
            EmployeeList.Add(e3);
            EmployeeList.Add(e4);
            EmployeeList.Add(e5);

            foreach (employee employee in EmployeeList)
            {
                //Console.WriteLine(employee.FirstName + " " + employee.LastName + " ");
                //Console.WriteLine(employee);
               Console.WriteLine(employee.FullName);
            }
        }
    }
}
