using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07Constructor
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Construtor executed successfully");
        }

        public Person(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        
    }
}