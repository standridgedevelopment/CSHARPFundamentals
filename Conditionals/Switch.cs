using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Conditionals
{
    [TestClass]
    public class Switch
    {
        enum WeekDay { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}
        [TestMethod]
        public void SwitchCases()
        {
            int input = 5;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("This is option 2");
                    break;
            }

            WeekDay today = WeekDay.Sunday;
            switch (today)
            {
                case WeekDay.Monday:
                case WeekDay.Tuesday:
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                case WeekDay.Friday:
                    Console.WriteLine("Hope you're ready to put in some work!");
                    break;
                case WeekDay.Sunday:
                case WeekDay.Saturday:
                    Console.WriteLine("Enjoy your weekend");
                    break;

            }
        }
        [TestMethod]
        public void SwitchExpressions()
        {
            string output;
            int action = 3;
            switch (action)
            {
                case 0:
                    output = "Case 0";
                    break;
                case 1:
                    output = "Case 1";
                    break;
                case 2:
                    output = "Case 2";
                    break;
                default:
                    output = "Default";
                    break;
            }
            output = action switch
            {
                0 => "Case 0",
                1 => "Case 1",
                2 => "Case 2",
                3 => "Case 3",
                _ => "Default Case",
            };
            Console.WriteLine(output);
        }
    }
}
