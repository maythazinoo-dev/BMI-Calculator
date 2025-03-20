using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight in pounds : ");
            int weight = int.Parse(Console.ReadLine());

            Console.Write("enter your height in feet: ");
            int feet = int.Parse(Console.ReadLine());

            Console.Write("Enter your weight in inches : ");
            int inches = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // 1 feet = 12 inches 

            int totalInches = (feet * 12) + inches;

            //BMI Calculation
            // bmi = (weight *703)/(height^2)
           

            double bmi = (weight * 703) / (totalInches * totalInches);
            string fmt = "{0,10} | {1,10} {2, 10} | {3,10}";
            Console.WriteLine(string.Format(fmt, "Weight", "Feet", "Inches", "Category"));
            Console.WriteLine(new String('-',60));

            if (bmi < 18.5 )
            {
               
                Console.WriteLine(string.Format(fmt,weight,feet,inches, "Under Weight\n\n"));
                Console.WriteLine("Your weight status Category : Under Weight");
            }
            else if(bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine(string.Format(fmt, weight, feet, inches, "Normal Weight\n\n"));
                Console.WriteLine("Your weight status Category : Normal Weight");
              
            }
            else if(bmi >= 25 && bmi < 30)
            {
                Console.WriteLine(string.Format(fmt, weight, feet, inches, "Over Weight\n\n"));
                Console.WriteLine("Your weight status Category : Over Weight");
              
            }
            else
            {
                Console.WriteLine(string.Format(fmt, weight, feet, inches, "Obese Weight\n\n"));
                Console.WriteLine("Your weight status Category : Obese Weight");
               
            }

            Console.ReadLine();
        }
    }
}
