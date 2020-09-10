using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclarationAndInitialized = false;
            isDeclarationAndInitialized = true;
        }
       [TestMethod]
       public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sbyteExample = -128;
            short shortExample = 32757;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 1241324241421421;
            Int64 longMin = -9223372036854775808;

            int a = 42;
            int b = 20;

            byte age = 87;
        }
        [TestMethod]
        public void Deciamls()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.43253252352d;
            decimal decimalExample = 1.24354365465345345m;

            //Console.WriteLine(1.24354365465345345f);
            //Console.WriteLine(1.24354365465345345d);
            //Console.WriteLine(1.24354365465345345m);
        }
        enum PastryType { Cake, Cupcake, Croissants, Pie, Donut}
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissants;
            PastryType anotherOne = PastryType.Cupcake;
        }
        [TestMethod]

        public void Structs()
        {
            Int32 age = 112;

            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime birthday = new DateTime(1805, 12, 03);
        }
        
    }
}
