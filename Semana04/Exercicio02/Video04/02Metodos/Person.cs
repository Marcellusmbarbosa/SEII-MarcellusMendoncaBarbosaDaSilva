using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02Metodos
{
    public class Person
    {
        
        public void presents()
        {
            Console.WriteLine("Hello!!!");
        }

        public void presents(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public void presents(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old"); 
        }
        
    }
}