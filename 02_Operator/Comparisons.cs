using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operator
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 142;
            string username = "Sandy";
            bool equals = age == 12;
            bool userisAdam = username == "Sponebob";

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool listsAreEqual = firstList == secondList;
            bool greaterThan = age > 10;
            bool lessThan = age < 9001;
            bool lessThanorEqual = age <= 142;

            bool orValue = greaterThan || lessThan;
            bool anotherOr = age < 9005 || username == "banana";

            bool andValue = greaterThan && lessThan;
            bool anotherAnd = username == "Sandy" && age >= 42;
        }
    }
}
