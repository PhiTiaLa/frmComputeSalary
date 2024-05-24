﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;
        public string FirstName { get { return first_name; } set { first_name = value; } }
        public string LastName { get { return last_name; } set { last_name = value; } }
        public string Department { get { return department; } set { department = value; } }
        public string JobTitle { get { return job_title; } set { job_title = value; } }
        public double BasicSalary { get { return basic_salary; } set { basic_salary = value; } }
        public PartTimeEmployee(string FName, string Lname, string dept, string job) { 
            FirstName = FName;
            LastName = Lname; 
            Department = dept;
            JobTitle = job; 
        }
        public void computeSalary(int hoursWorked, double ratePerHour) { 
        BasicSalary = hoursWorked * ratePerHour;
        }
        public double getSalary() { 
        return BasicSalary;
        }
    }
}