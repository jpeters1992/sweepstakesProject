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

        public static Guid GetRegistrationNumber()
        {
            return Guid.NewGuid();
        }

        public static void NewLine()
        {
            Console.WriteLine("");
        }

        public static ISweepstakesManager PickStackOrQueue()
        {
            Console.WriteLine("Please type one of these keywords: 'stack' or 'queue'");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "stack":
                    return new SweepstakesStackManager();                    
                case "queue":
                    return new SweepstakesQueueManager();                    
                default:
                    throw new ApplicationException(string.Format("Not a valid manager choice")); 
                    
            }
        }
    }
}
