using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void CondditionsAndLoops()
        {
            string word = "Supercalifragilisticexpialidocious";

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }


            foreach (char i in word)
            {
                if (i == 'i')
                {
                    Console.WriteLine("i");
                }
                if (i == 'l')
                {
                    Console.WriteLine("l");
                }
                else
                {
                    Console.WriteLine("Not an i or an l."); 
                }
            }


            int total = 0;
            for (int i = 0; i < word.Length; i++)
            {
                total++;
            }
            Console.WriteLine(total);


        }
    }
}
