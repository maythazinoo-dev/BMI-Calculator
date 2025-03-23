using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number : ");
            int num1 = int.Parse(Console.ReadLine());

            int range50 = 0;
            int range75 = 0;
            int range150 = 0;
            int range2 = 0;
            int range200 = 0;
            int range257 = 0;

            
            if (num1 >= 1 && num1 <= 257)
            {
                if(num1 >= 1 && num1 <= 50)
                {
                    range50 = 50;
                   
                }
                if(num1 >= 51 && num1 <= 75)
                {
                    range50 = 50;
                    range75 = Math.Min(num1 - 50, 25);
                   
                }
                if(num1 >=  76 && num1 <= 150)
                {
                    range50 = 50;
                    range75 = 25;
                    range150 = Math.Min(num1 - 75, 75);
                }
                if(num1 >= 151 && num1 <= 200)
                {
                    range50 = 50;
                    range75 = 25;
                    range150 = 75;
                  
                    range200 = Math.Min(num1 - 150, 50);
                }
                if (num1 >= 201 && num1 <= 257)
                {
                    range50 = 50;
                    range75 = 25;
                    range150 = 75;
                    range200 = 50;
                    range257 = Math.Min(num1 - 200, 257);
                }

                Console.WriteLine($"For num = {num1}, result = {range50},{range75},{range150},{range200},{range257}");

            }
            else
            {
                Console.WriteLine("Wrong input ! Please Try again");
            }
            
            Console.ReadLine();
        }
        
    }
}
