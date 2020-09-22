using System;
using System.Collections.Generic;
using _06_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inheritence_Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void CatTesting()
        {
            Cat firstCat = new Cat();
            firstCat.Move();
            firstCat.MakeSound();

            Liger oneLiger = new Liger();

            List<Animal> allAnimals = new List<Animal>();
            allAnimals.Add(firstCat);
            allAnimals.Add(oneLiger);
            oneLiger.Move();
            oneLiger.MakeSound();
            //Try making other classes that inherit from animal class

            

        }
    }
}
