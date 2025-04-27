using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09This
{
    public class Person
    {
        
        private string name = "Eder";

        public Person(string name)
        {
            Console.WriteLine(name);
            Console.WriteLine(this.name);
        }

    }
}