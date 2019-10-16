using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface 
    {
        //MEMBER VARIABLES
        public static int registrationNumber = 0;

        //CONSTRUCTOR

        //MEMBER METHODS
        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            return firstName;
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("What is your email address?");
            string emailAddress = Console.ReadLine();
            return emailAddress;
        }

        public static int GetRegistrationNumber(int randomResult) //build out this RNG
        {
            Console.WriteLine("Here is your registration number" +randomResult);
            return registrationNumber;
        }

        public static int RandomNumber()
        {
            Random randomRegNumber = new Random();
            int randomResult = randomRegNumber.Next();
            return randomResult;
        }

        public static void NewLine()
        {
            Console.WriteLine("");
        }

        public static string PickStackOrQueue()
        {
            Console.WriteLine("Please type one of these keywords: 'stack' or 'queue'");
            string managerSelection = Console.ReadLine();
            switch (managerSelection)
            {
                case "stack":
                    managerSelection = new SweepstakesStackManager();
                    break;
                case "queue":
                    managerSelection = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid choice, please make a valid selection.");
                    break;

            }
        }
    }
}
