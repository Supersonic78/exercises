using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_9

{
    class Employee

    {
       
        public string FirstName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        
        public string LastName { get; set; }
        public string SocialSecurityNbr { get; set; }
        public double HourlyWage { get; set; }
        


        public Employee(string firstName, string lastName, string socialSecurityNbr, double hourlyWage)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNbr = socialSecurityNbr;
            HourlyWage = hourlyWage;
        }

        //public override string ToString()
        //{
        //    return FirstName + LastName + SocialSecurityNbr + HourlyWage;
        //}

        public Employee(string socialSecurityNbr)
        {
            SocialSecurityNbr = socialSecurityNbr;

        }

       
    }
}
