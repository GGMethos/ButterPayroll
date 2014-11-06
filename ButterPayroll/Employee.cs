using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterPayroll
{
    class Employee
    {
        string employeeID { get; set; }
        //Personal Information
        string firstName { get; set; }
        string lastName { get; set; }

        //Payment Information
        string accountNum { get; set; }
        string routingNum { get; set; }
        double hours { get; set; }

        //Address
        string street { get; set; }
        string city { get; set; }
        string state {get;set;}
        string zipCode{get;set;}

        bool fullTime { get; set; }
        bool directDeposit { get; set; }

        public Employee(string EmployeeID, string firstName, string lastName, 
            string street, string city, string state, string zipCode,
            string accountNum, string routingNum, double hours) 
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.state = street;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.accountNum = accountNum;
            this.routingNum = routingNum;
            this.hours = hours;
        }
    }
}
