using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting;
using _06_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inheritence_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            Person martha = new Person();
            martha.SetFirstName("Martha");
            martha.SetLastName("Smith");
            Console.WriteLine(martha.Name);

            Customer bob = new Customer();
            bob.SetFirstName("Bobert");
            bob.SetLastName("Boss");

            SalaryEmployee tedEmployee = new SalaryEmployee
            {
                PhoneNumber = "1800-fakenumber",
                Salary = 800000,
                HireDate = new DateTime(1304, 01, 01),
                EmployeeNumber = 394
            };
            Console.WriteLine(tedEmployee.YearsWithCompany);
        }
        [TestMethod]
        public void EmployeeTests()
        {
            Employee jarvis = new Employee();
            HourlyEmployee tony = new HourlyEmployee();
            SalaryEmployee pepper = new SalaryEmployee();
            jarvis.SetFirstName("Jarvis");
            tony.HoursWorked = 55;
            tony.HourlyWage = 3000;
            tony.SetFirstName("Tony");
            pepper.Salary = 200000;
            pepper.SetFirstName("Pepper");
            pepper.PhoneNumber = "317-730-2728";
            HourlyEmployee peter = new HourlyEmployee();
            SalaryEmployee happy = new SalaryEmployee();
            happy.Salary = 150000;
            happy.SetFirstName("Happy");
            peter.SetFirstName("Peter");

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(jarvis);
            allEmployees.Add(tony);
            allEmployees.Add(pepper);
            allEmployees.Add(peter);
            allEmployees.Add(happy);

            foreach (Employee worker in allEmployees)
            {
                Console.WriteLine($"{worker.Name}'s phone number is {worker.PhoneNumber}");

                if (worker.GetType() == typeof(SalaryEmployee))
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker;
                    Console.WriteLine($"{worker.Name} is a salary employee that makes {sEmployee.Salary}");
                }
                else if (worker is HourlyEmployee hourlyWorker)
                {
                    Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours!");
                }
            }               
        }
    }
}
