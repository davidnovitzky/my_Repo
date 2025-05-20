using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Eligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create integer variable for age
            int age = 0;
            // create integer variable for height
            int height = 0;
            // display prompt to enter your age
            Console.Write("Enter your age: ");
            // convert string to int
            // record user input to age variable
            age = Int32.Parse(Console.ReadLine());
            // display prompt to enter your height
            Console.Write("Enter your height (cm): ");
            // convert string to int
            // record user input to height variable
            height = Int32.Parse(Console.ReadLine());
            // condition check if age is greater than 10 AND at least 120 cm tall
            // print You can go on the ride!
            if (age >= 10 && height >= 120)
                Console.WriteLine("You can go on the ride!");
            // condition check if age is greater than 10 and shorter than 120 cm tall
            // print You almost qualify
            else if (age >= 10 && height < 120 || age < 10 && height >= 120)
                Console.WriteLine("You almost qualify!");
            else
                Console.WriteLine("Sorry, you can't go on the ride.");
            // pause
            Console.ReadLine();
        }
    }
}
