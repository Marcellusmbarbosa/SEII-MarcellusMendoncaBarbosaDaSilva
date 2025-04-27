using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03ExercicioEscolar
{
    public class Student
    {

        public string name;
        public double mark1, mark2;

        public double average()
        {
            return ((mark1+mark2)/2);
        }

        public string situation(double average)
        {
            return average >= 7 ? "approved" : "reproved";
        }

        public void message()
        {
            double getAverage = average();

            string catSituation = situation(getAverage);

            Console.WriteLine(name + " is " + catSituation + " with " + getAverage + " of average");
        }
        
    }
}