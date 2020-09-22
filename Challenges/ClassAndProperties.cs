using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges
{
    [TestClass]
    public class ClassAndProperties
    {
        [TestMethod]
        public void TestProps()
        {
            DateTime bday = new DateTime(1988, 12, 19);
            PropertyTests test = new PropertyTests("Bob", "Boblaw", 55, bday);
            int age = test.HowOld();
            Console.WriteLine(age);
        }
    }

    public class PropertyTests
    {
        public String FirstName;
        public string LastName;
        public int ID;
        public DateTime Birthday = new DateTime();

        public string FullName()
        {
            string fullName = $"{FirstName} {LastName}";
            return fullName;
        }
        public int HowOld()
        {
            DateTime bday = Birthday;
            double totalTime = (DateTime.Now - bday).TotalDays / 365.25;
            return Convert.ToInt32(Math.Floor(totalTime));
        }

        public PropertyTests() { }
        public PropertyTests(string firstName, string lastName, int id, DateTime bDay)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            Birthday = bDay;
        }
    }
}
