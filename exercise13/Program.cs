using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your name");
            string name = Console.ReadLine();
         
            Console.WriteLine("input your birth year YYYY");
            int YYYY = int.Parse(Console.ReadLine());
            Console.WriteLine("input your birth month");
            int MM = int.Parse(Console.ReadLine());
            Console.WriteLine("input your birth day");
            int DD = int.Parse(Console.ReadLine());

            DateTime fullDate = new DateTime(YYYY, MM, DD);
            TimeSpan age = (DateTime.Now - fullDate);
            double dblage = Math.Truncate((age.TotalDays / 365));
            int cDblage = Convert.ToInt32(dblage);
            double yearsLeftoHundred = 100 - dblage;
            int cYearsLefttoHundred = Convert.ToInt32(yearsLeftoHundred);
           
            DateTime yearsLater = DateTime.Now.AddYears(cYearsLefttoHundred);
            DateTime nextBirthday = fullDate.AddYears(cDblage + 1) ;
            TimeSpan daysToB = nextBirthday - DateTime.Now;

            Console.WriteLine("Hello " + name + " you are " + cDblage + " and you will turn " + (cDblage + 1) + " in " + daysToB.Days + " days.");
            Console.WriteLine("Your 100th birthday will be on a " + yearsLater.DayOfWeek + ".");
            DateTime a = new DateTime();
            a.ToLongDateString();
            Console.WriteLine(a);
           
            
            
            






        }
    }
}
