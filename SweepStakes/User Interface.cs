using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class User_Interface
    {

        public static string ContestantFirstName()
        {
            Console.WriteLine("What contestant would you like to add to the sweep stakes? (First Name)");
            string input = Console.ReadLine();
            return input;
        }
        public static string ContestantLastName()
        {
            Console.WriteLine("Last name");
            string input = Console.ReadLine();
            return input;
        }
        public static string ContestantEmail()
        {
            Console.WriteLine("E-mail");
            string input = Console.ReadLine();
            return input;
        }
        public static int ContestantRegistrationCode()
        {
            Console.WriteLine("Registration Code");
            try
            {

                int input = int.Parse(Console.ReadLine());
                return input;
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid registration code.");
                return ContestantRegistrationCode();
            }
        }
        public static string TypeOfManager()
        {
            Console.WriteLine("Would you like to run a stack or queue?");
            string input = Console.ReadLine();
            input = input.ToLower();
            if (input == "stack")
            {
                return input;
            }
            else if(input == "queue")
            {
                return input;
            }
            return TypeOfManager();
        }
        public static int HowManyContestants()
        {
            Console.WriteLine("How many contestants to add to sweep stakes?");
            try
            {
                int input = int.Parse(Console.ReadLine());
                return input;
            }
            catch(FormatException);
            {
                return HowManyContestants();
            }
        }
    }
}
