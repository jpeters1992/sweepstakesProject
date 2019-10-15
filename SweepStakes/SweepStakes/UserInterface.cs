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
            Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            Console.ReadLine();
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("What is your email address?");
            Console.ReadLine();
        }

        public static int GetRegistrationNumber()
        {
            Console.WriteLine("What is your registration Number?");
            Console.ReadLine();
        }
    }
}
