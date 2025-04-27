using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10Heranca
{
    public class Employer : Person
    {
        
        private double salary;

        public Employer(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;

            messagePerson();
            messageEmployer();
        }

        private void messageEmployer()
        {
            Console.WriteLine("Salary: " + salary);
        }

    }
}