using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void GreeterMethodExecution()
        {
            Greeter hello = new Greeter();
            hello.hello("Isaiah");
            hello.hello();
            hello.randomGreeting();
            hello.randomGreeting();
            hello.randomGreeting();
            hello.randomGreeting();
        }
    }
}
