using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01Conceitos
{
    public class Person
    {
        
        public string name;
        public int age;

        public void message()
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
        }

    }
}