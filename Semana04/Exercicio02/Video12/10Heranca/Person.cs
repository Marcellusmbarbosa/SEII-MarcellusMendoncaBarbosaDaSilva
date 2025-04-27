using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10Heranca
{
    public class Person
    {
        
        protected string name;
        protected int age;

        protected void messagePerson()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Age: " + age);
        }

    }
}