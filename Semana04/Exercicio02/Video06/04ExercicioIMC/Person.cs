using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04ExercicioIMC
{
    public class Person
    {
        public double height;
        public double weight;

        public double bmi()
        {
            return (weight/(height*height));
        }

        public string situation(double bmi)
        {
            if (bmi < 18.5)
                return "underweight";
            else if (bmi < 25)
                return "normal";
            else if (bmi < 30)
                return "overweight";
            else if (bmi < 35)
                return "obesity 1";
            else if (bmi < 40)
                return "obesity 2";
            else
                return "obesity 3";
        }

        public void message(){
            double getBMI = bmi();
            string catSituatuion = situation(getBMI);

            Console.WriteLine("The person with " + height + " m and " + weight + " kg, has a BMI of: " + getBMI + "!");
            Console.WriteLine("The situation is: " + catSituatuion + "!");
        }
    }
}