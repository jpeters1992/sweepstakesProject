﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {
        //MEMBER VARIABLES
        Dictionary<string, int> contestants = new Dictionary<string, int>();

        //CONSTRUCTOR

        //MEMBER METHODS
        public Sweepstakes (string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = UserInterface.GetFirstName();
            UserInterface.NewLine();
            contestant.LastName = UserInterface.GetLastName();
            UserInterface.NewLine();
            contestant.EmailAddress = UserInterface.GetEmailAddress();
            UserInterface.NewLine();
            contestant.RegistrationNumber = UserInterface.GetRegistrationNumber();
            UserInterface.NewLine();
        }

        public Contestant PickWinner()
        {
            return new Contestant();
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant Name: "+contestant.FirstName+" "+contestant.LastName);
            Console.WriteLine("Contestant Email Address: " + contestant.EmailAddress);
            Console.WriteLine("Contestant Registration#: " + contestant.RegistrationNumber);
        }
    }
}
