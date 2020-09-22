using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry == true)
            {
                Console.WriteLine("You should probs eat something friend");
                Console.WriteLine("That's rough buddy");
            }

            int hoursSpentStudying = 4;

            if (hoursSpentStudying <= 10)
            {
                Console.WriteLine("Are you even trying?");
            }
            else if (hoursSpentStudying > 10)
            {
                Console.WriteLine("Wow, try hard much?");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone == true)
            {
                Console.WriteLine("Go have fun playing animal crossing");
            }
            else
            {
                Console.WriteLine("You need to finish your chores.");
            }

            int age = 19;
            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else
            {
                if (age > 12)
                {
                    Console.WriteLine("You are a teenager");
                }
                else if (age > 2)
                {
                    Console.WriteLine("You are just a little kid");
                }
                else
                {
                    Console.WriteLine("You are a tiny little baby");
                }
            }

            if (age < 65 && age > 18)
            {
                Console.WriteLine("Your age is between 19 and 64");
            }

        }
    }
}
