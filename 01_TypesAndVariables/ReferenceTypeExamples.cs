using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string ThisIsDeclaration;

            string declared;
            declared = "This is initialized.";

            // Concatenate

            string firstName = "Isaiah";
            string lastName = "Billiam";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            string newstring = "Whatever we want to be";
            Console.WriteLine(newstring);

            //composite

            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine("200");

            //interpolation
            string interpolationFullName =$"{firstName} {lastName}";
            Console.WriteLine("hello, my name is" + firstName + " " + lastName + ". Strings are great!");
            

        }
        [TestMethod]

        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World", "Why", "is it", "always", stringExample, "?" };
            string[] test = new string[5];


            //Lists

            List<string> listofstring = new List<string>();
            List<int> listofints = new List<int>();
            listofints.Add(42);
            listofstring.Add("42");

            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("John");
            firstInFirstOut.Enqueue("Jared");
            Console.WriteLine(firstInFirstOut.Peek());

            //Dictionaries

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(7, "James Bond");
            Console.WriteLine("James Bond");

            //Other Examples

            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueLists = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

        }
        [TestMethod]

        public void Classes()
        {
            Random rng = new Random();

        }
            
    }
}
