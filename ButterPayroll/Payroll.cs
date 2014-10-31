﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterPayroll
{
    class Payroll
    {
        struct Employee {
            //Personal Information
            string firstName { get; set; }
            string lastName { get; set; }

            //Payment Information
            string accountNum { get; set; }
            string routingNum { get; set; }
            double hours { get; set; }

            //Address
            string street { get; set; }
            string city { get; set;}

            bool fullTime { get; set; }
            bool directDeposit { get; set; }
        }

        List<Employee> employees;

        /// <summary>
        /// Constructor
        /// </summary>
        public Payroll() {
            employees = new List<Employee>();
        }

        /// <summary>
        /// reads database
        /// adds Employees to employees from database
        /// </summary>
        public void getEmployeeData(){
            Employee tempEmployee;
        }

    }
}
