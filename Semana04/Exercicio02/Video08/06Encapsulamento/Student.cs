using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06Encapsulamento
{
    public class Student
    {
        
        private double mark1, mark2;

        private double average()
        {
            return ((mark1+mark2)/2);
        }

        public void message()
        {
            Console.WriteLine("Insert the first mark:");
            mark1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert the second mark:");
            mark2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The average is " + average());
        }

    }
}