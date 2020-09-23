using System;
using System.Collections.Generic;
using _09_Interfaces_Introduction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IFruit banana = new Banana();
            var output = banana.Peel();
            Console.WriteLine(output);
            Banana bananaTwo = new Banana();
            var anotherOutput = bananaTwo.Peel();
            Console.WriteLine(anotherOutput);
        }
        [TestMethod]
        public void InterfacesinCollections()
        {
            var orangeObject = new Orange();
            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Grape(),
                new Orange(true),
                orangeObject
            };
        }
        private string GetFruitName (IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}.";
        }
        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();
            var output = GetFruitName(grape);
            Console.WriteLine(output);
        }
        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Grape(),
                new Orange(true),
                new Banana(),
                new Orange(),
                new Banana(true),
                new Grape(),
                new Orange(true)
            };
            
            foreach(var oneFruit in fruitSalad)
            {
                if (oneFruit is Orange orangeObject)
                {
                    Console.WriteLine("Is the orange peeled?");
                    if (orangeObject.IsPeeled)
                    {
                        Console.WriteLine("This is a peeled orange");
                        orangeObject.Squeeze();
                    }
                    else
                    {
                        Console.WriteLine("HEY! Dont squeeze that yet! It isnt peeled?");
                    }
                }
                else if (oneFruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine($"This is a {oneFruit.Name}");
                    var grape = (Grape)oneFruit;
                }
                else if (oneFruit.IsPeeled)
                {
                    Console.WriteLine("That is a peeled banana");
                }
                else
                {
                    Console.WriteLine("One unpeeled banana...Weird to see in a fruit salad.");
                }
            }
        }
        
    }
}
