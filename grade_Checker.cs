using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an integer variable for score
            int score = 0;
            // print your score
            Console.Write($"Enter your score: ");
            // convert string input to integer variable
            // creater an input for score inside the integer variable
            score = Int32.Parse(Console.ReadLine());
            // if score is greater than 90 print Excellent
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Excellent!");
            }
            // if the score is between 70 and 89 print Good Job
            else if (score >= 70 && score <= 89)
            {
                Console.WriteLine("Good Job!");
            }
            // if the score is between 50 and 69 print You passed
            else if (score >= 50 && score <= 69)
            {
                Console.WriteLine("You passed!");
            }
            // if the score is below 50 print You failed
            else if (score >= 0 && score <= 49)
            {
                Console.WriteLine("You failed");
            }
            // if the score is any number above 100 or below 0 print invalid
            else
            {
                Console.WriteLine("Invalid Score");
            }
                Console.ReadLine();
        }
    }
}
