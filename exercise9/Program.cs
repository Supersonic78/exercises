using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercise_9
{
    class Program
    {
        static List<Employee> EmployeeList = new List<Employee>();
        static List<Logger> ListOfLogs = new List<Logger>();
        static Logger mylogger = new Logger();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("1.Add employee");
                Console.WriteLine("2.Remove employee");
                Console.WriteLine("3.Print entire registry");
                Console.WriteLine("4.Exit");
                Console.WriteLine("5.Print Log");
                Console.WriteLine("6.Show filtered search");
                Console.WriteLine("");
                Console.WriteLine("Enter choice:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1.Add employee");
                        AddNewEmployee();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2. Remove employee");
                        RemoveEmployee();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("3. Print entire registry");
                        PrintEmployees();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("4");
                        running = false;
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("5. Print log");
                        mylogger.Print();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("6.Filtered search");
                        ListFilteredSearch();
                        break;
                }
            }
        }

        public static void AddNewEmployee()
        {
            Console.WriteLine("Input first name: ");
            string tempFirstName = Console.ReadLine();
            Console.WriteLine("Input Last name: ");
            string tempLastName = Console.ReadLine();
            Console.WriteLine("Input Social security number: ");
            string tempSsNbr = Console.ReadLine();
            Console.WriteLine("Input hourly wage: ");
            double tempHourlyWage = double.Parse(Console.ReadLine());
            
            EmployeeList.Add(new Employee(tempFirstName, tempLastName, tempSsNbr, tempHourlyWage));

            mylogger.Log($"Added employee {tempFirstName} {tempLastName}");
            
            Console.ReadLine();
        }

        public static void PrintEmployees()
        {
            foreach (Employee employee in EmployeeList)
            {
                Console.Clear();
                Console.WriteLine($"{employee.FullName}, {employee.SocialSecurityNbr}, {employee.HourlyWage}");
                Console.WriteLine(" ");
                Console.ReadKey();
            }
        }

        public static void ListFilteredSearch()
        {
            Console.WriteLine("Input 2 first digits in sscnbr");
            string userinput = Console.ReadLine();
            foreach (Employee employee in EmployeeList)
            {
                //if (userinput.StartsWith(employee.SocialSecurityNbr))
                if (employee.SocialSecurityNbr.StartsWith(userinput))
                {
                    Console.WriteLine(employee.FirstName);
                    break;
                }
            }
        }

        public static void RemoveEmployee()
        {
            Console.WriteLine("Input social security number (10 numbers): ");
            string tempInputSSNbr = Console.ReadLine();

            foreach (Employee employee in EmployeeList)
            {
                if (employee.SocialSecurityNbr.Equals(tempInputSSNbr))
                {
                    EmployeeList.Remove(employee);
                    mylogger.Log($"Removed {employee.FirstName} from the list");
                    break;
                }
            }

            //string.Compare(tempInputSSNbr, EmployeeList) 
        }
    }
}
