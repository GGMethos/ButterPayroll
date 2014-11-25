using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterPayroll
{
    public class Employee
    {
        public String employeeID { get; set; }
        //Personal Information
        public String firstName { get; set; }
        public String lastName { get; set; }

        //Payment Information
        public String accountNum { get; set; }
        public String routingNum { get; set; }
        public double hours { get; set; }

        //Address
        public String street { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zipCode { get; set; }

        public bool fullTime { get; set; }
        public bool directDeposit { get; set; }

        public Employee(String EmployeeID, String firstName, String lastName, 
            String street, String city, String state, String zipCode,
            String accountNum, String routingNum, double hours) 
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

        public Employee() { 
        }

        public double pay { get; set; }
        public double tax { get; set; }
        public object company { get; set; }

        public object planId { get; set; }

        public object planName { get; set; }

        public object description { get; set; }

        public object cost { get; set; }

        public object optical { get; set; }

        public object dental { get; set; }
    }
}
