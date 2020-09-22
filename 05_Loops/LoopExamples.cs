using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total++;
            }
            total = 0;
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal Reached");
                    break;
                }
                total++;
            }

            //code to print any number other than 6 or 12 and end at 15.
            bool keepLooping = true;
            Random rando = new Random();
            int rNumber;
            while (keepLooping)
            {
                rNumber = rando.Next(1, 20);
                if (rNumber == 6 || rNumber == 12)
                {
                    continue;
                }

                Console.WriteLine(rNumber);
                if(rNumber == 15)
                {
                    keepLooping = false;
                }

            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 47;
            for (int i = 46; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }
            string [] students = { "Jonathon", "Tomislav", "Gordon", "Adam", "Andrew", "Amanda" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Hello there {students[i]}!");
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Jonathon", "Tomislav", "Gordon", "Adam", "Andrew", "Amanda" };

            foreach(string i in students)
            {
                Console.WriteLine($"Hello my name is {i}");
            }

            string myName = "Amanda Joy Knight";
            foreach (char i in myName)
            {
                Console.Write(i);
            }
        }
        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
            }
            while (iterator > 5);
        }
    }
}
