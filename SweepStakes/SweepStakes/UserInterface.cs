﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface //use a STATIC class when you only care about the output
    {
        //MEMBER VARIABLES
        static int registrationNumber = 0;

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

        public static int GetRegistrationNumber() //build out this RNG
        {
            Console.WriteLine("Here is your registration number!");
            int registrationNumber = int.Parse(Console.ReadLine());
            return registrationNumber;
        }

        public static void NewLine()
        {
            Console.WriteLine("");
        }
    }
}
