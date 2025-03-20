using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMonth
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This number is 1 to 12 ");
            Console.Write("Please enter your number : ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 12) 
            { 
                if (num == 1)
                {
                    Console.WriteLine("January month");
                }
                else if (num == 2)
                {
                    Console.WriteLine("February month");
                }
                else if (num == 3)
                {
                    Console.WriteLine("March month");

                }
                else if (num == 4)
                {
                    Console.WriteLine("April month");
                }
                else if (num == 5)
                {
                    Console.WriteLine("May month");
                }
                else if (num == 6)
                {
                    Console.WriteLine("June month");
                }
                else if (num == 7)
                {
                    Console.WriteLine("July month");
                }
                else if (num == 8)
                {
                    Console.WriteLine("August month");

                }
                else if (num == 9)
                {
                    Console.WriteLine("September month");
                }
                else if (num == 10)
                {
                    Console.WriteLine("October month");
                }
                else if (num == 11)
                {
                    Console.WriteLine("November month");
                }
                else if (num == 12)
                {
                    Console.WriteLine("December month");
                }

        }
            else
            {
                Console.WriteLine("Wrong Input. Try Again !");
            }

        Console.ReadLine();
    }
    }
}

