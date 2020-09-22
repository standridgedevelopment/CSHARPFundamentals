using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            int age = 31;
            // (Conditional/Boolean) ? trueResult ; falseResult;
            bool isAdult = (age > 17) ? true : false;
            Console.WriteLine(isAdult);

            int numOne = 10; //UserInput
            string output = (numOne == 10) ? "You Guessed Correctly" : "You did not guess correctly";
            Console.WriteLine((output == "You Guessed Correctly") ? "Congrats" : "Try Again"); 
        }
    }
}
