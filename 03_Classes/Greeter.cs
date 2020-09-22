using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Greeter
    {
        public void hello(string name)
        {
            Console.WriteLine($"Hello there {name}");
        }

        public void hello()
        {
            Console.WriteLine("Hello Stranger");
        }

        Random _rando = new Random();

        public void randomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "Howdy", "Sup", "Hola", "Suh dude", "Hi Y'all", "Ni Hao" };
            int i = _rando.Next(0, availableGreetings.Length);
            Console.WriteLine(availableGreetings[i]);
            



        }
    }
}
