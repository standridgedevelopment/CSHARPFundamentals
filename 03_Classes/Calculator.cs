using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        // -

        public double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }
        // *

        public double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }
        // /

        public double Divide(double a, double b)
        {
            double result = a / b;
            return result;
        }
        // %

        public double Modulo(double a, double b)
        {
            double result = a % b;
            return result;
        }

        public int Age(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
